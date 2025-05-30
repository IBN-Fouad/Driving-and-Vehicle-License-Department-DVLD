﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDevHtmlRenderer.Core.Entities;

namespace DVLD_DataAccess
{
    public class clsTestAppointmentData
    {
        public static bool GetTestAppointmentInfoByID
            (
             int TestAppointmentID,
             ref int TestTypeID,
             ref int LocalDrivingLicenseApplicationID,
             ref DateTime AppointmentDate,
             ref float PaidFees,
             ref int CreatedByUserID,
             ref bool IsLocked,
             ref int RetakeTestApplicationID
            )
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             SELECT * FROM TestAppointments
                             WHERE TestAppointmentID = @TestAppointmentID;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    //The record was found
                    isFound = true;

                    TestTypeID = (int)Reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = Convert.ToSingle(Reader["PaidFees"]);
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsLocked = (bool)Reader["IsLocked"];

                    if (Reader["RetakeTestApplicationID"] == DBNull.Value)
                        RetakeTestApplicationID = -1;
                    else
                        RetakeTestApplicationID = (int)Reader["RetakeTestApplicationID"];
                }
                else
                    // The record was not found
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

        public static bool GetLastTestAppointment
            (
             int TestTypeID,
             int LocalDrivingLicenseApplicationID,
             ref int TestAppointmentID,
             ref DateTime AppointmentDate,
             ref float PaidFees,
             ref int CreatedByUserID,
             ref bool IsLocked,
             ref int RetakeTestApplicationID
            )
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             SELECT TOP 1 *
                             FROM TestAppointments
                             WHERE (TestTypeID = @TestTypeID)
                               AND (LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)
                             ORDER BY TestAppointmentID DESC;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    //The record was found
                    isFound = true;

                    TestAppointmentID = (int)Reader["TestAppointmentID"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = (float)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsLocked = (bool)Reader["IsLocked"];

                    if (Reader["RetakeTestApplicationID"] == DBNull.Value)
                        RetakeTestApplicationID = -1;
                    else
                        RetakeTestApplicationID = (int)Reader["RetakeTestApplicationID"];
                }
                else
                    // The record was not found
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

        public static DataTable GetAllTestAppointments()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM TestAppointments_View ORDER BY AppointmentDate DESC;";

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
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return dt;
        }

        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             SELECT 
                             	TestAppointmentID,
                             	AppointmentDate,
                             	PaidFees,
                             	IsLocked
                             FROM TestAppointments
                             WHERE 
                             	(TestTypeID = @TestTypeID)
                              AND
                             	(LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)
                             ORDER BY TestAppointmentID DESC;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return dt;
        }

        public static int AddNewTestAppointment
            (
             int TestTypeID,
             int LocalDrivingLicenseApplicationID,
             DateTime AppointmentDate,
             float PaidFees,
             int CreatedByUserID,
             int RetakeTestApplicationID
            )
        {
            int TestAppointmentID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             INSERT INTO TestAppointments
                             		    (
                             		     TestTypeID,
                             		     LocalDrivingLicenseApplicationID,
                             		     AppointmentDate,
                             		     PaidFees,
                             		     CreatedByUserID,
                             		     IsLocked,
                             		     RetakeTestApplicationID
                             		    )
                             VALUES
                             		    (
                             		     @TestTypeID,
                             		     @LocalDrivingLicenseApplicationID,
                             		     @AppointmentDate,
                             		     @PaidFees,
                             		     @CreatedByUserID,
                             		     0,
                             		     @RetakeTestApplicationID
                             		    );
                             SELECT SCOPE_IDENTITY();
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if(RetakeTestApplicationID == -1)
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                    TestAppointmentID = InsertedID;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return TestAppointmentID;
        }

        public static bool UpdateTestAppointment
            (
             int TestAppointmentID,
             int TestTypeID,
             int LocalDrivingLicenseApplicationID,
             DateTime AppointmentDate,
             float PaidFees,
             int CreatedByUserID,
             bool IsLocked,
             int RetakeTestApplicationID
            )
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             UPDATE TestAppointments
                             SET
                             	 TestTypeID = @TestTypeID,
                             	 LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                             	 AppointmentDate = @AppointmentDate,
                             	 PaidFees = @PaidFees,
                             	 CreatedByUserID = @CreatedByUserID,
                             	 IsLocked = @IsLocked,
                             	 RetakeTestApplicationID = @RetakeTestApplicationID
                             WHERE TestAppointmentID = @TestAppointmentID;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestApplicationID == -1)
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

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

        public static int GetTestID(int TestAppointmentID)
        {
            int TestID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TestID FROM Tests
                             WHERE TestAppointmentID = @TestAppointmentID;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
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
    }
}