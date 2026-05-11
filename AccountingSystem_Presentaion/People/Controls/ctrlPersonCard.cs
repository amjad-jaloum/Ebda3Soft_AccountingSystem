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
using Ebda3Soft_AccountingSystem.Properties;

namespace Ebda3Soft_AccountingSystem.people.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;

        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        private void _FillPersonInfo()
        {
            lblPersonID.Text = _Person.PersonID.ToString();
            _PersonID = _Person.PersonID;
            lblName.Text = _Person.FullName;
            lblGender.Text = Convert.ToBoolean(_Person.Gender) ? "Female" : "Male";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            pbPersonImage.Image = GetDefaultImage();
        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblName.Text = "[????]";
            pbPersonImage.Image = Resources.male;
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
        }

        private Image GetDefaultImage()
        {
            return Convert.ToBoolean(_Person.Gender) ? Resources.female : Resources.male;
        }
        public void ctrlShowPersonDetails_Load(object sender, EventArgs e)
        {
            LoadPersonInfo(_PersonID);
        }

        internal void FilterFocus()
        {
            throw new NotImplementedException();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(_Person == null)
            {
                MessageBox.Show("No Person Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAddUpdatePerson frmAddAndUpdate = new frmAddUpdatePerson(_Person.PersonID);
            frmAddAndUpdate.ShowDialog();

            LoadPersonInfo(_PersonID);
        }
    }
}
