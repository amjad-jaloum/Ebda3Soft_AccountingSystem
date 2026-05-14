using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingSystem_DataAccess;

namespace AccountingSystem_Business
{
    public class clsInvoiceDetail
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int InvoiceDetailId { get; set; }
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string UnitType { get; set; }

        // خاصية مشتقة (Read-only) لحساب الإجمالي في طبقة البزنس
        public decimal Total
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }
        public clsInvoiceDetail()
        {
            this.InvoiceDetailId = -1;
            this.InvoiceId = -1;
            this.ItemId = -1;
            this.Quantity = 0;
            this.UnitPrice = 0;
            this.UnitType = "";

            Mode = enMode.AddNew;
        }

        private clsInvoiceDetail(int InvoiceDetailId, int InvoiceId, int ItemId,
                                 int Quantity, decimal UnitPrice, string UnitType)
        {
            this.InvoiceDetailId = InvoiceDetailId;
            this.InvoiceId = InvoiceId;
            this.ItemId = ItemId;
            this.Quantity = Quantity;
            this.UnitPrice = UnitPrice;
            this.UnitType = UnitType;

            Mode = enMode.Update;
        }

        private bool _AddNewInvoiceDetail()
        {
            this.InvoiceDetailId = clsInvoiceDetailsData.AddNewInvoiceDetail(
                this.InvoiceId, this.ItemId, this.Quantity, this.UnitPrice, this.UnitType);

            return (this.InvoiceDetailId != -1);
        }

        private bool _UpdateInvoiceDetail()
        {
            return clsInvoiceDetailsData.UpdateInvoiceDetail(
                this.InvoiceDetailId, this.InvoiceId, this.ItemId, this.Quantity, this.UnitPrice, this.UnitType);
        }

        public static clsInvoiceDetail Find(int InvoiceDetailId)
        {
            int InvoiceId = -1, ItemId = -1, Quantity = 0;
            decimal UnitPrice = 0;
            string UnitType = "";

            if (clsInvoiceDetailsData.GetInvoiceDetailInfoByID(InvoiceDetailId, ref InvoiceId,
                ref ItemId, ref Quantity, ref UnitPrice, ref UnitType))
            {
                return new clsInvoiceDetail(InvoiceDetailId, InvoiceId, ItemId, Quantity, UnitPrice, UnitType);
            }

            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInvoiceDetail())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateInvoiceDetail();
            }
            return false;
        }

        public static DataTable GetInvoiceDetailsByInvoiceID(int InvoiceId)
        {
            return clsInvoiceDetailsData.GetInvoiceDetailsByInvoiceID(InvoiceId);
        }

        public static bool DeleteDetail(int InvoiceDetailId)
        {
            return clsInvoiceDetailsData.DeleteInvoiceDetail(InvoiceDetailId);
        }
    }
}
