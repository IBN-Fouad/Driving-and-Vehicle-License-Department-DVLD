using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLicenseClassData
    {
        public static bool GetLicenseClassInfoByID
            (
             int LicenseClassID,
             ref string ClassName,
             ref string ClassDescription,
             ref byte MinimumAllowedAge,
             ref byte DefaultValidityLength,
             ref float ClassFees
            )
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             SELECT * FROM LicenseClasses
                             WHERE LicenseClassID = @LicenseClassID;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    // The Record was found
                    isFound = true;

                    ClassName = (string)Reader["ClassName"];
                    ClassDescription = (string)Reader["ClassDescription"];
                    MinimumAllowedAge = (byte)Reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)Reader["DefaultValidityLength"];
                    ClassFees = Convert.ToSingle(Reader["ClassFees"]);
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

        public static bool GetLicenseClassInfoByClassName
            (
             string ClassName,
             ref int LicenseClassID,
             ref string ClassDescription,
             ref byte MinimumAllowedAge,
             ref byte DefaultValidityLength,
             ref float ClassFees
            )
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             SELECT * FROM LicenseClasses
                             WHERE ClassName = @ClassName;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    // The Record was found
                    isFound = true;

                    LicenseClassID = (int)Reader["LicenseClassID"];
                    ClassDescription = (string)Reader["ClassDescription"];
                    MinimumAllowedAge = (byte)Reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)Reader["DefaultValidityLength"];
                    ClassFees = Convert.ToSingle(Reader["ClassFees"]);
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

        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                             SELECT * FROM LicenseClasses
                             ORDER BY ClassName;
                            ";

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

        public static int AddNewLicenseClass
            (
             string ClassName,
             string ClassDescription,
             byte MinimumAllowedAge,
             byte DefaultValidityLength,
             float ClassFees
            )
            {
                int LicenseClassID = -1;
                SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string Query = @"
                             INSERT INTO LicenseClasses
                         		    (
                         		     ClassName,
                         		     ClassDescription,
                         		     MinimumAllowedAge,
                         		     DefaultValidityLength,
                         		     ClassFees
                         		    )
                             VALUES
                         		    (
                         		     @ClassName,
                         		     @ClassDescription,
                         		     @MinimumAllowedAge,
                         		     @DefaultValidityLength,
                         		     @ClassFees
                         		    )
                             WHERE LicenseClassID = @LicenseClassID;
                             SELECT SCOPE_IDENTITY();
                            ";

                SqlCommand Command = new SqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("@ClassName", ClassName);
                Command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
                Command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
                Command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
                Command.Parameters.AddWithValue("@ClassFees", ClassFees);

                try
                {
                    Connection.Open();
                    object Result = Command.ExecuteScalar();

                    if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                        LicenseClassID = InsertedID;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    Connection.Close();
                }

                return LicenseClassID;
            }

        public static bool UpdateLicenseClass
            (
             int LicenseClassID,
             string ClassName,
             string ClassDescription,
             byte MinimumAllowedAge,
             byte DefaultValidityLength,
             float ClassFees
            )
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"
                            UPDATE LicenseClasses
                            SET ClassName = @ClassName,
                            	ClassDescription = @ClassDescription,
                            	MinimumAllowedAge = @MinimumAllowedAge,
                            	DefaultValidityLength = @DefaultValidityLength,
                            	ClassFees = @ClassFees
                            WHERE LicenseClassID = @LicenseClassID;
                            ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue(@"LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue(@"ClassName", ClassName);
            Command.Parameters.AddWithValue(@"ClassDescription", ClassDescription);
            Command.Parameters.AddWithValue(@"MinimumAllowedAge", MinimumAllowedAge);
            Command.Parameters.AddWithValue(@"DefaultValidityLength", DefaultValidityLength);
            Command.Parameters.AddWithValue(@"ClassFees", ClassFees);

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