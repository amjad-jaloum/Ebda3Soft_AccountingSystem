using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AccountingSystem_DataAccess;

namespace Ebda3Soft_DataAccess
{
    public class clsAccountData
    {
        public static bool GetAccountInfoByID(int AccountID, ref string Name,
            ref int PersonID, ref byte Type)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAccountInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountID", AccountID);
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
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

        public static int AddNewAccount(string Name, int PersonID, byte Type)
        {
            int AccountID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Type", Type);
                    if (PersonID != -1)
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                    else
                        command.Parameters.AddWithValue("@PersonID", DBNull.Value);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int newAccountID))
                        {
                            AccountID = newAccountID;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException(ex);
                    }
                }
            }


            return AccountID;
        }

        public static bool UpdateAccount(int AccountID, string Name, int PersonID, byte Type)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

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
                        clsEventLog.LogException(ex);
                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteAccount(int AccountID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_DeleteAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountID", AccountID);

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

        public static DataTable GetAllAccounts()
        {
            return clsDataAccessHelper.GetDataTableByStoredProcedure("sp_GetAllAccounts");
        }

        public static bool IsAccountExist(int AccountID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_IsAccountExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountID", AccountID);
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
                    }
                }
            }
            return isFound;
        }

        public static bool GetAccountInfoByName(string AccountName,
            ref int AccountID, ref int PersonID, ref short AccountType)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetAccountInfoByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountName", AccountName);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                AccountID = (int)reader["AccountID"];
                                PersonID = (int)reader["PersonID"];
                                AccountType = Convert.ToInt16(reader["AccountType"]);
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

        public static DataTable GetAccountStatement(int AccountID)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@AccountID", AccountID)
            };

            return clsDataAccessHelper.GetDataTableByStoredProcedure("sp_GetAccountStatement", parameters);
        }
    }
}