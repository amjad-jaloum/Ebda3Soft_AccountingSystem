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
    public partial class frmInventoryReport : Form
    {
        public frmInventoryReport()
        {
            InitializeComponent();
        }

        private void frmInventoryReport_Load(object sender, EventArgs e)
        {
            _RefreshInventoryReport();
        }

        private void _RefreshInventoryReport()
        {
            // جلب البيانات من طبقة المنطق
            DataTable dtInventory = clsItem.GetItemsInventory();

            dgvInventory.DataSource = dtInventory;
            _FormatInventoryGrid();
        }

        private void _FormatInventoryGrid()
        {
            if (dgvInventory.Columns.Count > 0)
            {
                dgvInventory.Columns[0].HeaderText = "اسم الصنف";
                dgvInventory.Columns[1].HeaderText = "إجمالي المشتريات";
                dgvInventory.Columns[2].HeaderText = "إجمالي المبيعات";
                dgvInventory.Columns[3].HeaderText = "المخزون المتبقي";

                // تمييز عمود المخزون بالخط العريض
                dgvInventory.Columns[3].DefaultCellStyle.Font = new Font(dgvInventory.Font, FontStyle.Bold);
                dgvInventory.Columns[3].DefaultCellStyle.ForeColor = Color.Blue;
            }
        }

        // زر لتحديث البيانات يدوياً
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshInventoryReport();
        }
    }
}
