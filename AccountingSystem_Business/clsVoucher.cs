using System;
using System.Data;
// Assuming clsAccount is in this namespace
using Ebda3Soft_AccountingBusinessLayer;
using Ebda3Soft_AccountingDataLayer;
using Ebda3Soft_Business;

namespace Ebda3Soft_AccountingBusinessLayer
{
    public class clsVoucher
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        // Enum for Voucher Types
        public enum enVoucherType { Receipt = 1, Payment = 2 };

        public int VoucherID { get; set; }
        public int AccountID { get; set; }
        public decimal Amount { get; set; }
        public enVoucherType Type { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        // Composition: Access account details via the voucher
        public clsAccount AccountInfo { get; private set; }

        public clsVoucher()
        {
            this.VoucherID = -1;
            this.AccountID = -1;
            this.Amount = 0;
            this.Type = enVoucherType.Receipt;
            this.Date = DateTime.Now;
            this.Notes = "";

            this.AccountInfo = null;
            Mode = enMode.AddNew;
        }

        private clsVoucher(int VoucherID, int AccountID, decimal Amount, byte Type, DateTime Date, string Notes)
        {
            this.VoucherID = VoucherID;
            this.AccountID = AccountID;
            this.Amount = Amount;
            this.Type = (enVoucherType)Type;
            this.Date = Date;
            this.Notes = Notes;

            // Load account information automatically (Composition)
            this.AccountInfo = clsAccount.Find(AccountID);

            Mode = enMode.Update;
        }

        public static clsVoucher Find(int VoucherID)
        {
            int AccountID = -1;
            decimal Amount = 0;
            byte Type = 0;
            DateTime Date = DateTime.Now;
            string Notes = "";

            if (clsVoucherData.GetVoucherInfoByID(VoucherID, ref AccountID, ref Amount, ref Type, ref Date, ref Notes))
            {
                return new clsVoucher(VoucherID, AccountID, Amount, Type, Date, Notes);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewVoucher()
        {
            // Cast enum back to byte for the Data Layer
            this.VoucherID = clsVoucherData.AddNewVoucher(this.AccountID, this.Amount, (byte)this.Type, this.Date, this.Notes);
            return (this.VoucherID != -1);
        }

        private bool _UpdateVoucher()
        {
            return clsVoucherData.UpdateVoucher(this.VoucherID, this.AccountID, this.Amount, (byte)this.Type, this.Date, this.Notes);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVoucher())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateVoucher();
            }

            return false;
        }

        public static DataTable GetAllVouchers()
        {
            return clsVoucherData.GetAllVouchers();
        }

        public static bool DeleteVoucher(int VoucherID)
        {
            return clsVoucherData.DeleteVoucher(VoucherID);
        }

        public static bool IsVoucherExist(int VoucherID)
        {
            return clsVoucherData.IsVoucherExist(VoucherID);
        }
    }
}