using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingSystem_Business;
using Ebda3Soft_Business;

namespace Ebda3Soft_AccountingSystem.ItemsDirectory.Controls
{
    public partial class ctrlItemCardWithFilter : UserControl
    {
        // تعريف حدث مخصص يرسل المعرف عند اختيار الصنف
        public event Action<int> OnItemSelected;
        protected virtual void ItemSelected(int ItemId)
        {
            Action<int> handler = OnItemSelected;
            if (handler != null)
            {
                handler(ItemId); // إطلاق الحدث مع تمرير المعرف
            }
        }
        // خاصية للوصول المباشر للمعرف المختارة حالياً
        public int ItemID { get { return ctrlItemCard1.ItemID; } }
        public clsItem ItemInfo { get { return ctrlItemCard1.ItemInfo; } }

        public ctrlItemCardWithFilter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// دالة للبحث عن الصنف بناءً على القيمة المدخلة في الفلتر
        /// </summary>
        private void _FindItem()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text)) return;

            // رقم الصنف
            // اسم الصنف   
            switch (cbFilterBy.Text)
            {
                case "رقم الصنف":
                    if (int.TryParse(txtFilterValue.Text, out int id))
                        LoadItemInfo(id);
                    break;
                case "اسم الصنف":
                    int foundId = clsItem.GetItemIDByName(txtFilterValue.Text.Trim());
                    if (foundId != -1)
                        LoadItemInfo(foundId);
                    else
                        MessageBox.Show("لم يتم العثور على صنف بهذا الاسم.", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        public void LoadItemInfo(int ItemID)
        {
            txtFilterValue.Text = ItemID.ToString();
            ctrlItemCard1.LoadItemInfo(ItemID);

            // استدعاء الحدث المخصص لإبلاغ الشاشة الأم
            if (ctrlItemCard1.ItemID != -1)
                ItemSelected(ctrlItemCard1.ItemID);
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _FindItem();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // تنفيذ البحث عند الضغط على Enter
            if (e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }

            // منع إدخال غير الأرقام إذا كان الفلتر بالـ ID
            if (cbFilterBy.Text == "رقم الصنف")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateItem frm = new frmAddUpdateItem();
            frm.DataBack += LoadItemInfo; // تحديث الكنترول بعد الإضافة
            frm.ShowDialog();
        }

        private void ctrlItemCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

    }
}