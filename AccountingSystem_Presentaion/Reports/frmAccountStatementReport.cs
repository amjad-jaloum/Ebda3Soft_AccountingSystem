using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ebda3Soft_Business;

namespace Ebda3Soft_AccountingSystem.Reports
{
    public partial class frmAccountStateReport : Form
    {
        public frmAccountStateReport()
        {
            InitializeComponent();
        }

        private void ctrlAccountCardWithFilter1_OnAccountSelected(int AccountID)
        {
            if (AccountID == -1)
            {
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

            decimal finalBalance = totalDebit - totalCredit;

            // عرض الرصيد بتنسيق مالي
            lblAccountBalance.Text = finalBalance.ToString("N2");

            // تلوين الرصيد: أحمر إذا كان مديناً (عليه)، أخضر إذا كان دائناً (له)
            lblAccountBalance.ForeColor = (finalBalance > 0) ? Color.Red : Color.Green;
        }
    }
}
