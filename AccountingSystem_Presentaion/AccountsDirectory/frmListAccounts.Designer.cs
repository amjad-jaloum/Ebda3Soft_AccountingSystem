using System.Windows.Forms;

namespace Ebda3Soft_AccountingSystem.BasicData
{
    partial class frmListAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.pbAccountIcon = new System.Windows.Forms.PictureBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.cmsAccountMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlpMainHeader = new System.Windows.Forms.TableLayoutPanel();
            this.MainHeaderPanel = new System.Windows.Forms.Panel();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnAddNewAccount = new System.Windows.Forms.Button();
            this.tplMainFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.plMainfooterLable = new System.Windows.Forms.Panel();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAccountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountIcon)).BeginInit();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.cmsAccountMenu.SuspendLayout();
            this.tlpMainHeader.SuspendLayout();
            this.MainHeaderPanel.SuspendLayout();
            this.tplMainFooter.SuspendLayout();
            this.plMainfooterLable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpForm
            // 
            this.tlpForm.ColumnCount = 2;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpForm.Controls.Add(this.pbAccountIcon, 1, 0);
            this.tlpForm.Controls.Add(this.tlpMain, 0, 0);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 1;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.Size = new System.Drawing.Size(1085, 637);
            this.tlpForm.TabIndex = 1;
            // 
            // pbAccountIcon
            // 
            this.pbAccountIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAccountIcon.Location = new System.Drawing.Point(3, 3);
            this.pbAccountIcon.Name = "pbAccountIcon";
            this.pbAccountIcon.Size = new System.Drawing.Size(174, 631);
            this.pbAccountIcon.TabIndex = 1;
            this.pbAccountIcon.TabStop = false;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.dgvAccounts, 0, 1);
            this.tlpMain.Controls.Add(this.tlpMainHeader, 0, 0);
            this.tlpMain.Controls.Add(this.tplMainFooter, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(183, 3);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(899, 631);
            this.tlpMain.TabIndex = 0;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.ContextMenuStrip = this.cmsAccountMenu;
            this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccounts.Location = new System.Drawing.Point(3, 63);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(893, 505);
            this.dgvAccounts.TabIndex = 1;
            // 
            // cmsAccountMenu
            // 
            this.cmsAccountMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAccountInfoToolStripMenuItem,
            this.editAccountToolStripMenuItem,
            this.deleteAccountToolStripMenuItem});
            this.cmsAccountMenu.Name = "cmsAccountMenu";
            this.cmsAccountMenu.Size = new System.Drawing.Size(176, 70);
            // 
            // tlpMainHeader
            // 
            this.tlpMainHeader.ColumnCount = 2;
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpMainHeader.Controls.Add(this.MainHeaderPanel, 0, 0);
            this.tlpMainHeader.Controls.Add(this.btnAddNewAccount, 1, 0);
            this.tlpMainHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpMainHeader.Name = "tlpMainHeader";
            this.tlpMainHeader.RowCount = 1;
            this.tlpMainHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainHeader.Size = new System.Drawing.Size(893, 54);
            this.tlpMainHeader.TabIndex = 2;
            // 
            // MainHeaderPanel
            // 
            this.MainHeaderPanel.Controls.Add(this.txtFilterValue);
            this.MainHeaderPanel.Controls.Add(this.cbFilterBy);
            this.MainHeaderPanel.Controls.Add(this.lblFilter);
            this.MainHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainHeaderPanel.Location = new System.Drawing.Point(183, 3);
            this.MainHeaderPanel.Name = "MainHeaderPanel";
            this.MainHeaderPanel.Size = new System.Drawing.Size(707, 48);
            this.MainHeaderPanel.TabIndex = 0;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(268, 15);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(200, 20);
            this.txtFilterValue.TabIndex = 0;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Account ID",
            "Account Name",
            "Type"});
            this.cbFilterBy.Location = new System.Drawing.Point(478, 15);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(140, 21);
            this.cbFilterBy.TabIndex = 1;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(628, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(64, 13);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "تصفية حسب:";
            // 
            // btnAddNewAccount
            // 
            this.btnAddNewAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewAccount.Location = new System.Drawing.Point(3, 3);
            this.btnAddNewAccount.Name = "btnAddNewAccount";
            this.btnAddNewAccount.Size = new System.Drawing.Size(174, 48);
            this.btnAddNewAccount.TabIndex = 1;
            this.btnAddNewAccount.Text = "إضافة حساب جديد";
            this.btnAddNewAccount.UseVisualStyleBackColor = true;
            this.btnAddNewAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // tplMainFooter
            // 
            this.tplMainFooter.ColumnCount = 2;
            this.tplMainFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tplMainFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tplMainFooter.Controls.Add(this.btnClose, 1, 0);
            this.tplMainFooter.Controls.Add(this.plMainfooterLable, 0, 0);
            this.tplMainFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplMainFooter.Location = new System.Drawing.Point(3, 574);
            this.tplMainFooter.Name = "tplMainFooter";
            this.tplMainFooter.RowCount = 1;
            this.tplMainFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplMainFooter.Size = new System.Drawing.Size(893, 54);
            this.tplMainFooter.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(262, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // plMainfooterLable
            // 
            this.plMainfooterLable.Controls.Add(this.lblRecordsCount);
            this.plMainfooterLable.Controls.Add(this.lblRecordsNumber);
            this.plMainfooterLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMainfooterLable.Location = new System.Drawing.Point(271, 3);
            this.plMainfooterLable.Name = "plMainfooterLable";
            this.plMainfooterLable.Size = new System.Drawing.Size(619, 48);
            this.plMainfooterLable.TabIndex = 1;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Location = new System.Drawing.Point(506, 18);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(13, 13);
            this.lblRecordsCount.TabIndex = 0;
            this.lblRecordsCount.Text = "0";
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblRecordsNumber.Location = new System.Drawing.Point(525, 18);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(79, 13);
            this.lblRecordsNumber.TabIndex = 1;
            this.lblRecordsNumber.Text = "عدد السجلات:";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // editAccountToolStripMenuItem
            // 
            this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
            this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.editAccountToolStripMenuItem.Text = "Edit Account";
            this.editAccountToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // showAccountInfoToolStripMenuItem
            // 
            this.showAccountInfoToolStripMenuItem.Name = "showAccountInfoToolStripMenuItem";
            this.showAccountInfoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.showAccountInfoToolStripMenuItem.Text = "Show Account Info";
            this.showAccountInfoToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // frmListAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 637);
            this.Controls.Add(this.tlpForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListAccounts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الحسابات";
            this.Load += new System.EventHandler(this.frmListAccounts_Load);
            this.tlpForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountIcon)).EndInit();
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.cmsAccountMenu.ResumeLayout(false);
            this.tlpMainHeader.ResumeLayout(false);
            this.MainHeaderPanel.ResumeLayout(false);
            this.MainHeaderPanel.PerformLayout();
            this.tplMainFooter.ResumeLayout(false);
            this.plMainfooterLable.ResumeLayout(false);
            this.plMainfooterLable.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        // Layout Containers
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpMainHeader;
        private System.Windows.Forms.TableLayoutPanel tplMainFooter;
        private System.Windows.Forms.Panel MainHeaderPanel;
        private System.Windows.Forms.Panel plMainfooterLable;

        // Controls
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnAddNewAccount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.PictureBox pbAccountIcon;

        // Context Menu (Right Click)
        private System.Windows.Forms.ContextMenuStrip cmsAccountMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLedgerToolStripMenuItem;
        private ToolStripMenuItem showAccountInfoToolStripMenuItem;
        private ToolStripMenuItem editAccountToolStripMenuItem;
        private ToolStripMenuItem deleteAccountToolStripMenuItem;
    }
}