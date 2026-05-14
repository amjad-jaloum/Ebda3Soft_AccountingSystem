using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingSystem_DataAccess;
using Ebda3Soft_Business;

namespace AccountingSystem_Business
{
    public class clsInvoice
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int InvoiceId { get; set; }
        public byte Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte PaymentMethod { get; set; }

        // Composition: الربط مع كلاس الحسابات
        public int AccountId { get; set; }
        public clsAccount AccountInfo { get; private set; } // خاصية للقراءة فقط لضمان سلامة البيانات

        public string Notes { get; set; }
        public decimal TotalAmount { get; set; }
        public int CreatedBy { get; set; }

        public clsInvoice()
        {
            this.InvoiceId = -1;
            this.Type = 0;
            this.CreatedDate = DateTime.Now;
            this.PaymentMethod = 0;
            this.AccountId = -1;
            this.Notes = "";
            this.TotalAmount = 0;
            this.CreatedBy = -1;

            Mode = enMode.AddNew;
        }

        private clsInvoice(int InvoiceId, byte Type, DateTime CreatedDate, byte PaymentMethod,
                           int AccountId, string Notes, decimal TotalAmount, int CreatedBy)
        {
            this.InvoiceId = InvoiceId;
            this.Type = Type;
            this.CreatedDate = CreatedDate;
            this.PaymentMethod = PaymentMethod;
            this.AccountId = AccountId;

            // تحميل بيانات الحساب عند جلب الفاتورة من قاعدة البيانات
            this.AccountInfo = clsAccount.Find(AccountId);

            this.Notes = Notes;
            this.TotalAmount = TotalAmount;
            this.CreatedBy = CreatedBy;

            Mode = enMode.Update;
        }

        public static clsInvoice Find(int InvoiceId)
        {
            byte Type = 0;
            DateTime CreatedDate = DateTime.Now;
            byte PaymentMethod = 0;
            int AccountId = -1;
            string Notes = "";
            decimal TotalAmount = 0;
            int CreatedBy = -1;

            if (clsInvoiceData.GetInvoiceInfoByID(InvoiceId, ref Type, ref CreatedDate,
                ref PaymentMethod, ref AccountId, ref Notes, ref TotalAmount, ref CreatedBy))
            {
                return new clsInvoice(InvoiceId, Type, CreatedDate, PaymentMethod,
                                      AccountId, Notes, TotalAmount, CreatedBy);
            }

            return null;
        }
        private bool _AddNewInvoice()
        {
            this.InvoiceId = clsInvoiceData.AddNewInvoice(this.Type, this.PaymentMethod,
                                                          this.AccountId, this.Notes,
                                                          this.TotalAmount, this.CreatedBy);

            return (this.InvoiceId != -1);
        }

        private bool _UpdateInvoice()
        {
            return clsInvoiceData.UpdateInvoice(this.InvoiceId, this.Type, this.PaymentMethod,
                                                this.AccountId, this.Notes, this.TotalAmount);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInvoice())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateInvoice();
            }

            return false;
        }

        public static DataTable GetAllInvoices()
        {
            return clsInvoiceData.GetAllInvoices();
        }

        public static bool DeleteInvoice(int InvoiceId)
        {
            return clsInvoiceData.DeleteInvoice(InvoiceId);
        }

        public static bool IsInvoiceExist(int InvoiceId)
        {
            return clsInvoiceData.DoesInvoiceExist(InvoiceId);
        }
    }
}
