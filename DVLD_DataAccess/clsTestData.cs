using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.Directives;

namespace DVLD_DataAccess
{
    public class clsTestData
    {
        public static bool GetTestInfoByID
            (
             int TestID,
             ref int TestAppointmentID,
             ref bool TestResult,
             ref string Notes,
             ref int CreatedByUserID
            )
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             SELECT * FROM Tests
                             WHERE TestID = @TestID;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    // The record was found
                    isFound = true;

                    TestAppointmentID = (int)Reader["TestAppointmentID"];
                    TestResult = (bool)Reader["TestResult"];

                    if (Reader["Notes"] == DBNull.Value)
                        Notes = "";
                    else
                        Notes = (string)Reader["Notes"];

                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                }
                else
                    isFound = false;
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

        public static bool GetLastTestByPersonAndTestTypeAndLicenseClass
            (
             int PersonID,
             int LicenseClassID,
             int TestTypeID,
             ref int TestID,
             ref int TestAppointmentID,
             ref bool TestResult,
             ref string Notes,
             ref int CreatedByUserID
            )
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                            SELECT TOP 1 
                            		Tests.TestID,
                            		Tests.TestAppointmentID,
                            		Tests.TestResult,
                            		Tests.Notes,
                            		Tests.CreatedByUserID,
                            		Applications.ApplicantPersonID
                            FROM    LocalDrivingLicenseApplications
                            INNER JOIN Tests
                            INNER JOIN TestAppointments
                            ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                            ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
                            INNER JOIN Applications
                            ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                            WHERE 
                            		(Applications.ApplicantPersonID = @PersonID)
                            AND 
                            		(LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID)
                            AND 
                            		(TestAppointments.TestTypeID= @TestTypeID)
                            ORDER BY Tests.TestAppointmentID DESC
                           ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    // The record was found
                    isFound = true;

                    TestID = (int)Reader["TestID"];
                    TestAppointmentID = (int)Reader["TestAppointmentID"];
                    TestResult = (bool)Reader["TestResult"];

                    if (Reader["Notes"] == DBNull.Value)
                        Notes = "";
                    else
                        Notes = (string)Reader["Notes"];

                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                }
                else
                    // The record was not found
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

        public static DataTable GetAllTests()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             SELECT * FROM Tests
                             ORDER BY TestID;
                            ";

            SqlCommand command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return dt;
        }

        public static int AddNewTest
            (
             int TestAppointmentID,
             bool TestResult,
             string Notes,
             int CreatedByUserID
            )
        {
            int TestID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             INSERT INTO Tests
                             		(
                             		 TestAppointmentID,
                             		 TestResult,
                             		 Notes,
                             		 CreatedByUserID
                             		)
                             VALUES
                             		(
                             		 @TestAppointmentID,
                             		 @TestResult,
                             		 @Notes,
                             		 @CreatedByUserID
                             		);
                             
                             UPDATE TestAppointments
                             SET    IsLocked = 1
                             WHERE  TestAppointmentID = @TestAppointmentID;
                             
                             SELECT SCOPE_IDENTITY();
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);

            if(Notes != "" && Notes != null)
                Command.Parameters.AddWithValue("@Notes", Notes);
            else
                Command.Parameters.AddWithValue("@Notes", System.DBNull.Value);

            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if(Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                    TestID = InsertedID;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return TestID;
        }

        public static bool UpdateTest
            (
             int TestID,
             int TestAppointmentID,
             bool TestResult,
             string Notes,
             int CreatedByUserID
            )
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             UPDATE Tests
                             SET    TestAppointmentID = @TestAppointmentID,
                             	    TestResult = @TestResult,
                             	    Notes = @Notes,
                             	    CreatedByUserID = @CreatedByUserID
                             WHERE  TestID = @TestID;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestID", TestID);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            byte PassedTestCount = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             SELECT PassedTestCount = COUNT(TestTypeID)
                             FROM Tests
                             INNER JOIN TestAppointments
                             ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                             	AND
                             	  TestResult = 1;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && byte.TryParse(Result.ToString(), out byte ptCount))
                    PassedTestCount = ptCount;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return PassedTestCount;
        }
    }
}