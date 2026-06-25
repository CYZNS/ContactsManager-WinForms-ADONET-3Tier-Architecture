using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace ContactsDataAccessLayer
{
    public class ContactsdataAccessLayer
    {
        // contact Methods
        public static bool findContactByID(int id, ref string FirstName, ref string LastName, ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth, ref string ImagePath, ref int CountryID)
        {
            bool isFound = false;
            string query = "select * from Contacts where ContactID = @contactID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("contactID", id);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            isFound = true;
                            FirstName = reader["FirstName"] as string ?? "";
                            LastName = reader["LastName"] as string ?? "";
                            Email = reader["Email"] as string ?? "";
                            Phone = reader["Phone"] as string ?? "";
                            Address = reader["Address"] as string ?? "";
                            DateOfBirth = (DateTime)reader["DateOfBirth"];
                            ImagePath = reader["ImagePath"] as string ?? "";


                            int.TryParse(reader["CountryID"].ToString(), out CountryID);

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

        public static int addNewContact(string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, string ImagePath, int CountryID)
        {
            int contactId = -1;
            string query = @"INSERT INTO Contacts (FirstName,LastName ,Email,Phone ,Address ,DateOfBirth ,CountryID,ImagePath)
                            values (@FirstName,@LastName ,@Email,@Phone ,@Address ,@DateOfBirth,@CountryID,@ImagePath);
                             select SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("FirstName", FirstName);
                command.Parameters.AddWithValue("LastName", LastName);
                command.Parameters.AddWithValue("Email", Email);
                command.Parameters.AddWithValue("Phone", Phone);
                command.Parameters.AddWithValue("Address", Address);
                command.Parameters.AddWithValue("DateOfBirth", DateOfBirth);
                if (ImagePath != "")
                {
                    command.Parameters.AddWithValue("ImagePath", ImagePath);
                }
                else
                {
                    command.Parameters.AddWithValue("ImagePath", DBNull.Value);

                }
                command.Parameters.AddWithValue("CountryID", CountryID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        contactId = insertedID;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error Database: " + e.Message);
                }
            }
            return contactId;

        }

        public static bool updateContact(int ID, string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, string ImagePath, int CountryID)
        {
            int rowsAffected = 0;
            string query = @"Update  Contacts 
                     set FirstName = @FirstName,
                         LastName = @LastName,
                         Email = @Email,
                         Phone = @Phone,
                         Address = @Address,
                         DateOfBirth = @DateOfBirth,
                         CountryID = @CountryID,
                         ImagePath =@ImagePath
                     where ContactID = @ContactID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("ContactID", ID);
                command.Parameters.AddWithValue("FirstName", FirstName);
                command.Parameters.AddWithValue("LastName", LastName);
                command.Parameters.AddWithValue("Email", Email);
                command.Parameters.AddWithValue("Phone", Phone);
                command.Parameters.AddWithValue("Address", Address);
                command.Parameters.AddWithValue("DateOfBirth", DateOfBirth);
                if (ImagePath != "")
                {
                    command.Parameters.AddWithValue("ImagePath", ImagePath);
                }
                else
                {
                    command.Parameters.AddWithValue("ImagePath", DBNull.Value);

                }
                command.Parameters.AddWithValue("CountryID", CountryID);

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

        public static bool deleteContact(int ID)
        {
            int rows = 0;
            string query = @"delete Contacts where ContactID = @contactID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("contactID", ID);

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

        //my solution
        //public static bool isExist(int ID)
        //{
        //    int id = -1;
        //    string query = "select ContactID from Contacts where ContactID= @contactID;";
        //    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    {
        //        command.Parameters.AddWithValue("contactID", ID);

        //        try
        //        {
        //            connection.Open();
        //            object result = command.ExecuteScalar();

        //            if(result != null && int.TryParse(result.ToString(),out int FoundID))
        //            {
        //                id = FoundID;
        //            }
        //        }
        //        catch(Exception ex)
        //        {
        //            Console.WriteLine("Error"+ex.Message);
        //        }
        //    }
        //    return id != -1;
        //}

        public static bool isContactExist(int ID)
        //best solution
        {
            bool isFound = false;

            // 1. The most optimized query. Just ask SQL to return a '1' if it finds a match.
            string query = "SELECT 1 FROM Contacts WHERE ContactID = @ContactID;";

            // 2. Clean resource management. 
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("ContactID", ID);

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

        public static DataTable listContacts()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM Contacts";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using(SqlCommand command = new SqlCommand(query,connection))
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
                    Console.WriteLine("Error"+ex.Message);
                }

            }
            return dt;
        }

        public static DataTable getContactsByCountryID(int CountryID)
        {
            DataTable dt = new DataTable();

            string query = "select * from Contacts where CountryID = @countryID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@countryID", CountryID);

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
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return dt;
        }

    }
}
