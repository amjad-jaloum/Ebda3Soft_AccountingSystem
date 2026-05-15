namespace Ebda3Soft_AccountingSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMainNavBar = new System.Windows.Forms.MenuStrip();
            this.BasicDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpertationsToolStripMenuItem_People = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VouchersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountStatusReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemsInventoryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCurrentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssUsernameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDatetimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msMainNavBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMainNavBar
            // 
            this.msMainNavBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.msMainNavBar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.msMainNavBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMainNavBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BasicDataToolStripMenuItem,
            this.OpertationsToolStripMenuItem_People,
            this.ReportsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.PeopleToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.msMainNavBar.Location = new System.Drawing.Point(0, 0);
            this.msMainNavBar.Name = "msMainNavBar";
            this.msMainNavBar.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.msMainNavBar.Size = new System.Drawing.Size(958, 26);
            this.msMainNavBar.TabIndex = 0;
            this.msMainNavBar.Text = "menuStrip1";
            // 
            // BasicDataToolStripMenuItem
            // 
            this.BasicDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.manageApplicationsToolStripMenuItem});
            this.BasicDataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BasicDataToolStripMenuItem.Name = "BasicDataToolStripMenuItem";
            this.BasicDataToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.BasicDataToolStripMenuItem.Text = "البيانات الأساسية";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 24);
            this.toolStripMenuItem2.Text = "دليل الحسابات";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.AccountsDirectorytoolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.manageApplicationsToolStripMenuItem.Text = "دليل الأصناف";
            this.manageApplicationsToolStripMenuItem.Click += new System.EventHandler(this.ItemsDirectoryToolStripMenuItem_Click);
            // 
            // OpertationsToolStripMenuItem_People
            // 
            this.OpertationsToolStripMenuItem_People.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InvoicesToolStripMenuItem,
            this.VouchersToolStripMenuItem});
            this.OpertationsToolStripMenuItem_People.Name = "OpertationsToolStripMenuItem_People";
            this.OpertationsToolStripMenuItem_People.Size = new System.Drawing.Size(127, 24);
            this.OpertationsToolStripMenuItem_People.Text = "واجهات العمليات";
            // 
            // InvoicesToolStripMenuItem
            // 
            this.InvoicesToolStripMenuItem.Name = "InvoicesToolStripMenuItem";
            this.InvoicesToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.InvoicesToolStripMenuItem.Text = "الفواتير (بيع / شراء)";
            this.InvoicesToolStripMenuItem.Click += new System.EventHandler(this.InvoicesToolStripMenuItem_Click);
            // 
            // VouchersToolStripMenuItem
            // 
            this.VouchersToolStripMenuItem.Name = "VouchersToolStripMenuItem";
            this.VouchersToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.VouchersToolStripMenuItem.Text = "السندات (قبض / صرف)";
            this.VouchersToolStripMenuItem.Click += new System.EventHandler(this.VouchersToolStripMenuItem_Click);
            // 
            // ReportsToolStripMenuItem
            // 
            this.ReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountStatusReportToolStripMenuItem,
            this.ItemsInventoryReportToolStripMenuItem});
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.ReportsToolStripMenuItem.Text = "واجهات التقارير";
            // 
            // AccountStatusReportToolStripMenuItem
            // 
            this.AccountStatusReportToolStripMenuItem.Name = "AccountStatusReportToolStripMenuItem";
            this.AccountStatusReportToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.AccountStatusReportToolStripMenuItem.Text = "تقرير كشف الحساب";
            this.AccountStatusReportToolStripMenuItem.Click += new System.EventHandler(this.AccountStatusReportToolStripMenuItem_Click);
            // 
            // ItemsInventoryReportToolStripMenuItem
            // 
            this.ItemsInventoryReportToolStripMenuItem.Name = "ItemsInventoryReportToolStripMenuItem";
            this.ItemsInventoryReportToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.ItemsInventoryReportToolStripMenuItem.Text = "تقرير جرد المخزن";
            this.ItemsInventoryReportToolStripMenuItem.Click += new System.EventHandler(this.ItemsInventoryReportToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.usersToolStripMenuItem.Text = "المستخدمين";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // PeopleToolStripMenuItem
            // 
            this.PeopleToolStripMenuItem.Name = "PeopleToolStripMenuItem";
            this.PeopleToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.PeopleToolStripMenuItem.Text = "الاشخاص";
            this.PeopleToolStripMenuItem.Click += new System.EventHandler(this.PeopleToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCurrentUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.accountToolStripMenuItem.Text = "اعدادات الحساب";
            // 
            // showCurrentUserToolStripMenuItem
            // 
            this.showCurrentUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.showCurrentUserToolStripMenuItem.Name = "showCurrentUserToolStripMenuItem";
            this.showCurrentUserToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.showCurrentUserToolStripMenuItem.Text = "معلومات المستخدم ";
            this.showCurrentUserToolStripMenuItem.Click += new System.EventHandler(this.showCurrentUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.changePasswordToolStripMenuItem.Text = "تغيير كلمة المرور";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.logoutToolStripMenuItem.Text = "تسجيل خروج";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUsernameLabel,
            this.tssUsername,
            this.tssDatetimeLabel,
            this.tssDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(958, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssUsernameLabel
            // 
            this.tssUsernameLabel.Name = "tssUsernameLabel";
            this.tssUsernameLabel.Size = new System.Drawing.Size(84, 17);
            this.tssUsernameLabel.Text = "اسم المستخدم: ";
            // 
            // tssUsername
            // 
            this.tssUsername.Name = "tssUsername";
            this.tssUsername.Size = new System.Drawing.Size(28, 17);
            this.tssUsername.Text = "###";
            // 
            // tssDatetimeLabel
            // 
            this.tssDatetimeLabel.Name = "tssDatetimeLabel";
            this.tssDatetimeLabel.Size = new System.Drawing.Size(83, 17);
            this.tssDatetimeLabel.Text = "التاريخ والوقت: ";
            // 
            // tssDateTime
            // 
            this.tssDateTime.Name = "tssDateTime";
            this.tssDateTime.Size = new System.Drawing.Size(28, 17);
            this.tssDateTime.Text = "###";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(40, 39, 40, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(958, 557);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(958, 583);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msMainNavBar);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainNavBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMainNavBar.ResumeLayout(false);
            this.msMainNavBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainNavBar;
        private System.Windows.Forms.ToolStripMenuItem BasicDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpertationsToolStripMenuItem_People;
        private System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCurrentUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem InvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VouchersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountStatusReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemsInventoryReportToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssUsernameLabel;
        private System.Windows.Forms.ToolStripStatusLabel tssUsername;
        private System.Windows.Forms.ToolStripStatusLabel tssDatetimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel tssDateTime;
        private System.Windows.Forms.ToolStripMenuItem PeopleToolStripMenuItem;
    }
}

