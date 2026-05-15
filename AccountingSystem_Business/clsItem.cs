using System;
using System.Data;
using System.Data.SqlClient;
using Ebda3Soft_AccountingSystem_Business;
using Ebda3Soft_AccountingSystem_DataAccess;
using Ebda3Soft_DataAccess;

namespace Ebda3Soft_Business
{
    public class clsItem
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ItemID { get; set; }
        public string Name { get; set; }
        public int UnitTypeID { get; set; }
        public string UnitTypeName
        {
            get
            {
                return clsUnitType.Find(this.UnitTypeID).Name;
            }
        }
        public decimal DefaultUnitPrice { get; set; }


        public clsItem()
        {
            this.ItemID = -1;
            this.Name = "";
            this.UnitTypeID = -1;
            this.DefaultUnitPrice = 0m;
            Mode = enMode.AddNew;
        }

        private clsItem(int ItemId, string Name, int UnitTypeId, decimal DefaultUnitPrice)
        {
            this.ItemID = ItemId;
            this.Name = Name;
            this.UnitTypeID = UnitTypeId;
            this.DefaultUnitPrice = DefaultUnitPrice;
            Mode = enMode.Update;
        }

        public static clsItem Find(int ItemId)
        {
            string Name = "";
            int UnitTypeId = -1;
            decimal DefaultUnitPrice = 0m;

            if (clsItemData.GetItemInfoByID(ItemId, ref Name, ref UnitTypeId, ref DefaultUnitPrice))
            {
                return new clsItem(ItemId, Name, UnitTypeId, DefaultUnitPrice);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewItem()
        {
            // استدعاء طبقة البيانات وإسناد المعرف الجديد للكائن
            this.ItemID = clsItemData.AddNewItem(this.Name, this.UnitTypeID, this.DefaultUnitPrice);
            return (this.ItemID != -1);
        }

        private bool _UpdateItem()
        {
            // تحديث بيانات الصنف الحالي في قاعدة البيانات
            return clsItemData.UpdateItem(this.ItemID, this.Name, this.UnitTypeID, this.DefaultUnitPrice);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewItem())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateItem();
            }

            return false;
        }

        public static DataTable GetAllItems()
        {
            return clsItemData.GetAllItems();
        }

        public static bool DeleteItem(int ItemId)
        {
            return clsItemData.DeleteItem(ItemId);
        }

        public static bool DoesItemExist(string Name)
        {
            return clsItemData.DoesItemExist(Name);
        }

        public static int GetItemIDByName(string Name)
        {
            // استدعاء طبقة البيانات
            return clsItemData.GetItemIDByName(Name);
        }
    }
}