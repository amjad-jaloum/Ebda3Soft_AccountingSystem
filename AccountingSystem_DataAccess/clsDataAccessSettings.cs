using System;
using System.Configuration;

namespace AccountingSystem_DataAccess
{
    public static class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
    }
}
