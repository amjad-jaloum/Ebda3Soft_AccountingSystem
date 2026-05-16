using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ebda3Soft_Business;

namespace Ebda3Soft_AccountingSystem.Reports
{
    public partial class frmAccountStateReport : Form
    {
        private clsAccount _Account;
        public frmAccountStateReport()
        {
            InitializeComponent();
        }
        private decimal _finalBalance = 0;
        private void ctrlAccountCardWithFilter1_OnAccountSelected(int AccountID)
        {
            if (AccountID == -1)
            {
                _Account = clsAccount.Find(AccountID);
                dgvAccountStatement.DataSource = null;
                lblAccountBalance.Text = "0.00";
                return;
            }

            _LoadAccountStatement(AccountID);
        }

        private void _LoadAccountStatement(int AccountID)
        {
            // جلب البيانات من طبقة المنطق (التي تستدعي الـ View)
            DataTable dtStatement = clsAccount.GetStatement(AccountID);

            dgvAccountStatement.DataSource = dtStatement;
            _FormatAccountStatementGrid();

            // حساب وعرض الرصيد النهائي
            _CalculateBalance(dtStatement);
        }
        private void _FormatAccountStatementGrid()
        {
            if (dgvAccountStatement.Columns.Count > 0)
            {
                dgvAccountStatement.Columns["TransactionDate"].HeaderText = "التاريخ";
                dgvAccountStatement.Columns["ReferenceNo"].HeaderText = "رقم المرجع";
                dgvAccountStatement.Columns["Description"].HeaderText = "البيان";
                dgvAccountStatement.Columns["Debit"].HeaderText = "مدين (عليه)";
                dgvAccountStatement.Columns["Credit"].HeaderText = "دائن (له)";

                // تنسيق الأرقام لعرض خانتين عشريتين
                dgvAccountStatement.Columns["Debit"].DefaultCellStyle.Format = "N2";
                dgvAccountStatement.Columns["Credit"].DefaultCellStyle.Format = "N2";
            }
        }

        private void _CalculateBalance(DataTable dt)
        {
            decimal totalDebit = 0;
            decimal totalCredit = 0;

            foreach (DataRow row in dt.Rows)
            {
                totalDebit += Convert.ToDecimal(row["Debit"]);
                totalCredit += Convert.ToDecimal(row["Credit"]);
            }

            _finalBalance = totalDebit - totalCredit;

            // عرض الرصيد بتنسيق مالي
            lblAccountBalance.Text = _finalBalance.ToString("N2");

            // تلوين الرصيد: أحمر إذا كان مديناً (عليه)، أخضر إذا كان دائناً (له)
            lblAccountBalance.ForeColor = (_finalBalance > 0) ? Color.Red : Color.Green;
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {
            // Feature placeholder notification
            MessageBox.Show("هذه الميزة ستتوفر قريباً في التحديث القادم.", "قريباً",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*
            int currentAccountId = _Account.AccountID;
            string clientPhoneNumber = _Account.PersonInfo.Phone; // E.g., "77xxxxxxx"

            // Trigger the business method to send and log the SMS
            if (clsSMSLog.SendBalanceAlert(currentAccountId, clientPhoneNumber, _finalBalance))
            {
                MessageBox.Show("تم إرسال رسالة تنبيه بالرصيد بنجاح وتوثيقها في النظام.", "تم الإرسال",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل إرسال رسالة الـ SMS، يرجى التحقق من اتصال البوابة أو رقم الهاتف.", "خطأ في الإرسال",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
        }
    }
}
