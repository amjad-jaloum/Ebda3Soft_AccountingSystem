using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _19___Project___DVLD.Global_Classes;
using AccountingSystem_Business;
using Ebda3Soft_AccountingSystem.Properties;

namespace Ebda3Soft_AccountingSystem.people
{
    public partial class frmAddUpdatePerson : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGender { Male = 0, Female = 1 };

        private enMode _Mode;
        private int _PersonID = -1;
        clsPerson _Person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                Text = "إضافة شخص جديد";
                _Person = new clsPerson();
            }
            else
            {
                Text = "تحديث بيانات الشخص";
            }

            //set default image for the person.
            if (rbMale.Checked)
                pbUserImage.Image = Resources.male;
            else
                pbUserImage.Image = Resources.female;

            tbFirstName.Text = "";
            tbSecondName.Text = "";
            tbThirdName.Text = "";
            tbLastName.Text = "";
            rbMale.Checked = true;
            tbPhone.Text = "";
            tbEmail.Text = "";
        }

        private void _LoadData()
        {

            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("لا يوجد شخص يحمل الرقم التعريفي = " + _PersonID, "الشخص غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the person was not found
            lblInsertedID.Text = _PersonID.ToString();
            tbFirstName.Text = _Person.FirstName;
            tbSecondName.Text = _Person.SecondName;
            tbThirdName.Text = _Person.ThirdName;
            tbLastName.Text = _Person.LastName;

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            tbPhone.Text = _Person.Phone;
            tbEmail.Text = _Person.Email;

        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            tbFirstName.Focus();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول غير صالحة! ضع مؤشر الماوس فوق الأيقونة الحمراء لمعرفة الخطأ.", "خطأ في التحقق من البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Person.FirstName = tbFirstName.Text.Trim();
            _Person.SecondName = tbSecondName.Text.Trim();
            _Person.ThirdName = tbThirdName.Text.Trim();
            _Person.LastName = tbLastName.Text.Trim();
            _Person.Phone = tbPhone.Text.Trim();

            if (rbMale.Checked)
                _Person.Gender = (short)enGender.Male;
            else
                _Person.Gender = (short)enGender.Female;

            _Person.Email = tbEmail.Text.Trim();

            if (_Person.Save())
            {
                lblInsertedID.Text = _Person.PersonID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                Text = "تحديث بيانات الشخص";

                MessageBox.Show("تم حفظ البيانات بنجاح.", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("خطأ: لم يتم حفظ البيانات بنجاح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            //change the defualt image to female incase there is no image set.
            if (pbUserImage.ImageLocation == null)
                pbUserImage.Image = Resources.female;
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            //change the defualt image to male incase there is no image set.
            if (pbUserImage.ImageLocation == null)
                pbUserImage.Image = Resources.male;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                epPersonForm.SetError(Temp, "هذا الحقل مطلوب!");
            }
            else
            {
                epPersonForm.SetError(Temp, null);
            }

        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (tbEmail.Text.Trim() == "")
            {
                ValidateEmptyTextBox(sender, e);
                return;
            }

            //validate email format
            if (!clsValidation.ValidateEmail(tbEmail.Text))
            {
                e.Cancel = true;
                epPersonForm.SetError(tbEmail, "صيغة البريد الإلكتروني غير صالحة!");
            }
            else
            {
                epPersonForm.SetError(tbEmail, null);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
