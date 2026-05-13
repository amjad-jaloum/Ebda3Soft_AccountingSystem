using System;
using System.Data;
using System.Data.SqlClient;
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

        public clsItem()
        {
            this.ItemID = -1;
            this.Name = "";
            this.UnitTypeID = -1;
            Mode = enMode.AddNew;
        }

        private clsItem(int ItemID, string Name, int UnitTypeID)
        {
            this.ItemID = ItemID;
            this.Name = Name;
            this.UnitTypeID = UnitTypeID;
            Mode = enMode.Update;
        }

        private bool _AddNewItem()
        {
            // Call Data Access Layer 
            this.ItemID = clsItemData.AddNewItem(this.Name, this.UnitTypeID);
            return (this.ItemID != -1);
        }

        private bool _UpdateItem()
        {
            // Call Data Access Layer 
            return clsItemData.UpdateItem(this.ItemID, this.Name, this.UnitTypeID);
        }

        public static clsItem Find(int ItemID)
        {
            string Name = "";
            int UnitTypeID = -1;

            bool isFound = clsItemData.GetItemInfoByID(ItemID, ref Name, ref UnitTypeID);

            if (isFound)
                return new clsItem(ItemID, Name, UnitTypeID);
            else
                return null;
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

        public static bool DeleteItem(int ID)
        {
            return clsItemData.DeleteItem(ID);
        }

        public static bool DoesItemExist(string ItemName)
        {
            return clsItemData.DoesItemExist(ItemName);
        }
    }
}