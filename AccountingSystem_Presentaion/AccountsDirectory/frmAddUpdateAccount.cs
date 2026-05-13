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
                this.Text = "Add New Account";
                _Account = new clsAccount();

                // Keep the Account Details tab disabled until a person is selected
                tpAccountDetails.Enabled = false;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                this.Text = "Update Account";
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
                MessageBox.Show("No Account with ID = " + _AccountID, "Account Not Found",
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
                MessageBox.Show("Please select a person to link with this account.", "Select Person",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Please hover over the red icon(s) to see the error.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.Text = "Update Account";

                MessageBox.Show("Data Saved Successfully.", "Saved",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data was not saved successfully.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAccountName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountName.Text.Trim()))
            {
                //e.Cancel = true;
                errorProvider1.SetError(txtAccountName, "Account Name is required.");
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