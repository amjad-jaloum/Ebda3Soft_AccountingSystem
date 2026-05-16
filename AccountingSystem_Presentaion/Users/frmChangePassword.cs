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

namespace Ebda3Soft_AccountingSystem.Users
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUser _User;

        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void _ResetDefualtValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            _User = clsUser.FindByUserID(_UserID);

            if (_User == null)
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("لم يتم العثور على مستخدم بالرقم التعريفي = " + _UserID,
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;
            }
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtCurrentPassword, "لا يمكن ترك حقل كلمة المرور الحالية فارغاً");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }

            if (_User.Password != txtCurrentPassword.Text.Trim())
            {
                errorProvider1.SetError(txtCurrentPassword, "كلمة المرور الحالية غير صحيحة!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtNewPassword, "لا يمكن ترك حقل كلمة المرور الجديدة فارغاً");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                errorProvider1.SetError(txtConfirmPassword, "تأكيد كلمة المرور غير متطابق مع كلمة المرور الجديدة!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول غير صالحة! قم بتمرير مؤشر الماوس فوق الأيقونة الحمراء لمشاهدة الخطأ",
                    "خطأ في التحقق من البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = txtNewPassword.Text;

            if (_User.Save())
            {
                MessageBox.Show("تم تغيير كلمة المرور بنجاح.",
                   "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("حدث خطأ، لم يتم تغيير كلمة المرور.",
                   "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
