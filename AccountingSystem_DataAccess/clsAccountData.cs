using System;
using System.Data;
using System.Data.SqlClient;
using AccountingSystem_DataAccess;

namespace Ebda3Soft_DataAccess
{
    public static class clsAccountData
    {
        public static bool GetAccountInfoByID(int AccountID, ref string Name,
            ref int PersonID, ref byte Type)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Accounts WHERE AccountID = @AccountID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Name = (string)reader["Name"];
                    Type = (byte)reader["Type"];

                    // PersonID: handling potential nulls if the relationship is optional
                    if (reader["PersonID"] != DBNull.Value)
                    {
                        PersonID = (int)reader["PersonID"];
                    }
                    else
                    {
                        PersonID = -1; // Or any default value you prefer
                    }
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewAccount(string Name, int PersonID, byte Type)
        {
            int AccountID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Accounts (Name, PersonID, Type)
                             VALUES (@Name, @PersonID, @Type);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Type", Type);

            // Handle optional PersonID
            if (PersonID != -1)
                command.Parameters.AddWithValue("@PersonID", PersonID);
            else
                command.Parameters.AddWithValue("@PersonID", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AccountID = insertedID;
                }
            }
            catch (Exception ex)
            {
                // Error log here if needed
            }
            finally
            {
                connection.Close();
            }

            return AccountID;
        }

        public static bool UpdateAccount(int AccountID, string Name, int PersonID, byte Type)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Accounts  
                             SET Name = @Name,
                                 PersonID = @PersonID,
                                 Type = @Type
                             WHERE AccountID = @AccountID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountID", AccountID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Type", Type);

            if (PersonID != -1)
                command.Parameters.AddWithValue("@PersonID", PersonID);
            else
                command.Parameters.AddWithValue("@PersonID", System.DBNull.Value);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteAccount(int AccountID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM Accounts WHERE AccountID = @AccountID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllAccounts()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // Using Inner Join to get Person Names if needed, or simple select
            string query = @"SELECT Accounts.AccountID, Accounts.Name, 
                             ISNULL(People.FirstName + ' ' + People.LastName, 'N/A') as FullName,
                             Accounts.Type
                             FROM Accounts 
                             LEFT JOIN People ON Accounts.PersonID = People.PersonID
                             ORDER BY Accounts.Name";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Error handling
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool IsAccountExist(int AccountID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Accounts WHERE AccountID = @AccountID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}