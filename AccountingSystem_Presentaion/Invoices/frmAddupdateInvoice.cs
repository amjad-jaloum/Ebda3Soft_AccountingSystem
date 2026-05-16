using System;
using System.Data;
using System.Windows.Forms;
using _19___Project___DVLD;
using AccountingSystem_Business;
using Ebda3Soft_AccountingSystem.Invoices.InvoiceDetails;
using Ebda3Soft_Business;

namespace Ebda3Soft_AccountingSystem.Invoices
{
    public partial class frmAddUpdateInvoice : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _InvoiceID = -1;
        private clsInvoice _Invoice;
        private DataTable _dtInvoiceDetails;

        public frmAddUpdateInvoice()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateInvoice(int InvoiceID)
        {
            InitializeComponent();
            _InvoiceID = InvoiceID;
            _Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "إضافة فاتورة جديدة";
                _Invoice = new clsInvoice();
                tpInvoiceDetails.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                this.Text = "تعديل فاتورة";
                tpInvoiceDetails.Enabled = true;
                btnSave.Enabled = true;
            }

            _LoadInvoiceDetailsStructure();
            cbPaymentMethod.SelectedIndex = 0;
            dtpInvoiceDate.Value = DateTime.Now;
            txtNotes.Text = "";
            lblTotalAmount.Text = "0.00";
        }

        private void _LoadInvoiceDetailsStructure()
        {
            if (_Mode == enMode.AddNew)
            {
                _dtInvoiceDetails = new DataTable();
                _dtInvoiceDetails.Columns.Add("ItemID", typeof(int));
                _dtInvoiceDetails.Columns.Add("ItemName", typeof(string));
                _dtInvoiceDetails.Columns.Add("Quantity", typeof(int));
                _dtInvoiceDetails.Columns.Add("UnitPrice", typeof(decimal));
                _dtInvoiceDetails.Columns.Add("UnitType", typeof(string));
                _dtInvoiceDetails.Columns.Add("Total", typeof(decimal));
            }
            else
            {
                _dtInvoiceDetails = clsInvoiceDetail.GetInvoiceDetailsByInvoiceID(_InvoiceID);
            }

            dgvInvoiceDetails.DataSource = _dtInvoiceDetails;
        }

        private void _LoadData()
        {
            _Invoice = clsInvoice.Find(_InvoiceID);
            _dtInvoiceDetails = clsInvoiceDetail.GetInvoiceDetailsByInvoiceID(_InvoiceID);
            if (_Invoice == null)
            {
                MessageBox.Show("لا توجد فاتورة تحمل الرقم التعريفي = " + _InvoiceID, "الفاتورة غير موجودة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //lblInvoiceId.Text = _Invoice.InvoiceId.ToString();
            dtpInvoiceDate.Value = _Invoice.CreatedDate;
            cbPaymentMethod.SelectedIndex = _Invoice.PaymentMethod - 1; // 1 = Cash, 2 = Credit
            txtNotes.Text = _Invoice.Notes;
            lblTotalAmount.Text = _Invoice.TotalAmount.ToString("N2");

            ctrlAccountCardWithFilter1.LoadAccountInfo(_Invoice.AccountId);
        }

        private void _CalculateTotalAmount()
        {
            decimal total = 0;
            foreach (DataRow row in _dtInvoiceDetails.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                    total += Convert.ToDecimal(row["Total"]);
            }
            lblTotalAmount.Text = total.ToString("N2");
        }

        private void frmAddUpdateInvoice_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Check if an account is selected before moving to details tab
            if (ctrlAccountCardWithFilter1.AccountID == -1)
            {
                errorProvider1.SetError(ctrlAccountCardWithFilter1, "يرجى اختيار حساب أولاً!");
                return;
            }

            errorProvider1.SetError(ctrlAccountCardWithFilter1, string.Empty);
            tpInvoiceDetails.Enabled = true;
            tcInvoiceInfo.SelectedTab = tpInvoiceDetails;
            btnSave.Enabled = true;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateInvoiceDetails frm = new frmAddUpdateInvoiceDetails();

            // Subscribe to the Delegate Event
            frm.OnItemAdded += frm_DataBack;

            frm.ShowDialog();
        }

        // This method handles the delegated data sent back from the details form
        private void frm_DataBack(int ItemID, string ItemName, int Quantity, decimal UnitPrice, string UnitType)
        {
            // Create a new data row in the in-memory DataTable
            DataRow row = _dtInvoiceDetails.NewRow();

            row["ItemID"] = ItemID;
            row["ItemName"] = ItemName;
            row["Quantity"] = Quantity;
            row["UnitPrice"] = UnitPrice;
            row["UnitType"] = UnitType;
            row["Total"] = Quantity * UnitPrice; // Calculation done automatically here

            _dtInvoiceDetails.Rows.Add(row);

            // Update UI total amount display
            _CalculateTotalAmount();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceDetails.CurrentRow != null)
            {
                dgvInvoiceDetails.Rows.RemoveAt(dgvInvoiceDetails.CurrentRow.Index);
                _CalculateTotalAmount();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_dtInvoiceDetails.Rows.Count == 0)
            {
                MessageBox.Show("لا يمكن حفظ فاتورة فارغة!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Invoice.AccountId = ctrlAccountCardWithFilter1.AccountID;
            _Invoice.PaymentMethod = (byte)(cbPaymentMethod.SelectedIndex + 1);
            _Invoice.Notes = txtNotes.Text.Trim();
            _Invoice.TotalAmount = Convert.ToDecimal(lblTotalAmount.Text);
            _Invoice.CreatedBy = clsGlobal.CurrentUser.UserID;
            _Invoice.Type = rbSales.Checked ? (byte)clsInvoice.enInvoiceType.Sales : (byte)clsInvoice.enInvoiceType.Purchases;

            _Invoice.ItemsDetails.Clear();
            foreach (DataRow row in _dtInvoiceDetails.Rows)
            {
                clsInvoiceDetail detail = new clsInvoiceDetail();
                detail.ItemId = (int)row["ItemID"];
                detail.Quantity = (int)row["Quantity"];
                detail.UnitPrice = (decimal)row["UnitPrice"];
                detail.UnitType = (string)row["UnitType"];

                _Invoice.ItemsDetails.Add(detail);
            }

            if (_Invoice.SaveFullInvoice())
            {
                MessageBox.Show("تم حفظ الفاتورة بنجاح مع الرقم التعريفي: " + _Invoice.InvoiceId, "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                this.Text = "تعديل فاتورة";
            }
            else
            {
                MessageBox.Show("فشلت عملية حفظ الفاتورة!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}