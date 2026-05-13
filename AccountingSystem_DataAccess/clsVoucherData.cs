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
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Vouchers WHERE VoucherId = @VoucherId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VoucherId", VoucherID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    AccountID = (int)reader["AccountId"];
                    Amount = (decimal)reader["Amount"];
                    Type = (byte)reader["Type"];
                    Date = (DateTime)reader["Date"];
                    Notes = (reader["Notes"] == DBNull.Value) ? "" : (string)reader["Notes"];
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

        public static int AddNewVoucher(int AccountID, decimal Amount, byte Type, DateTime Date, string Notes)
        {
            int VoucherID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Vouchers (AccountId, Amount, Type, Date, Notes)
                             VALUES (@AccountId, @Amount, @Type, @Date, @Notes);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountId", AccountID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Type", Type);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    VoucherID = insertedID;
                }
            }
            catch (Exception ex)
            {
                // Handle Exception
            }
            finally
            {
                connection.Close();
            }

            return VoucherID;
        }

        public static bool UpdateVoucher(int VoucherID, int AccountID, decimal Amount, byte Type, DateTime Date, string Notes)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Vouchers
                             SET AccountId = @AccountId,
                                 Amount = @Amount,
                                 Type = @Type,
                                 Date = @Date,
                                 Notes = @Notes
                             WHERE VoucherId = @VoucherId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VoucherId", VoucherID);
            command.Parameters.AddWithValue("@AccountId", AccountID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Type", Type);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);

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

        public static bool DeleteVoucher(int VoucherID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE FROM Vouchers WHERE VoucherId = @VoucherId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VoucherId", VoucherID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle Exception
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllVouchers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT Vouchers.VoucherId, Vouchers.AccountId, Accounts.Name, 
                             Vouchers.Amount, Vouchers.Type, Vouchers.Date 
                             FROM Vouchers 
                             INNER JOIN Accounts ON Vouchers.AccountId = Accounts.AccountId
                             ORDER BY Vouchers.Date DESC";

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
                // Handle Exception
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool IsVoucherExist(int VoucherID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Vouchers WHERE VoucherId = @VoucherId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VoucherId", VoucherID);

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