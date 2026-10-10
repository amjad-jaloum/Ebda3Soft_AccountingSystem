using System;
using System.Data;
using System.Data.SqlClient;
using AccountingSystem_DataAccess;

namespace Ebda3Soft_AccountingSystem_DataAccess
{
    public class clsUnitTypeData
    {
        public static bool GetUnitTypeInfoByID(int UnitTypeId, ref string Name)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetUnitTypeInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UnitTypeId", UnitTypeId);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                Name = (string)reader["Name"];
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
    }
}