using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ebda3Soft_AccountingBusinessLayer;
using Ebda3Soft_Business;

namespace Ebda3Soft_AccountingSystem.AccountsDirectory.Controls
{
    public partial class ctrlAccountCardWithFilter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<int> OnAccountSelected;

        // Create a protected method to raise the event with a parameter
        protected virtual void AccountSelected(int AccountID)
        {
            Action<int> handler = OnAccountSelected;
            if (handler != null)
            {
                handler(AccountID); // Raise the event with the parameter
            }
        }

        private bool _ShowAddAccount = true;
        public bool ShowAddAccount
        {
            get { return _ShowAddAccount; }
            set
            {
                _ShowAddAccount = value;
                btnAddAccount.Enabled = _ShowAddAccount;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        public int AccountID
        {
            get { return ctrlAccountCard1.AccountID; }
        }

        public clsAccount SelectedAccountInfo
        {
            get { return ctrlAccountCard1.SelectedAccountInfo; }
        }

        public ctrlAccountCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadAccountInfo(int AccountID)
        {
            cbFilterBy.SelectedIndex = 0; // Account ID
            txtFilterValue.Text = AccountID.ToString();
            FindNow();
        }

        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                //case "Account ID":
                case "رقم الحساب":
                        ctrlAccountCard1.LoadAccountInfo(int.Parse(txtFilterValue.Text.Trim()));
                    break;

                //case "Account Name":
                case "اسم الحساب":
                    clsAccount account = clsAccount.Find(txtFilterValue.Text.Trim());
                    if (account != null)
                        ctrlAccountCard1.LoadAccountInfo(account.AccountID);
                    break;

                default:
                    break;
            }

            if (OnAccountSelected != null && FilterEnabled)
                OnAccountSelected(ctrlAccountCard1.AccountID);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول غير صالحة! يرجى التأكد من القيمة المدخلة.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow();
        }

        private void ctrlAccountCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                errorProvider1.SetError(txtFilterValue, "هذا الحقل مطلوب!");
            }
            else
            {
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            frmAddUpdateAccount frm1 = new frmAddUpdateAccount();
            frm1.DataBack += DataBackEvent; // الاشتراك في الحدث لاستقبال رقم الحساب الجديد
            frm1.ShowDialog();
        }

        private void DataBackEvent(object sender, int AccountID)
        {
            // معالجة البيانات القادمة من فورم الإضافة
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = AccountID.ToString();
            ctrlAccountCard1.LoadAccountInfo(AccountID);

            if (OnAccountSelected != null)
                OnAccountSelected(AccountID);
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // البحث عند الضغط على Enter
            if (e.KeyChar == (char)13)
            {
                btnFindAccount.PerformClick();
            }

            // السماح بالأرقام فقط إذا كان البحث برقم الحساب
            if (cbFilterBy.Text == "اسم الحساب" || cbFilterBy.Text == "رقم الحساب")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

