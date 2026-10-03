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

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetInvoiceInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InvoiceId", InvoiceId);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
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
                        }
                    }
                    catch (Exception ex)
                    {
                        // يُفضل تسجيل الخطأ ex بدلاً من إخفائه تماماً
                        isFound = false;
                    }
                }
            }

            return isFound;
        }

        public static int AddNewInvoice(byte Type, byte PaymentMethod, int AccountId,
            string Notes, decimal TotalAmount, int CreatedBy)
        {
            int InvoiceId = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewInvoice", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Type", Type);
                    command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                    command.Parameters.AddWithValue("@AccountId", AccountId);
                    command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
                    command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                    command.Parameters.AddWithValue("@CreatedBy", CreatedBy);

                    SqlParameter InvoiceID = new SqlParameter("@InvoiceId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(InvoiceID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        // checks if the output is not null neither DBNull,
                        // then casts it to int and assigns it to InvoiceId
                        if (InvoiceID.Value is int ID)
                            InvoiceId = ID;
                    }
                    catch (Exception) { }

                    return InvoiceId;
                }
            }
        }

        public static bool UpdateInvoice(int InvoiceId, byte Type, byte PaymentMethod, int AccountId, string Notes, decimal TotalAmount)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateInvoice", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

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
                }
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetAllInvoices()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAllInvoices", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) 
                                dt.Load(reader);
                        }
                    }
                    catch (Exception) { }
                }
            }

            return dt;
        }

        public static bool DeleteInvoice(int InvoiceId)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteInvoice", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InvoiceId", InvoiceId);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception) { return false; }
                }
            }

            return (rowsAffected > 0);
        }

        public static bool DoesInvoiceExist(int InvoiceId)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DoesInvoiceExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InvoiceId", InvoiceId);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                    catch (Exception) { isFound = false; }
                }
            }

            return isFound;
        }
    }
}
