using System;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Windows.Forms;
using Ebda3Soft_AccountingSystem.people.Controls;
using Ebda3Soft_Business;

namespace Ebda3Soft_AccountingSystem
{
    public partial class frmAddUpdateAccount : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        // Enum to manage form state
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _AccountID = -1;
        private clsAccount _Account;

        // Constructor for Add New Mode
        public frmAddUpdateAccount()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        // Constructor for Update Mode
        public frmAddUpdateAccount(int AccountID)
        {
            InitializeComponent();
            _AccountID = AccountID;
            _Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "إضافة حساب جديد";
                _Account = new clsAccount();

                // Keep the Account Details tab disabled until a person is selected
                tpAccountDetails.Enabled = false;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                this.Text = "تعديل الحساب";
                tpAccountDetails.Enabled = true;
                btnSave.Enabled = true;
            }

            txtAccountName.Text = "";
            cbAccountType.SelectedIndex = 0; // Default to 'Customer'
            label1.Text = "###"; // This is the Account ID display label
        }

        private void _LoadData()
        {
            _Account = clsAccount.Find(_AccountID);

            if (_Account == null)
            {
                MessageBox.Show("لا يوجد حساب يحمل الرقم التعريفي = " + _AccountID, "الحساب غير موجود",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            // Lock person filtering in update mode to maintain data integrity
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            // Fill UI with business object data
            label1.Text = _Account.AccountID.ToString();
            txtAccountName.Text = _Account.Name;

            // Map the Byte Type to the ComboBox index
            cbAccountType.SelectedIndex = _Account.Type;

            // Load person details into the user control, the -1 check if account is not service provider or other type without person link
            if (_Account.PersonID != -1)
                ctrlPersonCardWithFilter1.LoadPersonInfo(_Account.PersonID);
        }

        private void frmAddUpdateAccount_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                tpAccountDetails.Enabled = true;
                tcAccountInfo.SelectedTab = tcAccountInfo.TabPages["tpAccountDetails"];
                return;
            }

            // In Add New mode, ensure a person is chosen before proceeding
            if (ctrlPersonCardWithFilter1.PersonID != -1 || ctrlPersonCardWithFilter1.IsServiceProvider)
            {
                tpAccountDetails.Enabled = true;
                tcAccountInfo.SelectedTab = tcAccountInfo.TabPages["tpAccountDetails"];

                if (ctrlPersonCardWithFilter1.IsServiceProvider)
                {
                    cbAccountType.SelectedIndex = (int)clsAccount.enAccountType.ServiceProvider;
                    cbAccountType.Enabled = false; // Lock account type to Service Provider if selected
                }
            }
            else
            {
                MessageBox.Show("يرجى اختيار شخص لربطه بهذا الحساب.", "تحديد الشخص",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول غير صالحة! يرجى تمرير مؤشر الفأرة فوق أيقونة الخطأ الحمراء لمعرفة السبب.",
                                "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Account.Type = (byte)cbAccountType.SelectedIndex;

            if (_Account.Type == (byte)clsAccount.enAccountType.ServiceProvider)
                _Account.PersonID = -1;
            else
                _Account.PersonID = ctrlPersonCardWithFilter1.PersonID;

            _Account.Name = txtAccountName.Text.Trim();

            if (_Account.Save())
            {
                label1.Text = _Account.AccountID.ToString();

                // Switch mode to Update after first successful save
                _Mode = enMode.Update;
                this.Text = "تعديل الحساب";

                MessageBox.Show("تم حفظ البيانات بنجاح.", "تم الحفظ",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, _Account.PersonID);
            }
            else
            {
                MessageBox.Show("خطأ: لم يتم حفظ البيانات بنجاح.", "خطأ",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAccountName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountName.Text.Trim()))
            {
                //e.Cancel = true;
                errorProvider1.SetError(txtAccountName, "اسم الحساب مطلوب.");
            }
            else
            {
                errorProvider1.SetError(txtAccountName, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateAccount_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }
    }
}