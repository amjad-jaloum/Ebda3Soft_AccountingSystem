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

            _dtInvoiceDetails = new DataTable();
            _dtInvoiceDetails.Columns.Add("ItemID", typeof(int));
            _dtInvoiceDetails.Columns.Add("Name", typeof(string));
            _dtInvoiceDetails.Columns.Add("Quantity", typeof(int));
            _dtInvoiceDetails.Columns.Add("UnitPrice", typeof(decimal));
            _dtInvoiceDetails.Columns.Add("UnitType", typeof(string));
            _dtInvoiceDetails.Columns.Add("Total", typeof(decimal));

            cbPaymentMethod.SelectedIndex = 0;
            dtpInvoiceDate.Value = DateTime.Now;
            txtNotes.Text = "";
            lblTotalAmount.Text = "0.00";
        }

        private void _LoadData()
        {
            this.Text = "تعديل فاتورة";
            tpInvoiceDetails.Enabled = true;
            btnSave.Enabled = true;

            _Invoice = clsInvoice.Find(_InvoiceID);

            if (_Invoice == null)
            {
                MessageBox.Show("لا توجد فاتورة تحمل الرقم التعريفي = " + _InvoiceID, "الفاتورة غير موجودة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            _dtInvoiceDetails = clsInvoiceDetail.GetInvoiceDetailsByInvoiceID(_InvoiceID);
            dgvInvoiceDetails.DataSource = _dtInvoiceDetails;

            //lblInvoiceId.Text = _Invoice.InvoiceId.ToString();
            dtpInvoiceDate.Value = _Invoice.CreatedDate;
            cbPaymentMethod.SelectedIndex = _Invoice.PaymentMethod - 1; // 1 = Cash, 2 = Credit
            rbPurchase.Checked = _Invoice.Type == (byte)clsInvoice.enInvoiceType.Purchases;
            txtNotes.Text = _Invoice.Notes;
            lblTotalAmount.Text = _Invoice.TotalAmount.ToString("N2");
            _FormatDataGridView();

            ctrlAccountCardWithFilter1.LoadAccountInfo(_Invoice.AccountId);
        }

        private void _FormatDataGridView()
        {
            if (dgvInvoiceDetails.Rows.Count > 0)
            {
                dgvInvoiceDetails.Columns[0].HeaderText = "الرقم التعريفي";
                dgvInvoiceDetails.Columns[0].Width = 100;

                dgvInvoiceDetails.Columns[1].HeaderText = "اسم الصنف";
                dgvInvoiceDetails.Columns[1].Width = 250;

                dgvInvoiceDetails.Columns[2].HeaderText = "الكمية";
                dgvInvoiceDetails.Columns[2].Width = 100;

                dgvInvoiceDetails.Columns[3].HeaderText = "نوع الوحدة";
                dgvInvoiceDetails.Columns[3].Width = 100;

                dgvInvoiceDetails.Columns[4].HeaderText = "سعر الوحدة";
                dgvInvoiceDetails.Columns[4].DefaultCellStyle.Format = "N2";
                dgvInvoiceDetails.Columns[4].Width = 120;

                dgvInvoiceDetails.Columns[5].HeaderText = "الإجمالي";
                dgvInvoiceDetails.Columns[5].DefaultCellStyle.Format = "N0";
                dgvInvoiceDetails.Columns[5].Width = 100;
            }
        }

        private void _CalculateTotalAmount()
        {
            decimal total = 0;
            if (dgvInvoiceDetails.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvInvoiceDetails.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Total"].Value);
                }
                lblTotalAmount.Text = total.ToString("N2");
            }
            else
                lblTotalAmount.Text = "0.00";
        }

        private void frmAddUpdateInvoice_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
            {
                tcInvoiceInfo.SelectedTab = tpInvoiceDetails;
                _LoadData();
            }
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
        private void frm_DataBack(clsInvoiceDetail invoiceDetail)
        {
            invoiceDetail.InvoiceId = _InvoiceID;
            if (invoiceDetail.Save())
            {
                frmAddUpdateInvoice_Load(null, null);
            }
            else
            {
                MessageBox.Show("لم يتم الحفظ. خطأ في الحصول على البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceDetails.CurrentRow != null)
            {
                if (clsInvoiceDetail.DeleteDetail((int)dgvInvoiceDetails.CurrentRow.Cells[0].Value))
                {
                    frmAddUpdateInvoice_Load(null, null);
                }
                else
                {
                    MessageBox.Show("لم يتم حذف الصنف. قد يكون السبب ارتباط البيانات", "لم يتم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
            _Invoice.CreatedDate = dtpInvoiceDate.Value;
            _Invoice.Type = rbSales.Checked ? (byte)clsInvoice.enInvoiceType.Sales : (byte)clsInvoice.enInvoiceType.Purchases;

            _Invoice.SessionUserID = clsGlobal.CurrentUser.UserID;
            if (_Invoice.Save())
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