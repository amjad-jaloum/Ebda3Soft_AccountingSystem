using System;

namespace Ebda3Soft_AccountingSystem.Users
{
    partial class frmListUsers
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMainHeader = new System.Windows.Forms.TableLayoutPanel();
            this.MainHeaderPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtFilterValue = new System.Windows.Forms.MaskedTextBox();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.tplMainFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.plMainfooterLable = new System.Windows.Forms.Panel();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpForm.SuspendLayout();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsUsers.SuspendLayout();
            this.tlpMainHeader.SuspendLayout();
            this.MainHeaderPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tplMainFooter.SuspendLayout();
            this.plMainfooterLable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpForm
            // 
            this.tlpForm.ColumnCount = 2;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tlpForm.Controls.Add(this.tlpMain, 0, 0);
            this.tlpForm.Controls.Add(this.pictureBox1, 1, 0);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 1;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tlpForm.Size = new System.Drawing.Size(1278, 545);
            this.tlpForm.TabIndex = 1;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.dgvUsers, 0, 1);
            this.tlpMain.Controls.Add(this.tlpMainHeader, 0, 0);
            this.tlpMain.Controls.Add(this.tplMainFooter, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(3, 3);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpMain.Size = new System.Drawing.Size(974, 539);
            this.tlpMain.TabIndex = 1;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.cmsUsers;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 85);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(968, 369);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentDoubleClick);
            // 
            // cmsUsers
            // 
            this.cmsUsers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.cmsUsers.Name = "cmsUsers";
            this.cmsUsers.Size = new System.Drawing.Size(225, 132);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordtoolStripMenuItem_Click);
            // 
            // tlpMainHeader
            // 
            this.tlpMainHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMainHeader.ColumnCount = 2;
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 303F));
            this.tlpMainHeader.Controls.Add(this.MainHeaderPanel, 0, 0);
            this.tlpMainHeader.Controls.Add(this.panel1, 1, 0);
            this.tlpMainHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpMainHeader.Name = "tlpMainHeader";
            this.tlpMainHeader.RowCount = 1;
            this.tlpMainHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpMainHeader.Size = new System.Drawing.Size(968, 75);
            this.tlpMainHeader.TabIndex = 1;
            // 
            // MainHeaderPanel
            // 
            this.MainHeaderPanel.Controls.Add(this.flowLayoutPanel1);
            this.MainHeaderPanel.Controls.Add(this.cbFilterBy);
            this.MainHeaderPanel.Controls.Add(this.label1);
            this.MainHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.MainHeaderPanel.Name = "MainHeaderPanel";
            this.MainHeaderPanel.Size = new System.Drawing.Size(659, 69);
            this.MainHeaderPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtFilterValue);
            this.flowLayoutPanel1.Controls.Add(this.cbIsActive);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(296, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(363, 42);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(3, 3);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(172, 26);
            this.txtFilterValue.TabIndex = 5;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbIsActive
            // 
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(181, 3);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(156, 28);
            this.cbIsActive.TabIndex = 4;
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "UserName",
            "Person ID",
            "Full Name",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(88, 31);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(200, 28);
            this.cbFilterBy.TabIndex = 1;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter by";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNewUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(668, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 69);
            this.panel1.TabIndex = 2;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNewUser.Location = new System.Drawing.Point(149, 0);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(148, 69);
            this.btnAddNewUser.TabIndex = 3;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tplMainFooter
            // 
            this.tplMainFooter.ColumnCount = 2;
            this.tplMainFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.07446F));
            this.tplMainFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.92554F));
            this.tplMainFooter.Controls.Add(this.btnClose, 1, 0);
            this.tplMainFooter.Controls.Add(this.plMainfooterLable, 0, 0);
            this.tplMainFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplMainFooter.Location = new System.Drawing.Point(3, 460);
            this.tplMainFooter.Name = "tplMainFooter";
            this.tplMainFooter.RowCount = 1;
            this.tplMainFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplMainFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tplMainFooter.Size = new System.Drawing.Size(968, 76);
            this.tplMainFooter.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(816, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 70);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // plMainfooterLable
            // 
            this.plMainfooterLable.Controls.Add(this.lblRecordsCount);
            this.plMainfooterLable.Controls.Add(this.lblRecordsNumber);
            this.plMainfooterLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMainfooterLable.Location = new System.Drawing.Point(3, 3);
            this.plMainfooterLable.Name = "plMainfooterLable";
            this.plMainfooterLable.Size = new System.Drawing.Size(807, 70);
            this.plMainfooterLable.TabIndex = 1;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(118, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Padding = new System.Windows.Forms.Padding(4, 5, 0, 5);
            this.lblRecordsCount.Size = new System.Drawing.Size(99, 70);
            this.lblRecordsCount.TabIndex = 3;
            this.lblRecordsCount.Text = "### ";
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsNumber.Location = new System.Drawing.Point(0, 0);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Padding = new System.Windows.Forms.Padding(4, 5, 0, 5);
            this.lblRecordsNumber.Size = new System.Drawing.Size(118, 70);
            this.lblRecordsNumber.TabIndex = 2;
            this.lblRecordsNumber.Text = "# Records: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Ebda3Soft_AccountingSystem.Properties.Resources.male;
            this.pictureBox1.Location = new System.Drawing.Point(1010, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.pictureBox1.Size = new System.Drawing.Size(238, 483);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 545);
            this.Controls.Add(this.tlpForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmListUsers_Load);
            this.tlpForm.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsUsers.ResumeLayout(false);
            this.tlpMainHeader.ResumeLayout(false);
            this.MainHeaderPanel.ResumeLayout(false);
            this.MainHeaderPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tplMainFooter.ResumeLayout(false);
            this.plMainfooterLable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TableLayoutPanel tlpMainHeader;
        private System.Windows.Forms.Panel MainHeaderPanel;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tplMainFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel plMainfooterLable;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtFilterValue;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}