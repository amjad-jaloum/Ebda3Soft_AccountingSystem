using System;
using System.Data;
using System.Data.SqlClient;
using AccountingSystem_DataAccess;

namespace Ebda3Soft_DataAccess
{
    public static class clsItemData
    {
        public static bool GetItemInfoByID(int ItemID, ref string Name, ref int UnitTypeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Items WHERE ItemID = @ItemID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemID", ItemID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    Name = (string)reader["Name"];
                    UnitTypeID = (int)reader["UnitTypeID"];
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

        public static int AddNewItem(string Name, int UnitTypeID)
        {
            // This function returns the new ID if successful, and -1 if not
            int ItemID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Items (Name, UnitTypeID)
                             VALUES (@Name, @UnitTypeID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@UnitTypeID", UnitTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ItemID = insertedID;
                }
            }
            catch (Exception ex)
            {
                // Log error if necessary
            }
            finally
            {
                connection.Close();
            }

            return ItemID;
        }

        public static bool UpdateItem(int ItemID, string Name, int UnitTypeID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Items  
                            SET Name = @Name,
                                UnitTypeID = @UnitTypeID
                            WHERE ItemID = @ItemID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemID", ItemID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@UnitTypeID", UnitTypeID);

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

        public static DataTable GetAllItems()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // Using Join to get the Unit Name for display in DataGridView
            string query = @"SELECT Items.ItemID, Items.Name AS ItemName, 
                             UnitTypes.Name AS UnitName
                             FROM Items 
                             INNER JOIN UnitTypes ON Items.UnitTypeID = UnitTypes.UnitTypeID
                             ORDER BY Items.Name";

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
                // Handle error
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool DeleteItem(int ItemID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM Items WHERE ItemID = @ItemID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", ItemID);

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

        public static bool DoesItemExist(string ItemName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // Using a query that checks for the name
            string query = "SELECT Found=1 FROM Items WHERE Name = @Name";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", ItemName.Trim());

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // If the reader has at least one row, the item exists
                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                // For debugging, you could log the error: ex.Message
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