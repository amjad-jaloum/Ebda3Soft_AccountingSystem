using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebda3Soft_AccountingSystem.Invoices.InvoiceDetails
{
    public partial class frmAddUpdateInvoiceDetails : Form
    {
        // تعريف الـ Delegate والحدث لإرسال البيانات للخلف
        public delegate void DataBackEventHandler(int ItemID, string ItemName, int Quantity, decimal UnitPrice, string UnitType);
        public event DataBackEventHandler OnItemAdded;

        public frmAddUpdateInvoiceDetails()
        {
            InitializeComponent();
        }

        private void _CalculateTotal()
        {
            if (decimal.TryParse(txtQuantity.Text, out decimal Qty) &&
                decimal.TryParse(txtDefaultUnitPrice.Text, out decimal Price))
            {
                txtTotal.Text = (Qty * Price).ToString("N2");
            }
            else
            {
                txtTotal.Text = "0.00";
            }
        }

        private void frmAddUpdateInvoiceDetails_Load(object sender, EventArgs e)
        {
            txtQuantity.Text = "1";
            txtDefaultUnitPrice.Text = "0";
            txtTotal.Text = "0";

            //ctrlItemCardWithFilter1.FilterFocus();
        }

        private void ctrlItemCardWithFilter1_OnItemSelected(int ItemID)
        {
            // عند اختيار صنف من الـ Control، نقوم بتعبئة السعر الافتراضي إن وجد
            if (ItemID != -1)
            {
                // افترضنا أن الـ Control يوفر بيانات الصنف المختار
                txtDefaultUnitPrice.Text = ctrlItemCardWithFilter1.ItemInfo.DefaultUnitPrice.ToString("N2");
                txtUnitType.Text = ctrlItemCardWithFilter1.ItemInfo.UnitTypeName;
                _CalculateTotal();
                txtQuantity.Focus();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            _CalculateTotal();
        }

        private void ctrlItemCardWithFilter1_Validating(object sender, CancelEventArgs e)
        {
            if (ctrlItemCardWithFilter1.ItemID == -1)
            {
                e.Cancel = true; // منع الانتقال للعنصر التالي إذا فشل التحقق
                errorProvider1.SetError(ctrlItemCardWithFilter1, "Please select an item first!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ctrlItemCardWithFilter1, "");
            }
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtQuantity, "Quantity is required!");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int Qty) || Qty <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtQuantity, "Enter a valid quantity greater than 0!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtQuantity, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            int Qty = int.Parse(txtQuantity.Text);
            decimal Price = decimal.Parse(txtDefaultUnitPrice.Text);
            string itemName = ctrlItemCardWithFilter1.ItemInfo.Name;
            string unitType = txtUnitType.Text;

            // استدعاء المفوض لإرسال البيانات للخلف
            OnItemAdded?.Invoke(ctrlItemCardWithFilter1.ItemID, itemName, Qty, Price, unitType);

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
