using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem_DataAccess
{
    public static class clsInvoiceData
    {
        public static bool GetInvoiceInfoByID(int InvoiceId, ref byte Type, ref DateTime CreatedDate,
            ref byte PaymentMethod, ref int AccountId, ref string Notes, ref decimal TotalAmount, ref int CreatedBy)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Invoices WHERE InvoiceId = @InvoiceId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InvoiceId", InvoiceId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    Type = (byte)reader["Type"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    PaymentMethod = (byte)reader["PaymentMethod"];
                    AccountId = (int)reader["AccountId"];
                    Notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : "";
                    TotalAmount = (decimal)reader["TotalAmount"];
                    CreatedBy = (int)reader["CreatedBy"];
                }
                reader.Close();
            }
            catch (Exception) { isFound = false; }
            finally { connection.Close(); }

            return isFound;
        }

        public static int AddNewInvoice(byte Type, byte PaymentMethod, int AccountId, string Notes, decimal TotalAmount, int CreatedBy)
        {
            int InvoiceId = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Invoices (Type, CreatedDate, PaymentMethod, AccountId, Notes, TotalAmount, CreatedBy)
                         VALUES (@Type, GETDATE(), @PaymentMethod, @AccountId, @Notes, @TotalAmount, @CreatedBy);
                         SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Type", Type);
            command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            command.Parameters.AddWithValue("@AccountId", AccountId);
            command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
            command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
            command.Parameters.AddWithValue("@CreatedBy", CreatedBy);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    InvoiceId = insertedID;
                }
            }
            catch (Exception) { }
            finally { connection.Close(); }

            return InvoiceId;
        }

        public static bool UpdateInvoice(int InvoiceId, byte Type, byte PaymentMethod, int AccountId, string Notes, decimal TotalAmount)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Invoices  
                        SET Type = @Type,
                            PaymentMethod = @PaymentMethod,
                            AccountId = @AccountId,
                            Notes = @Notes,
                            TotalAmount = @TotalAmount
                        WHERE InvoiceId = @InvoiceId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InvoiceId", InvoiceId);
            command.Parameters.AddWithValue("@Type", Type);
            command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            command.Parameters.AddWithValue("@AccountId", AccountId);
            command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
            command.Parameters.AddWithValue("@TotalAmount", TotalAmount);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception) { return false; }
            finally { connection.Close(); }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllInvoices()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // تم عمل Join مع Accounts لجلب اسم الحساب وعرضه في القائمة
            string query = @"SELECT Invoices.InvoiceId, 
                           Invoices.Type,
                           CASE 
                               WHEN Invoices.Type = 1 THEN 'Sales' 
                               WHEN Invoices.Type = 2 THEN 'Purchase' 
                               ELSE 'Unknown' 
                           END AS TypeName,
       
                           Invoices.CreatedDate, 
                           Invoices.PaymentMethod,
                           CASE 
                               WHEN Invoices.PaymentMethod = 1 THEN 'Cash' 
                               WHEN Invoices.PaymentMethod = 2 THEN 'Credit' 
                               ELSE 'Unknown' 
                           END AS PaymentMethodName,
       
                           Accounts.AccountName, 
                           Invoices.TotalAmount, 
                           Invoices.CreatedBy
                    FROM Invoices 
                    INNER JOIN Accounts ON Invoices.AccountId = Accounts.AccountId
                    ORDER BY Invoices.InvoiceId DESC";

            SqlCommand command = new SqlCommand(query, connection);

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

        public static bool DeleteInvoice(int InvoiceId)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM Invoices WHERE InvoiceId = @InvoiceId";

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

        public static bool DoesInvoiceExist(int InvoiceId)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Invoices WHERE InvoiceId = @InvoiceId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InvoiceId", InvoiceId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception) { isFound = false; }
            finally { connection.Close(); }

            return isFound;
        }
    }
}
