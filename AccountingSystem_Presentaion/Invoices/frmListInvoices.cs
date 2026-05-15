using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;
using AccountingSystem_Business;

namespace Ebda3Soft_AccountingSystem.Invoices
{
    public partial class frmListInvoices : Form
    {
        // استخدام DataView للفلترة السريعة في الذاكرة
        private DataView _dvInvoices;

        public frmListInvoices()
        {
            InitializeComponent();
        }

        private void _RefreshInvoicesList()
        {
            DataTable dtInvoices = clsInvoice.GetAllInvoices();
            _dvInvoices = dtInvoices.DefaultView;

            dgvInvoices.DataSource = _dvInvoices;
            lblRowsCountValue.Text = _dvInvoices.Count.ToString();

            if (dgvInvoices.Rows.Count > 0)
            {
                dgvInvoices.Columns["InvoiceId"].HeaderText = "ID";
                dgvInvoices.Columns["Name"].HeaderText = "Account Name";
                dgvInvoices.Columns["TypeName"].HeaderText = "Type";
                dgvInvoices.Columns["PaymentMethodName"].HeaderText = "Payment Method";
                dgvInvoices.Columns["TotalAmount"].HeaderText = "Total Amount";
                dgvInvoices.Columns["CreatedDate"].HeaderText = "Date";

                // إخفاء الأعمدة الرقمية التي لا نحتاج لعرضها (الأعمدة الأصلية قبل التحويل لنص)
                if (dgvInvoices.Columns.Contains("Type")) dgvInvoices.Columns["Type"].Visible = false;
                if (dgvInvoices.Columns.Contains("PaymentMethod")) dgvInvoices.Columns["PaymentMethod"].Visible = false;

                dgvInvoices.Columns["TotalAmount"].DefaultCellStyle.Format = "N2"; // for decimal formatting
                dgvInvoices.Columns["CreatedDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            }
        }

        private string _GetSearchFilterExpression()
        {
            if (cbFilter.Text == "None" || string.IsNullOrEmpty(txtSearch.Text.Trim()))
                return "";

            switch (cbFilter.Text)
            {
                case "Invoice ID":
                    return string.Format("[InvoiceId] = {0}", txtSearch.Text.Trim());

                case "Account Name":
                    return string.Format("[Name] LIKE '{0}%'", txtSearch.Text.Trim());

                default:
                    return "";
            }
        }

        private string _GetTypeFilterExpression()
        {
            if (cbInvoiceType.Enabled && cbInvoiceType.Text != "الكل")
            {
                return string.Format("[TypeName] = '{0}'", cbInvoiceType.Text);
            }
            return "";
        }

        private string _GetPaymentMethodFilterExpression()
        {
            if (cbPaymentMethod.Enabled && cbPaymentMethod.Text != "الكل")
            {
                return string.Format("[PaymentMethodName] = '{0}'", cbPaymentMethod.Text);
            }
            return "";
        }
        private void _ApplyFilter()
        {
            if (_dvInvoices == null) return;

            // قائمة لتخزين أجزاء الفلترة الصالحة فقط
            List<string> filterParts = new List<string>();

            string searchFilter = _GetSearchFilterExpression();
            string typeFilter = _GetTypeFilterExpression();
            string paymentFilter = _GetPaymentMethodFilterExpression();

            if (!string.IsNullOrEmpty(searchFilter))
                filterParts.Add(searchFilter);

            if (!string.IsNullOrEmpty(typeFilter))
                filterParts.Add(typeFilter);

            if (!string.IsNullOrEmpty(paymentFilter))
                filterParts.Add(paymentFilter);

            // دمج كافة العناصر الموجودة في القائمة بكلمة AND
            // إذا كانت القائمة فارغة، سيتم إرجاع نص فارغ (عرض الكل) تلقائياً
            string finalFilter = string.Join(" AND ", filterParts);

            _dvInvoices.RowFilter = finalFilter;

            lblRowsCountValue.Text = _dvInvoices.Count.ToString();
        }

        private void frmListInvoices_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0; // "None"
            cbInvoiceType.SelectedIndex = 0; // "All"
            cbPaymentMethod.SelectedIndex = 0; // "All"

            _RefreshInvoicesList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // إظهار أو إخفاء عناصر التحكم بناءً على نوع الفلتر المختار
            bool isSearchVisible = (cbFilter.Text != "None");
            txtSearch.Enabled = isSearchVisible;

            if (isSearchVisible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }

            if (dgvInvoices.Rows.Count > 0)
                _ApplyFilter();
        }

        private void cbInvoiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvInvoices.Rows.Count > 0)
                _ApplyFilter();
        }

        private void cbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvInvoices.Rows.Count > 0)
                _ApplyFilter();
        }

        private void btnAddNewInvoice_Click(object sender, EventArgs e)
        {
            // هنا تفتح شاشة إضافة فاتورة جديدة
            frmAddUpdateInvoice frm = new frmAddUpdateInvoice();
            frm.ShowDialog();
            _RefreshInvoicesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int invoiceID = (int)dgvInvoices.CurrentRow.Cells["InvoiceId"].Value;

            if (MessageBox.Show($"Are you sure you want to delete invoice [{invoiceID}]?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsInvoice.DeleteInvoice(invoiceID))
                {
                    MessageBox.Show("Invoice deleted successfully.");
                    _RefreshInvoicesList();
                }
                else
                {
                    MessageBox.Show("Error: Could not delete invoice.");
                }
            }
        }

        private void showInvoiceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int invoiceID = (int)dgvInvoices.CurrentRow.Cells["InvoiceId"].Value;
            frmShowInvoiceInfo frm = new frmShowInvoiceInfo(invoiceID);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int invoiceID = (int)dgvInvoices.CurrentRow.Cells[0].Value;
            frmAddUpdateInvoice frm = new frmAddUpdateInvoice(invoiceID);
            frm.ShowDialog();
            _RefreshInvoicesList();
        }
    }
}