using System;
using System.Data;
using Ebda3Soft_AccountingSystem_DataAccess;

namespace Ebda3Soft_AccountingSystem_Business
{
    public class clsUnitType
    {
        public int UnitTypeId { get; set; }
        public string Name { get; set; }

        private clsUnitType(int UnitTypeId, string Name)
        {
            this.UnitTypeId = UnitTypeId;
            this.Name = Name;
        }

        public static clsUnitType Find(int UnitTypeId)
        {
            string Name = "";

            if (clsUnitTypeData.GetUnitTypeInfoByID(UnitTypeId, ref Name))
            {
                return new clsUnitType(UnitTypeId, Name);
            }
            else
            {
                return null;
            }
        }
    }
}