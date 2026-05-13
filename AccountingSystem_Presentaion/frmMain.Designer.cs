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
            this.الفواتيربيعشراءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.السنداتقبضصرفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقريركشفالحسابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقريرجردالمخزنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.msMainNavBar.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
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
            this.msMainNavBar.Size = new System.Drawing.Size(1437, 38);
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
            this.BasicDataToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.BasicDataToolStripMenuItem.Text = "البيانات الأساسية";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(270, 38);
            this.toolStripMenuItem2.Text = "دليل الحسابات";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.AccountsDirectorytoolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.manageApplicationsToolStripMenuItem.Text = "دليل الأصناف";
            this.manageApplicationsToolStripMenuItem.Click += new System.EventHandler(this.ItemsDirectoryToolStripMenuItem_Click);
            // 
            // OpertationsToolStripMenuItem_People
            // 
            this.OpertationsToolStripMenuItem_People.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الفواتيربيعشراءToolStripMenuItem,
            this.السنداتقبضصرفToolStripMenuItem});
            this.OpertationsToolStripMenuItem_People.Name = "OpertationsToolStripMenuItem_People";
            this.OpertationsToolStripMenuItem_People.Size = new System.Drawing.Size(181, 34);
            this.OpertationsToolStripMenuItem_People.Text = "واجهات العمليات";
            // 
            // الفواتيربيعشراءToolStripMenuItem
            // 
            this.الفواتيربيعشراءToolStripMenuItem.Name = "الفواتيربيعشراءToolStripMenuItem";
            this.الفواتيربيعشراءToolStripMenuItem.Size = new System.Drawing.Size(328, 38);
            this.الفواتيربيعشراءToolStripMenuItem.Text = "الفواتير (بيع / شراء)";
            // 
            // السنداتقبضصرفToolStripMenuItem
            // 
            this.السنداتقبضصرفToolStripMenuItem.Name = "السنداتقبضصرفToolStripMenuItem";
            this.السنداتقبضصرفToolStripMenuItem.Size = new System.Drawing.Size(328, 38);
            this.السنداتقبضصرفToolStripMenuItem.Text = "السندات (قبض / صرف)";
            // 
            // ReportsToolStripMenuItem
            // 
            this.ReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تقريركشفالحسابToolStripMenuItem,
            this.تقريرجردالمخزنToolStripMenuItem});
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(166, 34);
            this.ReportsToolStripMenuItem.Text = "واجهات التقارير";
            // 
            // تقريركشفالحسابToolStripMenuItem
            // 
            this.تقريركشفالحسابToolStripMenuItem.Name = "تقريركشفالحسابToolStripMenuItem";
            this.تقريركشفالحسابToolStripMenuItem.Size = new System.Drawing.Size(294, 38);
            this.تقريركشفالحسابToolStripMenuItem.Text = "تقرير كشف الحساب";
            // 
            // تقريرجردالمخزنToolStripMenuItem
            // 
            this.تقريرجردالمخزنToolStripMenuItem.Name = "تقريرجردالمخزنToolStripMenuItem";
            this.تقريرجردالمخزنToolStripMenuItem.Size = new System.Drawing.Size(294, 38);
            this.تقريرجردالمخزنToolStripMenuItem.Text = "تقرير جرد المخزن";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(139, 34);
            this.usersToolStripMenuItem.Text = "المستخدمين";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // PeopleToolStripMenuItem
            // 
            this.PeopleToolStripMenuItem.Name = "PeopleToolStripMenuItem";
            this.PeopleToolStripMenuItem.Size = new System.Drawing.Size(114, 34);
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
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.accountToolStripMenuItem.Text = "اعدادات الحساب";
            // 
            // showCurrentUserToolStripMenuItem
            // 
            this.showCurrentUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.showCurrentUserToolStripMenuItem.Name = "showCurrentUserToolStripMenuItem";
            this.showCurrentUserToolStripMenuItem.Size = new System.Drawing.Size(299, 38);
            this.showCurrentUserToolStripMenuItem.Text = "معلومات المستخدم ";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(299, 38);
            this.changePasswordToolStripMenuItem.Text = "تغيير كلمة المرور";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(299, 38);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 865);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(21, 0, 2, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1437, 32);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssUsernameLabel
            // 
            this.tssUsernameLabel.Name = "tssUsernameLabel";
            this.tssUsernameLabel.Size = new System.Drawing.Size(131, 25);
            this.tssUsernameLabel.Text = "اسم المستخدم: ";
            // 
            // tssUsername
            // 
            this.tssUsername.Name = "tssUsername";
            this.tssUsername.Size = new System.Drawing.Size(45, 25);
            this.tssUsername.Text = "###";
            // 
            // tssDatetimeLabel
            // 
            this.tssDatetimeLabel.Name = "tssDatetimeLabel";
            this.tssDatetimeLabel.Size = new System.Drawing.Size(130, 25);
            this.tssDatetimeLabel.Text = "التاريخ والوقت: ";
            // 
            // tssDateTime
            // 
            this.tssDateTime.Name = "tssDateTime";
            this.tssDateTime.Size = new System.Drawing.Size(45, 25);
            this.tssDateTime.Text = "###";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1437, 859);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1437, 897);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msMainNavBar);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainNavBar;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
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
        private System.Windows.Forms.ToolStripMenuItem الفواتيربيعشراءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem السنداتقبضصرفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقريركشفالحسابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقريرجردالمخزنToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssUsernameLabel;
        private System.Windows.Forms.ToolStripStatusLabel tssUsername;
        private System.Windows.Forms.ToolStripStatusLabel tssDatetimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel tssDateTime;
        private System.Windows.Forms.ToolStripMenuItem PeopleToolStripMenuItem;
    }
}

