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
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetInvoiceDetailInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InvoiceDetailId", InvoiceDetailId);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                InvoiceId = (int)reader["InvoiceId"];
                                ItemId = (int)reader["ItemId"];
                                Quantity = (int)reader["Quantity"];
                                UnitPrice = (decimal)reader["UnitPrice"];
                                UnitType = (string)reader["UnitType"];
                            }
                        }
                    }
                    catch (Exception)
                    {
                        isFound = false;
                    }
                }
            }
            return isFound;
        }

        public static int AddNewInvoiceDetail(int InvoiceId, int ItemId, int Quantity, decimal UnitPrice, string UnitType)
        {
            int invoiceDetailId = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewInvoiceDetail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@InvoiceId", InvoiceId);
                    command.Parameters.AddWithValue("@ItemId", ItemId);
                    command.Parameters.AddWithValue("@Quantity", Quantity);
                    command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                    command.Parameters.AddWithValue("@UnitType", string.IsNullOrEmpty(UnitType) ? DBNull.Value : (object)UnitType);

                    SqlParameter outputDetailId = new SqlParameter("@InvoiceDetailId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputDetailId);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (outputDetailId.Value is int insertedId)
                        {
                            invoiceDetailId = insertedId;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException(ex);
                        invoiceDetailId = -1;
                    }
                }
            }

            return invoiceDetailId;
        }

        public static bool UpdateInvoiceDetail(int InvoiceDetailId, int InvoiceId, int ItemId, int Quantity, decimal UnitPrice, string UnitType)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateInvoiceDetail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@InvoiceDetailId", InvoiceDetailId);
                    command.Parameters.AddWithValue("@InvoiceId", InvoiceId);
                    command.Parameters.AddWithValue("@ItemId", ItemId);
                    command.Parameters.AddWithValue("@Quantity", Quantity);
                    command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                    command.Parameters.AddWithValue("@UnitType", string.IsNullOrEmpty(UnitType) ? DBNull.Value : (object)UnitType);

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

        public static DataTable GetInvoiceDetailsByInvoiceID(int InvoiceId)
        { 
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@InvoiceId", InvoiceId)
            };

            return clsDataAccessHelper.GetDataTableByStoredProcedure("sp_GetInvoiceDetailsByInvoiceID", parameters);
        }

        public static bool DeleteInvoiceDetail(int InvoiceDetailId)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteInvoiceDetail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InvoiceDetailId", InvoiceDetailId);

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

        public static bool DeleteAllInvoiceDetails(int InvoiceId)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteAllInvoiceDetailsByInvoiceID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InvoiceId", InvoiceId);

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
    }
}
