using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.SqlServer.Server;

namespace DVLD_DataAccess
{
    public class clsApplicationData
    {
        public static bool GetApplicationInfoByID
            (
             int ApplicationID,
             ref int ApplicantPersonID,
             ref DateTime ApplicationDate,
             ref int ApplicationTypeID,
             ref byte ApplicationStatus,
             ref DateTime LastStatusDate,
             ref float PaidFees,
             ref int CreatedByUserID
            )
        {
            bool isFound = false;

            try
            {
                using(SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    string Query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

                    using(SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                        using(SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                //The record was found
                                isFound = true;

                                ApplicantPersonID = (int)Reader["ApplicantPersonID"];
                                ApplicationDate = (DateTime)Reader["ApplicationDate"];
                                ApplicationTypeID = (int)Reader["ApplicationTypeID"];
                                ApplicationStatus = (byte)Reader["ApplicationStatus"];
                                LastStatusDate = (DateTime)Reader["LastStatusDate"];
                                PaidFees = Convert.ToSingle(Reader["PaidFees"]);
                                CreatedByUserID = (int)Reader["CreatedByUserID"];
                            }
                            else
                            {
                                // The record was not found
                                isFound = false;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }

        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    string Query = "select * from ApplicationsList_View order by ApplicationDate desc";

                    using(SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        using(SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dt.Load(Reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return dt;
        }

        public static int AddNewApplication
            (
             int ApplicantPersonID,
             DateTime ApplicationDate,
             int ApplicationTypeID,
             byte ApplicationStatus,
             DateTime LastStatusDate,
             float PaidFees,
             int CreatedByUserID
            )
        {
            //this function will return the new person id if succeeded and -1 if not.
            int ApplicationID = -1;

            try
            {
                using(SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    string Query = @"INSERT INTO Applications (
                                ApplicantPersonID,ApplicationDate,ApplicationTypeID,
                                ApplicationStatus,LastStatusDate,
                                PaidFees,CreatedByUserID)
                                 VALUES (@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,
                                          @ApplicationStatus,@LastStatusDate,
                                          @PaidFees,   @CreatedByUserID);
                                 SELECT SCOPE_IDENTITY();";

                    using(SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("ApplicantPersonID", @ApplicantPersonID);
                        Command.Parameters.AddWithValue("ApplicationDate", @ApplicationDate);
                        Command.Parameters.AddWithValue("ApplicationTypeID", @ApplicationTypeID);
                        Command.Parameters.AddWithValue("ApplicationStatus", @ApplicationStatus);
                        Command.Parameters.AddWithValue("LastStatusDate", @LastStatusDate);
                        Command.Parameters.AddWithValue("PaidFees", @PaidFees);
                        Command.Parameters.AddWithValue("CreatedByUserID", @CreatedByUserID);

                        object Result = Command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            ApplicationID = InsertedID;
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            return ApplicationID;
        }

        public static bool UpdateApplication
            (
             int ApplicationID,
             int ApplicantPersonID,
             DateTime ApplicationDate,
             int ApplicationTypeID,
             byte ApplicationStatus,
             DateTime LastStatusDate,
             float PaidFees,
             int CreatedByUserID
            )
        {
            int RowsAffected = 0;

            try
            {
                using(SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    string Query = @"Update  Applications
                            set ApplicantPersonID = @ApplicantPersonID,
                                ApplicationDate = @ApplicationDate,
                                ApplicationTypeID = @ApplicationTypeID,
                                ApplicationStatus = @ApplicationStatus,
                                LastStatusDate = @LastStatusDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID=@CreatedByUserID
                            where ApplicationID=@ApplicationID";

                    using(SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                        Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                        Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                        Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                        Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                        Command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        RowsAffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            return (RowsAffected > 0);
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            int RowsAffected = 0;

            try
            {
                using(SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    string Query = @"Delete Applications
                                where ApplicationID = @ApplicationID";

                    using(SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                        RowsAffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return (RowsAffected > 0);
        }

        public static bool IsApplicationExist(int ApplicationID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found=1 FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                isFound = Reader.HasRows;

                Reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return isFound;
        }

        public static int GetActiveApplicationID(int PersonID, int ApplicationTypeID)
        {
            int ActiveApplicationTypeID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             SELECT ActiveApplicationID = ApplicationID
                             FROM Applications
                             WHERE ApplicantPersonID = @ApplicantPersonID
                              and ApplicationTypeID  = @ApplicationTypeID
                              and ApplicationStatus  = 1
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                    ActiveApplicationTypeID = InsertedID;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return ActiveApplicationTypeID;
            }
            finally
            {
                Connection.Close();
            }

            return ActiveApplicationTypeID;
        }

        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
        {
            //Incase the ActiveApplicationID != -1 return true.
            return (GetActiveApplicationID(PersonID, ApplicationTypeID) != -1);
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID, int LicenseClassID)
        {
            int ActiveApplicationID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             SELECT ActiveApplicationID=Applications.ApplicationID
                             From
                             Applications INNER JOIN
                             LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                             WHERE ApplicantPersonID = @ApplicantPersonID
                             and ApplicationTypeID=@ApplicationTypeID
							 and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                             and ApplicationStatus=1
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                    ActiveApplicationID = InsertedID;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return ActiveApplicationID;
            }
            finally
            {
                Connection.Close();
            }

            return ActiveApplicationID;
        }

        public static bool UpdateStatus(int ApplicationID, short NewStatus)
        {
            int RowsAffected = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             Update Applications
                             SET ApplicationStatus = @NewStatus,
                                 LastStatusDate = @LastStatusDate
                             WHERE ApplicationID =@ApplicationID;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@NewStatus", NewStatus);
            Command.Parameters.AddWithValue("LastStatusDate", DateTime.Now);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }

            return (RowsAffected > 0);
        }
    }
}