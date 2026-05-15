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

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM UnitTypes WHERE UnitTypeId = @UnitTypeId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UnitTypeId", UnitTypeId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    Name = (string)reader["Name"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handling Error
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