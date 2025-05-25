using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDetainedLicenseData
    {
        public static bool GetDetainedLicenseInfoByID
            (
             int DetainID,
             ref int LicenseID,
             ref DateTime DetainDate,
             ref float FineFees,
             ref int CreatedByUserID,
             ref bool IsReleased,
             ref DateTime ReleaseDate,
             ref int ReleasedByUserID,
             ref int ReleasedApplicationID
            )
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM DetainedLicense WHERE DetainID = @DetainID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    //The record was found
                    isFound = true;

                    LicenseID = (int)Reader["LicenseID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = Convert.ToSingle(Reader["FineFees"]);
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];

                    /*if (Reader["ReleaseDate"] == DBNull.Value)
                        ReleaseDate = DateTime.MaxValue;
                    else
                        ReleaseDate = (DateTime)Reader["ReleaseDate"];*/
                    ReleaseDate = (Reader["ReleaseDate"] == DBNull.Value) ? DateTime.MaxValue : (DateTime)Reader["ReleaseDate"];


                    if (Reader["ReleasedByUserID"] == DBNull.Value)
                        ReleasedByUserID = -1;
                    else
                        ReleasedByUserID = (int)Reader["ReleasedByUserID"];

                    if (Reader["ReleasedApplicationID"] == DBNull.Value)
                        ReleasedApplicationID = -1;
                    else
                        ReleasedApplicationID = (int)Reader["ReleasedApplicationID"];
                }
                else
                    //The Record was not found
                    isFound = false;

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

        public static bool GetDetainedLicenseInfoByLicenseID
            (
             int LicenseID,
             ref int DetainID,
             ref DateTime DetainDate,
             ref float FineFees,
             ref int CreatedByUserID,
             ref bool IsReleased,
             ref DateTime ReleaseDate,
             ref int ReleasedByUserID,
             ref int ReleasedApplicationID
            )
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM DetainedLicense WHERE LicenseID = @LicenseID ORDER BY DetainID DESC";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    //The record was found
                    isFound = true;

                    DetainID = (int)Reader["DetainID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = Convert.ToSingle(Reader["FineFees"]);
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];

                    if (Reader["ReleaseDate"] == DBNull.Value)
                        ReleaseDate = DateTime.MaxValue;
                    else
                        ReleaseDate = (DateTime)Reader["ReleaseDate"];

                    if (Reader["ReleasedByUserID"] == DBNull.Value)
                        ReleasedByUserID = -1;
                    else
                        ReleasedByUserID = (int)Reader["ReleasedByUserID"];

                    if (Reader["ReleasedApplicationID"] == DBNull.Value)
                        ReleasedApplicationID = -1;
                    else
                        ReleasedApplicationID = (int)Reader["ReleasedApplicationID"];
                }
                else
                    //The Record was not found
                    isFound = false;

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

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select * from detainedLicenses_View order by IsReleased, DetainID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    dt.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return dt;
        }

        public static int AddNewDetainedLicense
            (
             int LicenseID,
             DateTime DetainDate,
             float FineFees,
             int CreatedByUserID
            )
        {
            int DetainID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"
                             INSERT INTO DetainedLicenses
                             	(
                             	 LicenseID,
                             	 DetainDate,
                             	 FineFees,
                             	 CreatedByUserID,
                             	 IsReleased
                             	)
                             VALUES
                             	(
                             	 @LicenseID,
                             	 @DetainDate,
                             	 @FineFees,
                             	 @CreatedByUserID,
                             	 0
                             	);
                             SELECT SCOPE_IDENTITY();
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                    LicenseID = InsertedID;
            }
            catch
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return DetainID;
        }

        public static bool UpdateDetainedLicense
            (
             int DetainID,
             int LicenseID,
             DateTime DetainDate,
             float FineFees,
             int CreatedByUserID
            )
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             UPDATE DetainedLicenses
                             SET
                               LicenseID = @LicenseID,
                               DetainDate = @DetainDate,
                               FineFees = @FineFees,
                               CreatedByUserID = @CreatedByUserID
                             WHERE DetainID = @DetainID;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@DetainID", DetainID);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                /*Console.WriteLine("Error: " + ex.Message);*/
                return false;
            }
            finally
            {
                Connection.Close();
            }

            return (RowsAffected > 0);
        }

        public static bool ReleaseDetainedLicense
            (
             int DetainID,
             int ReleasedByUserID,
             int ReleaseApplicationID
            )
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             UPDATE DetainedLicenses
                             SET
                               IsReleased = 1,
                               ReleaseDate = @ReleaseDate,
                               ReleasedByUserID = @ReleasedByUserID,
                               ReleaseApplicationID = @ReleaseApplicationID
                             WHERE DetainID = @DetainID;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@DetainID", DetainID);
            Command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);
            Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool isDetained = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"
                             SELECT IsDetained = 1
                             FROM DetainedLicenses
                             WHERE
                             	LicenseID = @LicenseID
                               AND
                             	IsReleased = 0;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                    isDetained = Convert.ToBoolean(Result);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return isDetained;
        }
    }
}