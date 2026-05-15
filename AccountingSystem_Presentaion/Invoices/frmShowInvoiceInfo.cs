using System;
using System.Data;
using System.Windows.Forms;
using AccountingSystem_Business;
// استبدل هذا المسار بمسار كلاسات الـ Business Logic الخاصة بك
// using Ebda3Soft_BusinessLayer; 

namespace Ebda3Soft_AccountingSystem.Invoices
{
    public partial class frmShowInvoiceInfo : Form
    {
        private int _InvoiceID;
        private DataTable _dtInvoiceDetails;

        public frmShowInvoiceInfo(int InvoiceID)
        {
            InitializeComponent();
            _InvoiceID = InvoiceID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowInvoiceInfo_Load(object sender, EventArgs e)
        {
            _LoadInvoiceData();
        }

        private void _LoadInvoiceData()
        {
            clsInvoice Invoice = clsInvoice.Find(_InvoiceID);

            if (Invoice == null)
            {
                MessageBox.Show("خطأ: تعذر العثور على الفاتورة رقم " + _InvoiceID, "غير موجودة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // تعبئة البيانات العامة
            lblInvoiceIDValue.Text = Invoice.InvoiceId.ToString();
            lblDateValue.Text = Invoice.CreatedDate.ToString("yyyy/MM/dd HH:mm");
            lblAccountValue.Text = Invoice.AccountInfo.Name; // اسم الحساب
            lblTypeValue.Text = Invoice.TypeName;
            lblPaymentValue.Text = Invoice.PaymentMethodName;
            lblCreatedByValue.Text = Invoice.UserInfo.UserName; // المستخدم الذي أنشأ الفاتورة
            lblTotalAmountValue.Text = Invoice.TotalAmount.ToString("N2");

            // تعبئة جدول التفاصيل
            _dtInvoiceDetails = clsInvoiceDetail.GetInvoiceDetailsByInvoiceID(_InvoiceID);
            dgvInvoiceItems.DataSource = _dtInvoiceDetails;

            // دالة افتراضية لتنسيق الجدول بعد تعبئته
            _FormatDataGridView();
        }

        private void _FormatDataGridView()
        {
            if (dgvInvoiceItems.Rows.Count > 0)
            {
                dgvInvoiceItems.Columns[0].HeaderText = "رقم الصنف";
                dgvInvoiceItems.Columns[0].Width = 100;

                dgvInvoiceItems.Columns[1].HeaderText = "اسم الصنف";
                dgvInvoiceItems.Columns[1].Width = 250;

                dgvInvoiceItems.Columns[2].HeaderText = "الكمية";
                dgvInvoiceItems.Columns[2].Width = 100;

                dgvInvoiceItems.Columns[3].HeaderText = "سعر الوحدة";
                dgvInvoiceItems.Columns[3].DefaultCellStyle.Format = "N2";
                dgvInvoiceItems.Columns[3].Width = 120;

                dgvInvoiceItems.Columns[4].HeaderText = "الإجمالي";
                dgvInvoiceItems.Columns[4].DefaultCellStyle.Format = "N2";
                dgvInvoiceItems.Columns[4].Width = 150;
            }
        }

        // منطق زر الطباعة (اختياري)
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // هنا يمكنك إضافة منطق استدعاء Crystal Report أو Microsoft Report
            MessageBox.Show("سيتم تفعيل ميزة الطباعة قريباً.", "قيد التطوير", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}