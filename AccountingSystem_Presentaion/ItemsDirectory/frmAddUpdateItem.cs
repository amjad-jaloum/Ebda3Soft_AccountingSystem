using System;
using System.Windows.Forms;
using Ebda3Soft_Business;

namespace Ebda3Soft_AccountingSystem
{
    public partial class frmAddUpdateItem : Form
    {
        // 1. Define Delegate
        public delegate void DataBackEventHandler(int ItemID);

        // 2. Define Event based on the Delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _ItemID = -1;
        private clsItem _Item;

        public frmAddUpdateItem()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateItem(int ItemID)
        {
            InitializeComponent();
            _ItemID = ItemID;
            _Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "إضافة صنف جديد";
                _Item = new clsItem();
                cbUnitTypes.SelectedIndex = 0; // Default to 'Kilo'
            }
            else
            {
                this.Text = "تعديل صنف";
            }

            txtItemName.Text = "";
            lblItemIDValue.Text = "###";
        }

        private void _LoadData()
        {
            _Item = clsItem.Find(_ItemID);

            if (_Item == null)
            {
                MessageBox.Show("لا يوجد صنف يحمل الرقم التعريفي = " + _ItemID, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblItemIDValue.Text = _Item.ItemID.ToString();
            txtItemName.Text = _Item.Name;

            // Map Database ID back to ComboBox Index
            // Formula: Index = ID - 1 (Since ID starts at 1 and Index at 0)
            if (_Item.UnitTypeID > 0 && _Item.UnitTypeID <= cbUnitTypes.Items.Count)
            {
                cbUnitTypes.SelectedIndex = _Item.UnitTypeID - 1;
            }
        }

        private void frmAddEditItem_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("يرجى إكمال الحقول المطلوبة.", "تحقق من الحقول المطلوبة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _Item.Name = txtItemName.Text.Trim();

            // Map ComboBox Index back to Database ID
            // Formula: ID = Index + 1
            _Item.UnitTypeID = cbUnitTypes.SelectedIndex + 1;

            if (_Item.Save())
            {
                lblItemIDValue.Text = _Item.ItemID.ToString();

                // Switch mode to Update after first save
                _Mode = enMode.Update;
                this.Text = "تعديل صنف";

                MessageBox.Show("تم حفظ البيانات بنجاح.", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(_Item.ItemID);
            }
            else
            {
                MessageBox.Show("خطأ: لم يتم حفظ البيانات بنجاح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtItemName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemName.Text.Trim()))
            {
                errorProvider1.SetError(txtItemName, "هذا الحقل مطلوب!");
            }
            else if (clsItem.DoesItemExist(txtItemName.Text.Trim()))
            {
                errorProvider1.SetError(txtItemName, "اسم الصنف هذا موجود مسبقاً!");
            }
            else
            {
                errorProvider1.SetError(txtItemName, string.Empty);
            }
        }
    }
}