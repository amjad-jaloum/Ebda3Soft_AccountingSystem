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
using Ebda3Soft_AccountingSystem;

namespace _19___Project___DVLD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please fix the validation errors before login",
                    "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsUser user = clsUser.FindByUsernameAndPassword(tbUsername.Text, tbPassword.Text);

            if (user != null)
            {
                if (chxRememberMe.Checked)
                    clsGlobal.RemeberUsernameAndPassword(tbUsername.Text, tbPassword.Text);
                else
                    clsGlobal.RemeberUsernameAndPassword("", ""); // reset

                if (user.IsActive)
                {
                    clsGlobal.CurrentUser = user;
                    this.Hide();
                    frmMain frm = new frmMain(this);
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("The user is not allowed to login, please try another user",
                        "Permession denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("The Username/Password is wrong",
                    "Permession denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string username = "", password = "";
            if (clsGlobal.GetStoredCredential(ref username, ref password))
            {
                tbUsername.Text = username;
                tbPassword.Text = password;
                chxRememberMe.Checked = true;
            }
            else
                chxRememberMe.Checked = false;
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text.Trim()))
            {
                errorProvider1.SetError(tbUsername, "Username is required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbUsername, "");
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                errorProvider1.SetError(tbPassword, "Password is required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbPassword, "");
            }

        }
    }
}
