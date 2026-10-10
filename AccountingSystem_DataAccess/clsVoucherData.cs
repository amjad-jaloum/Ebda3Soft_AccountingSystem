using System;
using System.Data;
using System.Data.SqlClient;
using AccountingSystem_DataAccess;

namespace Ebda3Soft_AccountingDataLayer
{
    public class clsVoucherData
    {
        public static bool GetVoucherInfoByID(int VoucherID, ref int AccountID, ref decimal Amount,
    ref byte Type, ref DateTime Date, ref string Notes)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetVoucherInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@VoucherID", VoucherID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                AccountID = (int)reader["AccountId"];
                                Amount = (decimal)reader["Amount"];
                                Type = (byte)reader["Type"];
                                Date = (DateTime)reader["CreatedDate"];
                                Notes = (reader["Notes"] == DBNull.Value) ? string.Empty : (string)reader["Notes"];
                            }
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

        public static int AddNewVoucher(int AccountID, decimal Amount, byte Type, DateTime CreatedDate, string Notes)
        {
            int voucherID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewVoucher", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountId", AccountID);
                    command.Parameters.AddWithValue("@Amount", Amount);
                    command.Parameters.AddWithValue("@Type", Type);
                    command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

                    if (string.IsNullOrEmpty(Notes))
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Notes", Notes);

                    SqlParameter outputVoucherIDParam = new SqlParameter("@VoucherID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputVoucherIDParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (outputVoucherIDParam.Value != DBNull.Value)
                        {
                            voucherID = Convert.ToInt32(outputVoucherIDParam.Value);
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException(ex);
                    }
                }
            }

            return voucherID;
        }

        public static bool UpdateVoucher(int VoucherID, int AccountID, decimal Amount, byte Type, DateTime CreatedDate, string Notes)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateVoucher", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@VoucherID", VoucherID);
                    command.Parameters.AddWithValue("@AccountId", AccountID);
                    command.Parameters.AddWithValue("@Amount", Amount);
                    command.Parameters.AddWithValue("@Type", Type);
                    command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

                    if (string.IsNullOrEmpty(Notes))
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Notes", Notes);

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

            return rowsAffected > 0;
        }

        public static bool DeleteVoucher(int VoucherID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteVoucher", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@VoucherID", VoucherID);

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

            return rowsAffected > 0;
        }

        public static DataTable GetAllVouchers()
        {
            return clsDataAccessHelper.GetDataTableByStoredProcedure("sp_GetAllVouchers");
        }
        public static bool IsVoucherExist(int VoucherID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_IsVoucherExistByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@VoucherID", VoucherID);

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