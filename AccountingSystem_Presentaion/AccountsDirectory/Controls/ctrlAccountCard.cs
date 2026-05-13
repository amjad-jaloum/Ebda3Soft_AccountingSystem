using System;
using System.Windows.Forms;
using Ebda3Soft_AccountingBusinessLayer;
using Ebda3Soft_Business;
using static Ebda3Soft_Business.clsAccount;

namespace Ebda3Soft_AccountingSystem.AccountsDirectory.Controls
{
    public partial class ctrlAccountCard : UserControl
    {
        private clsAccount _Account;
        private int _AccountID = -1;

        public int AccountID
        {
            get { return _AccountID; }
        }

        public clsAccount SelectedAccountInfo
        {
            get { return _Account; }
        }

        public ctrlAccountCard()
        {
            InitializeComponent();
        }

        public void LoadAccountInfo(int AccountID)
        {
            _Account = clsAccount.Find(AccountID);

            if (_Account == null)
            {
                ResetAccountInfo();
                MessageBox.Show("لا يوجد حساب بهذا الرقم = " + AccountID, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillAccountInfo();
        }

        private void _FillAccountInfo()
        {
            _AccountID = _Account.AccountID;

            lblAccountID.Text = _Account.AccountID.ToString();
            lblAccountName.Text = _Account.Name;

            // هنا نصل لاسم الشخص عبر الـ Composition الموجود في كائن الحساب
            // بفرض أن كائن الحساب يحتوي على كائن الشخص المرتبط به
            if (_Account.PersonInfo != null)
                lblPersonName.Text = _Account.PersonInfo.FullName;
            else
                lblPersonName.Text = "[???]";

            // عرض نوع الحساب (Customer, Supplier, etc...)
            lblAccountType.Text = _GetAccountTypeText((enAccountType)_Account.Type);
        }
        private string _GetAccountTypeText(enAccountType AccountType)
        {
            switch (AccountType)
            {
                case enAccountType.Customer:
                    return "عميل";
                case enAccountType.Supplier:
                    return "مورد";
                case enAccountType.Employee:
                    return "موظف";
                case enAccountType.ServiceProvider:
                    return "مزود خدمة";
                case enAccountType.Partner:
                    return "شريك";
                default:
                    return "غير محدد";
            }
        }
        public void ResetAccountInfo()
        {
            _AccountID = -1;
            lblAccountID.Text = "###";
            lblAccountName.Text = "[???]";
            lblPersonName.Text = "[???]";
            lblAccountType.Text = "[???]";
        }
    }
}