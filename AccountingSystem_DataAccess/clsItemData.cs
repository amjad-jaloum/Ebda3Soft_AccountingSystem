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

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Items WHERE ItemId = @ItemId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemId", ItemId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Name = (string)reader["Name"];
                    DefaultUnitPrice = (decimal)reader["DefaultUnitPrice"];

                    // التعامل مع UnitTypeId في حال كان يقبل Null (رغم أنه في السكيما FK)
                    if (reader["UnitTypeId"] != DBNull.Value)
                    {
                        UnitTypeId = (int)reader["UnitTypeId"];
                    }
                    else
                    {
                        UnitTypeId = -1;
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

        public static int AddNewItem(string Name, int UnitTypeId, decimal DefaultUnitPrice)
        {
            int ItemId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // تم تحديث الاستعلام ليتناسب مع أسماء الحقول في السكيما الجديدة
            string query = @"INSERT INTO Items (Name, UnitTypeId, DefaultUnitPrice)
                             VALUES (@Name, @UnitTypeId, @DefaultUnitPrice);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@DefaultUnitPrice", DefaultUnitPrice);

            if (UnitTypeId != -1)
                command.Parameters.AddWithValue("@UnitTypeId", UnitTypeId);
            else
                command.Parameters.AddWithValue("@UnitTypeId", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ItemId = insertedID;
                }
            }
            catch (Exception ex)
            {
                // Handling Error
            }
            finally
            {
                connection.Close();
            }

            return ItemId;
        }

        public static bool UpdateItem(int ItemId, string Name, int UnitTypeId, decimal DefaultUnitPrice)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Items  
                            SET Name = @Name, 
                                UnitTypeId = @UnitTypeId, 
                                DefaultUnitPrice = @DefaultUnitPrice
                            WHERE ItemId = @ItemId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemId", ItemId);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@DefaultUnitPrice", DefaultUnitPrice);

            if (UnitTypeId != -1)
                command.Parameters.AddWithValue("@UnitTypeId", UnitTypeId);
            else
                command.Parameters.AddWithValue("@UnitTypeId", System.DBNull.Value);

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

            // استخدام JOIN لجلب اسم الوحدة بدلاً من الرقم فقط للعرض في الـ DataGridView
            string query = @"SELECT Items.ItemId, Items.Name, UnitTypes.Name AS UnitName, Items.DefaultUnitPrice 
                             FROM Items 
                             LEFT JOIN UnitTypes ON Items.UnitTypeId = UnitTypes.UnitTypeId
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
                // Handling Error
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool DeleteItem(int ItemId)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Items WHERE ItemId = @ItemId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemId", ItemId);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handling Error
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DoesItemExist(string Name)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // نستخدم LIKE أو = حسب رغبتك في حساسية البحث، هنا استخدمنا المطابقة التامة
            string query = "SELECT Found=1 FROM Items WHERE Name = @Name";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // إذا كان هناك صفوف، فهذا يعني أن الصنف موجود
                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handling Error
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int GetItemIDByName(string Name)
        {
            int ItemId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP 1 ItemId FROM Items WHERE Name like @Name";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name + "%");
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int foundId))
                {
                    ItemId = foundId;
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                ItemId = -1;
            }
            finally
            {
                connection.Close();
            }

            return ItemId;
        }

        public static DataTable GetItemsInventory()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM View_ItemsInventory ORDER BY ItemName";
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
                // Handling Error
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
    }
}