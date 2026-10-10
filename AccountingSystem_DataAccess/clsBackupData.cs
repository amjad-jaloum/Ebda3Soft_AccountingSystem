using System;
using System.Data.SqlClient;
using AccountingSystem_DataAccess;

public static class clsBackupDataAccess
{
    public static bool BackupDatabase(string backupFilePath)
    {
        bool isSuccess = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("sp_BackupDatabase", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BackupFilePath", backupFilePath);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isSuccess = true;
                }
                catch (Exception ex)
                {
                    clsEventLog.LogException(ex);
                    isSuccess = false;
                }
            }
        }

        return isSuccess;
    }

    public static bool RestoreDatabase(string backupFilePath)
    {
        bool isSuccess = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("sp_RestoreDatabase", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BackupFilePath", backupFilePath);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isSuccess = true;
                }
                catch (Exception ex)
                {
                    clsEventLog.LogException(ex);
                    isSuccess = false;
                }
            }
        }

        return isSuccess;
    }
}