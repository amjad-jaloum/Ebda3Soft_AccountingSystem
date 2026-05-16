using System;
using System.ComponentModel;
using System.Windows.Forms;
using Ebda3Soft_AccountingBusinessLayer;

namespace Ebda3Soft_AccountingSystem.AccountsDirectory
{
    public partial class frmAddUpdateVoucher : Form
    {
        public delegate void DataBackEventHandler(object sender, int VoucherID);
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _VoucherID = -1;
        private clsVoucher _Voucher;

        public frmAddUpdateVoucher()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateVoucher(int VoucherID)
        {
            InitializeComponent();
            _VoucherID = VoucherID;
            _Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "إضافة سند جديد";
                _Voucher = new clsVoucher();
                tpVoucherDetails.Enabled = false;
            }
            else
            {
                this.Text = "تعديل سند";
                tpVoucherDetails.Enabled = true;
            }

            lblVoucherId.Text = "###";
            txtAmount.Text = "";
            dtpVoucherDate.Value = DateTime.Now;
            rbReceipt.Checked = true;
            txtNotes.Text = "";
        }

        private void _LoadData()
        {
            _Voucher = clsVoucher.Find(_VoucherID);

            if (_Voucher == null)
            {
                MessageBox.Show("لا يوجد سند بهذا الرقم = " + _VoucherID, "سند غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblVoucherId.Text = _Voucher.VoucherID.ToString();
            txtAmount.Text = _Voucher.Amount.ToString();
            dtpVoucherDate.Value = _Voucher.Date;
            txtNotes.Text = _Voucher.Notes;

            if (_Voucher.Type == clsVoucher.enVoucherType.Receipt)
                rbReceipt.Checked = true;
            else
                rbPayment.Checked = true;

            ctrlAccountCardWithFilter1.LoadAccountInfo(_Voucher.AccountID);
            ctrlAccountCardWithFilter1.FilterEnabled = false;
        }

        private void frmAddUpdateVoucher_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                tcVoucherInfo.SelectedIndex = 1;
                return;
            }

            if (ctrlAccountCardWithFilter1.AccountID != -1)
            {
                tpVoucherDetails.Enabled = true;
                tcVoucherInfo.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("يرجى اختيار حساب أولاً للمتابعة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Triggers WinForms control validation built-in mechanism
            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول غير صالحة! يرجى التأكد من الحقول التي تحمل علامة الخطأ.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Voucher.AccountID = ctrlAccountCardWithFilter1.AccountID;
            _Voucher.Amount = Convert.ToDecimal(txtAmount.Text.Trim());
            _Voucher.Date = dtpVoucherDate.Value;
            _Voucher.Notes = txtNotes.Text.Trim();
            _Voucher.Type = rbReceipt.Checked ? clsVoucher.enVoucherType.Receipt : clsVoucher.enVoucherType.Payment;

            if (_Voucher.Save())
            {
                lblVoucherId.Text = _Voucher.VoucherID.ToString();
                _Mode = enMode.Update;
                this.Text = "تعديل سند";

                MessageBox.Show("تم حفظ بيانات السند بنجاح.", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, _Voucher.VoucherID);
            }
            else
            {
                MessageBox.Show("خطأ: لم يتم حفظ السند بنجاح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "هذا الحقل مطلوب!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows numbers, control keys, and only one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}