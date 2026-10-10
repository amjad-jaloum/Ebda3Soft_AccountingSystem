using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace AccountingSystem_DataAccess
{
    public class clsPersonData
    {

        public static bool GetPersonInfoByID(int PersonID, ref string FirstName,
            ref string SecondName, ref string ThirdName, ref string LastName, 
            ref short Gender, ref string Phone, ref string Email)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetPersonInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                FirstName = reader["FirstName"] != DBNull.Value ? (string)reader["FirstName"] : string.Empty;
                                SecondName = reader["SecondName"] != DBNull.Value ? (string)reader["SecondName"] : string.Empty;
                                ThirdName = reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : string.Empty;
                                LastName = reader["LastName"] != DBNull.Value ? (string)reader["LastName"] : string.Empty;
                                Gender = reader["Gender"] != DBNull.Value ? Convert.ToInt16(reader["Gender"]) : (short)0;
                                Phone = reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : string.Empty;
                                Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : string.Empty;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException(ex);
                        isFound = false;
                    }
                }
            }

            return isFound;
        }


        public static int AddNewPerson(string FirstName, string SecondName,
            string ThirdName, string LastName, short Gender, string Phone, string Email)
        {
            int PersonID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", string.IsNullOrEmpty(ThirdName) ? DBNull.Value : (object)ThirdName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(Email) ? DBNull.Value : (object)Email);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PersonID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException(ex);
                    }
                }
            }

            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string FirstName, string SecondName,
            string ThirdName, string LastName, short Gender, string Phone, string Email)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdatePerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", string.IsNullOrEmpty(ThirdName) ? DBNull.Value : (object)ThirdName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(Email) ? DBNull.Value : (object)Email);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException(ex);
                    }
                }
            }

            return (rowsAffected > 0);
        }


        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllPeople", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException(ex);
                    }
                }
            }

            return dt;
        }

        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeletePerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException(ex);
                    }
                }
            }

            return (rowsAffected > 0);
        }

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_IsPersonExistByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            isFound = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException(ex);
                    }
                }
            }

            return isFound;
        }


    }
}
