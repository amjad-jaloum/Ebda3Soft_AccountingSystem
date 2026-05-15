using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem_DataAccess
{
    public static class clsInvoiceDetailsData
    {
        public static bool GetInvoiceDetailInfoByID(int InvoiceDetailId, ref int InvoiceId,
            ref int ItemId, ref int Quantity, ref decimal UnitPrice, ref string UnitType)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM InvoiceDetails WHERE InvoiceDetailId = @InvoiceDetailId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InvoiceDetailId", InvoiceDetailId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    InvoiceId = (int)reader["InvoiceId"];
                    ItemId = (int)reader["ItemId"];
                    Quantity = (int)reader["Quantity"];
                    UnitPrice = (decimal)reader["UnitPrice"];
                    UnitType = (string)reader["UnitType"];
                }
                reader.Close();
            }
            catch (Exception) { isFound = false; }
            finally { connection.Close(); }

            return isFound;
        }

        public static int AddNewInvoiceDetail(int InvoiceId, int ItemId, int Quantity, decimal UnitPrice, string UnitType)
        {
            int InvoiceDetailId = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO InvoiceDetails (InvoiceId, ItemId, Quantity, UnitPrice, UnitType)
                         VALUES (@InvoiceId, @ItemId, @Quantity, @UnitPrice, @UnitType);
                         SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InvoiceId", InvoiceId);
            command.Parameters.AddWithValue("@ItemId", ItemId);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            command.Parameters.AddWithValue("@UnitType", UnitType);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    InvoiceDetailId = insertedID;
                }
            }
            catch (Exception) { }
            finally { connection.Close(); }

            return InvoiceDetailId;
        }

        public static bool UpdateInvoiceDetail(int InvoiceDetailId, int InvoiceId, int ItemId, int Quantity, decimal UnitPrice, string UnitType)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE InvoiceDetails  
                        SET InvoiceId = @InvoiceId,
                            ItemId = @ItemId,
                            Quantity = @Quantity,
                            UnitPrice = @UnitPrice,
                            UnitType = @UnitType
                        WHERE InvoiceDetailId = @InvoiceDetailId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InvoiceDetailId", InvoiceDetailId);
            command.Parameters.AddWithValue("@InvoiceId", InvoiceId);
            command.Parameters.AddWithValue("@ItemId", ItemId);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            command.Parameters.AddWithValue("@UnitType", UnitType);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception) { return false; }
            finally { connection.Close(); }

            return (rowsAffected > 0);
        }

        public static DataTable GetInvoiceDetailsByInvoiceID(int InvoiceId)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // جلب التفاصيل مع اسم الصنف وحساب الإجمالي لكل سطر
            string query = @"SELECT ID.InvoiceDetailId, 
                               ID.ItemId, 
                               I.Name, 
                               ID.Quantity, 
                               ID.UnitPrice, 
                               ID.UnitType,
                               (ID.Quantity * ID.UnitPrice) AS Total
                        FROM InvoiceDetails ID
                        INNER JOIN Items I ON ID.ItemId = I.ItemID
                        WHERE ID.InvoiceId = @InvoiceId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InvoiceId", InvoiceId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) dt.Load(reader);
                reader.Close();
            }
            catch (Exception) { }
            finally { connection.Close(); }

            return dt;
        }

        public static bool DeleteInvoiceDetail(int InvoiceDetailId)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM InvoiceDetails WHERE InvoiceDetailId = @InvoiceDetailId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InvoiceDetailId", InvoiceDetailId);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception) { return false; }
            finally { connection.Close(); }

            return (rowsAffected > 0);
        }

        public static bool DeleteAllInvoiceDetails(int InvoiceId)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM InvoiceDetails WHERE InvoiceId = @InvoiceId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InvoiceId", InvoiceId);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception) { return false; }
            finally { connection.Close(); }

            return (rowsAffected > 0);
        }
    }
}
