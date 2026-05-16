using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using _19___Project___DVLD;
using Ebda3Soft_AccountingSystem.AccountsDirectory;
using Ebda3Soft_AccountingSystem.BasicData;
using Ebda3Soft_AccountingSystem.Invoices;
using Ebda3Soft_AccountingSystem.people;
using Ebda3Soft_AccountingSystem.Reports;
using Ebda3Soft_AccountingSystem.Users;

namespace Ebda3Soft_AccountingSystem
{

    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();
            frm.ShowDialog();
        }

        private void PeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople frm = new frmListPeople();
            frm.ShowDialog();
        }

        private void AccountsDirectorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAccounts frm = new frmListAccounts();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tssDateTime.Text = DateTime.Now.ToShortDateString();
            tssUsername.Text = clsGlobal.CurrentUser.UserName;
        }

        private void ItemsDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListItems frm = new frmListItems();
            frm.ShowDialog();
        }

        private void VouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListVouchers frm = new frmListVouchers();
            frm.ShowDialog();
        }

        private void InvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInvoices frm = new frmListInvoices();
            frm.ShowDialog();
        }

        private void AccountStatusReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountStateReport frm = new frmAccountStateReport();
            frm.ShowDialog();
        }

        private void ItemsInventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventoryReport frm = new frmInventoryReport();
            frm.ShowDialog();
        }

        private void showCurrentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm  = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void tsmBackup_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // تهيئة إعدادات نافذة الحفظ
                saveFileDialog.Filter = "Backup Files (*.bak)|*.bak|All Files (*.*)|*.*";
                saveFileDialog.Title = "اختر مسار واسم ملف النسخة الاحتياطية";

                // اقتراح اسم افتراضي يحتوي على تاريخ اليوم ليكون منظماً
                saveFileDialog.FileName = "BusinessDB_Backup_" + DateTime.Now.ToString("yyyyMMdd");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string chosenPath = saveFileDialog.FileName;

                    // استدعاء البزنس لاير وتمرير المسار الذي اختاره المستخدم
                    if (clsBackup.Backup(chosenPath))
                    {
                        MessageBox.Show($"تم أخذ النسخة الاحتياطية بنجاح وحفظها في:\n {chosenPath}",
                                        "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("فشل أخذ النسخة الاحتياطية. تأكد من صلاحيات الكتابة في المسار المحدد أو تشغيل البرنامج كمسؤول.",
                                        "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tsmRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // تهيئة إعدادات نافذة فتح الملفات
                openFileDialog.Filter = "Backup Files (*.bak)|*.bak";
                openFileDialog.Title = "اختر ملف النسخة الاحتياطية لاستعادتها";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string chosenPath = openFileDialog.FileName;

                    // تنبيه تأكيدي حرج جداً لأن البيانات الحالية ستُحذف تماماً
                    string confirmMessage = "تحذير حرج: استعادة البيانات ستؤدي إلى مسح البيانات الحالية بالكامل واستبدالها بالنسخة المحددة.\n\nهل أنت متأكد من الاستمرار؟";

                    if (MessageBox.Show(confirmMessage, "تأكيد استبدال البيانات",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (clsBackup.Restore(chosenPath))
                        {
                            MessageBox.Show("تم استعادة قاعدة البيانات بنجاح، سيقوم النظام بالعمل الآن بالبيانات المسترجعة.",
                                            "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("فشل استعادة قاعدة البيانات. تأكد من أن الملف غير تالف وأن محرك SQL Server يمتلك صلاحية الوصول إليه.",
                                            "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
