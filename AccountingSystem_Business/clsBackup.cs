using System;

public static class clsBackup
{
    /// <summary>
    /// يقوم بعمل نسخة احتياطية لقاعدة البيانات في المسار المحدد
    /// </summary>
    public static bool Backup(string backupFilePath)
    {
        // يمكنك هنا إضافة شروط التحقق من امتداد الملف مثلاً (.bak)
        if (string.IsNullOrEmpty(backupFilePath))
            return false;

        return clsBackupDataAccess.BackupDatabase(backupFilePath);
    }

    /// <summary>
    /// يقوم باستعادة قاعدة البيانات من ملف النسخة الاحتياطية الممرر
    /// </summary>
    public static bool Restore(string backupFilePath)
    {
        if (string.IsNullOrEmpty(backupFilePath))
            return false;

        return clsBackupDataAccess.RestoreDatabase(backupFilePath);
    }
}