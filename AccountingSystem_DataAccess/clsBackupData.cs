using System;
using System.Data.SqlClient;
using AccountingSystem_DataAccess;

public static class clsBackupDataAccess
{
    public static bool BackupDatabase(string backupFilePath)
    {
        bool isSuccess = false;

        // استعلام النسخ الاحتياطي الكامل
        string query = $@"BACKUP DATABASE [BusinessDB] 
                         TO DISK = @BackupFilePath 
                         WITH FORMAT, INIT, NAME = 'Full Backup of BusinessDB';";

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BackupFilePath", backupFilePath);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isSuccess = true;
                }
                catch (Exception ex)
                {
                    // يمكن تسجيل الخطأ هنا في ملف Log عند الحاجة
                    isSuccess = false;
                }
            }
        }

        return isSuccess;
    }

    public static bool RestoreDatabase(string backupFilePath)
    {
        bool isSuccess = false;

        string query = $@"
            ALTER DATABASE [BusinessDB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            RESTORE DATABASE [BusinessDB] FROM DISK = @BackupFilePath WITH REPLACE;
            ALTER DATABASE [BusinessDB] SET MULTI_USER;";

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BackupFilePath", backupFilePath);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isSuccess = true;
                }
                catch (Exception ex)
                {
                    isSuccess = false;
                }
            }
        }

        return isSuccess;
    }
}