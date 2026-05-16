using System;
using System.Collections.Generic;
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
                string query = @"INSERT INTO SMS_Log (AccountId, Phone, Content, CreatedDate)
                             VALUES (@AccountId, @Phone, @Content, GETDATE());
                             SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountId", accountId);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Content", content);

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
                        // Log exception locally or handle it appropriately
                        insertedId = -1;
                    }
                }
            }

            return insertedId;
        }
    }
}
