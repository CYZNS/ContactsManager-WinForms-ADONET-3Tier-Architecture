using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsDataAccessLayer
{
    public class CountrydataAccessLayer
    {
        public static bool findCountryByID(int id, ref string CountryName, ref string Code , ref string PhoneCode)
        {
            bool isFound = false;
            string query = "select * from Countries where CountryID = @countryID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@countryID", id);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            isFound = true;
                            CountryName = reader["CountryName"] as string ?? "";
                            Code = reader["Code"] as string ?? "";
                            PhoneCode = reader["PhoneCode"] as string ?? "";

                        }
                        else
                        {
                            isFound = false;
                        }


                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("DataBase Error: " + e.Message);
                    isFound = false;
                }

            }
            return isFound;


        }
        public static bool findCountryByName(string CountryName, ref int ID , ref string Code , ref string PhoneCode)
        {
            bool isFound = false;
            string query = "select * from Countries where CountryName = @countryName;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@countryName", CountryName);
                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // The record was found
                            isFound = true;

                            ID = (int)reader["CountryID"];
                            Code = reader["Code"] as string ?? "";
                            PhoneCode = reader["PhoneCode"] as string ?? "";
                        }
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("DataBase Error: " + e.Message);
                }

            }
            return isFound;

        }
        public static int addNewCountry(string CountryName,string Code,string PhoneCode)
        {
            int countryID = -1;
            string query = @"INSERT INTO Countries (CountryName,Code,PhoneCode)
                            values (@countryName,@code,@phoneCode);
                             select SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if(CountryName!="")
                    command.Parameters.AddWithValue("@countryName", CountryName);
                else
                    command.Parameters.AddWithValue("@countryName", DBNull.Value);

                if(Code!="")
                command.Parameters.AddWithValue("@code", Code);
                else
                    command.Parameters.AddWithValue("@code", DBNull.Value);

                if(PhoneCode!="")
                command.Parameters.AddWithValue("@phoneCode", PhoneCode);
                else
                    command.Parameters.AddWithValue("@phoneCode", DBNull.Value);


                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        countryID = insertedID;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error Database: " + e.Message);
                }
            }
            return countryID;

        }
        public static bool updateCountry(int CountryID, string CountryName,string Code,string PhoneCode)
        {
            int rowsAffected = 0;
            string query = @"Update  Countries 
                     set CountryName = @countryName ,Code = @code,PhoneCode = @phoneCode
                     where CountryID = @countryID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (CountryName != "")
                    command.Parameters.AddWithValue("@countryName", CountryName);
                else
                    command.Parameters.AddWithValue("@countryName", DBNull.Value);

                if (Code != "")
                    command.Parameters.AddWithValue("@code", Code);
                else
                    command.Parameters.AddWithValue("@code", DBNull.Value);

                if (PhoneCode != "")
                    command.Parameters.AddWithValue("@PhoneCode", PhoneCode);
                else
                    command.Parameters.AddWithValue("@PhoneCode", DBNull.Value);

                command.Parameters.AddWithValue("@countryID", CountryID);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return rowsAffected > 0;

        }
        public static bool deleteCountry(int countryID)
        {
            int rows = 0;
            string query = @"delete Countries where CountryID = @countryID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("countryID", countryID);

                try
                {
                    connection.Open();
                    rows = command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return rows > 0;
        }
        public static DataTable listCountries()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM Countries order by CountryName";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);
                }

            }
            return dt;
        }
        public static bool isCountryExist(int CountryID)
        //best solution
        {
            bool isFound = false;

            // 1. The most optimized query. Just ask SQL to return a '1' if it finds a match.
            string query = "SELECT 1 FROM Countries WHERE CountryID = @countryID;";

            // 2. Clean resource management. 
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@countryID", CountryID);

                try
                {
                    connection.Open();

                    // 3. The lightest way to get a single value
                    object result = command.ExecuteScalar();

                    // 4. If result is not null, the record exists! 
                    // We don't need to parse it, we just care that it isn't empty.
                    if (result != null)
                    {
                        isFound = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // In a real app, you might want to log this to a file instead of the console
                }
            }

            return isFound;
        }
        public static bool isCountryExist(string CountryName)
        //best solution
        {
            bool isFound = false;

            // 1. The most optimized query. Just ask SQL to return a '1' if it finds a match.
            string query = "SELECT 1 FROM Countries WHERE CountryName = @countryName;";

            // 2. Clean resource management. 
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@countryName", CountryName);

                try
                {
                    connection.Open();

                    // 3. The lightest way to get a single value
                    object result = command.ExecuteScalar();

                    // 4. If result is not null, the record exists! 
                    // We don't need to parse it, we just care that it isn't empty.
                    if (result != null)
                    {
                        isFound = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // In a real app, you might want to log this to a file instead of the console
                }
            }

            return isFound;
        }

       
    }
}
