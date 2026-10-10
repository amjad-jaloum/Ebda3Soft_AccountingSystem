using System;
using System.Data;
using System.Data.SqlClient;
using AccountingSystem_DataAccess;

namespace Ebda3Soft_AccountingSystem_DataAccess
{
    public class clsItemData
    {
        public static bool GetItemInfoByID(int ItemId, ref string Name,
            ref int UnitTypeId, ref decimal DefaultUnitPrice)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetItemInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ItemId", ItemId);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                Name = reader["Name"] != DBNull.Value ? (string)reader["Name"] : string.Empty;
                                DefaultUnitPrice = reader["DefaultUnitPrice"] != DBNull.Value ? (decimal)reader["DefaultUnitPrice"] : 0m;

                                UnitTypeId = reader["UnitTypeId"] != DBNull.Value ? (int)reader["UnitTypeId"] : -1;
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
        public static int AddNewItem(string Name, int UnitTypeId, decimal DefaultUnitPrice)
        {
            int itemId = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewItem", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Name", string.IsNullOrEmpty(Name) ? DBNull.Value : (object)Name);
                    command.Parameters.AddWithValue("@UnitTypeId", UnitTypeId != -1 ? (object)UnitTypeId : DBNull.Value);
                    command.Parameters.AddWithValue("@DefaultUnitPrice", DefaultUnitPrice);

                    SqlParameter outputItemId = new SqlParameter("@ItemId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputItemId);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (outputItemId.Value is int insertedId)
                        {
                            itemId = insertedId;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException(ex);
                        itemId = -1;
                    }
                }
            }

            return itemId;
        }

        public static bool UpdateItem(int ItemId, string Name, int UnitTypeId, decimal DefaultUnitPrice)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateItem", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ItemId", ItemId);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@UnitTypeId", UnitTypeId);
                    command.Parameters.AddWithValue("@DefaultUnitPrice", DefaultUnitPrice);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException(ex);
                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllItems()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllItems", connection))
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

        public static bool DeleteItem(int ItemId)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteItem", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ItemId", ItemId);

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

        public static bool DoesItemExist(string Name)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DoesItemExistByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", string.IsNullOrEmpty(Name) ? DBNull.Value : (object)Name);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
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

        public static int GetItemIDByName(string Name)
        {
            int itemId = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetItemIDByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", Name);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int foundId))
                        {
                            itemId = foundId;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException(ex);
                        itemId = -1;
                    }
                }
            }

            return itemId;
        }

        public static DataTable GetItemsInventory()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetItemsInventory", connection))
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
    }
}