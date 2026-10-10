using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem_DataAccess
{
    public class clsSMSLogData
    {
        public static int AddNewLog(int accountId, string phone, string content)
        {
            int insertedId = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewSMSLog", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountId", accountId);
                    command.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(phone) ? DBNull.Value : (object)phone);
                    command.Parameters.AddWithValue("@Content", string.IsNullOrEmpty(content) ? DBNull.Value : (object)content);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            insertedId = id;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException(ex);
                    }
                }
            }

            return insertedId;
        }
    }
}
