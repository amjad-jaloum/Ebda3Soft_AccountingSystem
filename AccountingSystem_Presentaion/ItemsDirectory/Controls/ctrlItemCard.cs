using System;
using System.Windows.Forms;
using Ebda3Soft_AccountingSystem_Business;
using Ebda3Soft_Business;

namespace Ebda3Soft_AccountingSystem.ItemsDirectory.Controls
{
    public partial class ctrlItemCard : UserControl
    {
        // الكائن الذي سيحمل بيانات الصنف المختارة
        private clsItem _Item;
        private int _ItemID = -1;

        // خصائص للوصول للبيانات من خارج المكون
        public int ItemID => _ItemID;
        public clsItem ItemInfo => _Item;

        public ctrlItemCard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// إعادة تعيين الواجهة للحالة الافتراضية
        /// </summary>
        public void ResetItemInfo()
        {
            _ItemID = -1;
            _Item = null;

            lblItemID.Text = "[???]";
            lblItemName.Text = "[???]";
            lblUnitType.Text = "[???]";
        }

        /// <summary>
        /// البحث عن الصنف وتحميل بياناته في العناصر
        /// </summary>
        public void LoadItemInfo(int ItemID)
        {
            _Item = clsItem.Find(ItemID);

            if (_Item == null)
            {
                MessageBox.Show("لم يتم العثور على صنف برقم = " + ItemID, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetItemInfo();
                return;
            }

            _FillItemInfo();
        }

        private void _FillItemInfo()
        {
            _ItemID = _Item.ItemID;
            lblItemID.Text = _Item.ItemID.ToString();
            lblItemName.Text = _Item.Name;
            lblUnitType.Text = clsUnitType.Find(_Item.UnitTypeID).Name;
        }
    }
}