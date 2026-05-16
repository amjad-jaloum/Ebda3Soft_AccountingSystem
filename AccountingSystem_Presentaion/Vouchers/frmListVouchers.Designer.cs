namespace Ebda3Soft_AccountingSystem.AccountsDirectory
{
    partial class frmListVouchers
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
            this.pbVoucherIcon = new System.Windows.Forms.PictureBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvVouchers = new System.Windows.Forms.DataGridView();
            this.cmsVoucherMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMainHeader = new System.Windows.Forms.TableLayoutPanel();
            this.MainHeaderPanel = new System.Windows.Forms.Panel();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbVoucherType = new System.Windows.Forms.ComboBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnAddNewVoucher = new System.Windows.Forms.Button();
            this.tplMainFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.plMainfooterLable = new System.Windows.Forms.Panel();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoucherIcon)).BeginInit();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).BeginInit();
            this.cmsVoucherMenu.SuspendLayout();
            this.tlpMainHeader.SuspendLayout();
            this.MainHeaderPanel.SuspendLayout();
            this.tplMainFooter.SuspendLayout();
            this.plMainfooterLable.SuspendLayout();
            this.SuspendLayout();

            // 
            // tlpForm (Main Layout Splitter)
            // 
            this.tlpForm.ColumnCount = 2;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpForm.Controls.Add(this.pbVoucherIcon, 1, 0);
            this.tlpForm.Controls.Add(this.tlpMain, 0, 0);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 1;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.Size = new System.Drawing.Size(1069, 598);
            this.tlpForm.TabIndex = 1;

            // 
            // pbVoucherIcon
            // 
            this.pbVoucherIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbVoucherIcon.Location = new System.Drawing.Point(20, 20);
            this.pbVoucherIcon.Margin = new System.Windows.Forms.Padding(20);
            this.pbVoucherIcon.Name = "pbVoucherIcon";
            this.pbVoucherIcon.Size = new System.Drawing.Size(140, 558);
            this.pbVoucherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoucherIcon.TabIndex = 1;
            this.pbVoucherIcon.TabStop = false;

            // 
            // tlpMain (Inner Content Layout)
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.dgvVouchers, 0, 1);
            this.tlpMain.Controls.Add(this.tlpMainHeader, 0, 0);
            this.tlpMain.Controls.Add(this.tplMainFooter, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(183, 3);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.Size = new System.Drawing.Size(883, 592);
            this.tlpMain.TabIndex = 0;

            // 
            // dgvVouchers (Data Grid View for Vouchers)
            // 
            this.dgvVouchers.AllowUserToAddRows = false;
            this.dgvVouchers.AllowUserToDeleteRows = false;
            this.dgvVouchers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVouchers.BackgroundColor = System.Drawing.Color.White;
            this.dgvVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVouchers.ContextMenuStrip = this.cmsVoucherMenu;
            this.dgvVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVouchers.Location = new System.Drawing.Point(2, 62);
            this.dgvVouchers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVouchers.MultiSelect = false;
            this.dgvVouchers.Name = "dgvVouchers";
            this.dgvVouchers.ReadOnly = true;
            this.dgvVouchers.RowHeadersWidth = 62;
            this.dgvVouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVouchers.Size = new System.Drawing.Size(879, 468);
            this.dgvVouchers.TabIndex = 1;

            // 
            // cmsVoucherMenu (Context Menu Strip)
            // 
            this.cmsVoucherMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsVoucherMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
    this.editToolStripMenuItem,
    this.deleteToolStripMenuItem});
            this.cmsVoucherMenu.Name = "cmsVoucherMenu";
            this.cmsVoucherMenu.Size = new System.Drawing.Size(104, 48);

            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.editToolStripMenuItem.Text = "تعديل";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);

            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.deleteToolStripMenuItem.Text = "حذف";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);

            // 
            // tlpMainHeader (Header Area)
            // 
            this.tlpMainHeader.ColumnCount = 2;
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpMainHeader.Controls.Add(this.MainHeaderPanel, 0, 0);
            this.tlpMainHeader.Controls.Add(this.btnAddNewVoucher, 1, 0);
            this.tlpMainHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainHeader.Location = new System.Drawing.Point(2, 2);
            this.tlpMainHeader.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMainHeader.Name = "tlpMainHeader";
            this.tlpMainHeader.RowCount = 1;
            this.tlpMainHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainHeader.Size = new System.Drawing.Size(879, 56);
            this.tlpMainHeader.TabIndex = 2;

            // 
            // MainHeaderPanel (Filtering Components)
            // 
            this.MainHeaderPanel.Controls.Add(this.txtFilterValue);
            this.MainHeaderPanel.Controls.Add(this.cbVoucherType);
            this.MainHeaderPanel.Controls.Add(this.cbFilterBy);
            this.MainHeaderPanel.Controls.Add(this.lblFilter);
            this.MainHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainHeaderPanel.Location = new System.Drawing.Point(182, 2);
            this.MainHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainHeaderPanel.Name = "MainHeaderPanel";
            this.MainHeaderPanel.Size = new System.Drawing.Size(695, 52);
            this.MainHeaderPanel.TabIndex = 0;

            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(90, 15);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(200, 20);
            this.txtFilterValue.TabIndex = 0;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);

            // 
            // cbVoucherType (Voucher Type Filter: All, Receipt, Expenditure)
            // 
            this.cbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoucherType.Items.AddRange(new object[] {
    "الكل",
    "قبض",
    "صرف"});
            this.cbVoucherType.Location = new System.Drawing.Point(294, 15);
            this.cbVoucherType.Margin = new System.Windows.Forms.Padding(2);
            this.cbVoucherType.Name = "cbVoucherType";
            this.cbVoucherType.Size = new System.Drawing.Size(150, 21);
            this.cbVoucherType.TabIndex = 1;
            this.cbVoucherType.SelectedIndexChanged += new System.EventHandler(this.cbVoucherType_SelectedIndexChanged);

            // 
            // cbFilterBy (Field Selector Filter)
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Items.AddRange(new object[] {
    "لا شيء",
    "رقم السند",
    "اسم الحساب"});
            this.cbFilterBy.Location = new System.Drawing.Point(448, 15);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(140, 21);
            this.cbFilterBy.TabIndex = 2;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);

            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFilter.Location = new System.Drawing.Point(605, 15);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(75, 18);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "تصفية حسب:";

            // 
            // btnAddNewVoucher
            // 
            this.btnAddNewVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAddNewVoucher.Location = new System.Drawing.Point(2, 2);
            this.btnAddNewVoucher.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewVoucher.Name = "btnAddNewVoucher";
            this.btnAddNewVoucher.Size = new System.Drawing.Size(176, 52);
            this.btnAddNewVoucher.TabIndex = 1;
            this.btnAddNewVoucher.Text = "إضافة سند جديد";
            this.btnAddNewVoucher.Click += new System.EventHandler(this.btnAddVoucher_Click);

            // 
            // tplMainFooter (Footer Area)
            // 
            this.tplMainFooter.ColumnCount = 2;
            this.tplMainFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tplMainFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tplMainFooter.Controls.Add(this.btnClose, 1, 0);
            this.tplMainFooter.Controls.Add(this.plMainfooterLable, 0, 0);
            this.tplMainFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplMainFooter.Location = new System.Drawing.Point(2, 534);
            this.tplMainFooter.Margin = new System.Windows.Forms.Padding(2);
            this.tplMainFooter.Name = "tplMainFooter";
            this.tplMainFooter.RowCount = 1;
            this.tplMainFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tplMainFooter.Size = new System.Drawing.Size(879, 56);
            this.tplMainFooter.TabIndex = 3;

            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnClose.Location = new System.Drawing.Point(2, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(260, 52);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // plMainfooterLable
            // 
            this.plMainfooterLable.Controls.Add(this.lblRecordsCount);
            this.plMainfooterLable.Controls.Add(this.lblRecordsNumber);
            this.plMainfooterLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMainfooterLable.Location = new System.Drawing.Point(266, 2);
            this.plMainfooterLable.Margin = new System.Windows.Forms.Padding(2);
            this.plMainfooterLable.Name = "plMainfooterLable";
            this.plMainfooterLable.Size = new System.Drawing.Size(611, 52);
            this.plMainfooterLable.TabIndex = 1;

            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRecordsCount.Location = new System.Drawing.Point(499, 15);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(16, 18);
            this.lblRecordsCount.TabIndex = 0;
            this.lblRecordsCount.Text = "0";

            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRecordsNumber.Location = new System.Drawing.Point(521, 15);
            this.lblRecordsNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(74, 18);
            this.lblRecordsNumber.TabIndex = 1;
            this.lblRecordsNumber.Text = "عدد السندات:";

            // 
            // frmListVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 598);
            this.Controls.Add(this.tlpForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListVouchers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes; // Support for Arabic layout direction
            this.RightToLeftLayout = true; // Mirrors form controls and layout containers properly
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة السندات المالية";
            this.Load += new System.EventHandler(this.frmListVouchers_Load);
            this.tlpForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVoucherIcon)).EndInit();
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).EndInit();
            this.cmsVoucherMenu.ResumeLayout(false);
            this.tlpMainHeader.ResumeLayout(false);
            this.MainHeaderPanel.ResumeLayout(false);
            this.MainHeaderPanel.PerformLayout();
            this.tplMainFooter.ResumeLayout(false);
            this.plMainfooterLable.ResumeLayout(false);
            this.plMainfooterLable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.PictureBox pbVoucherIcon;
        private System.Windows.Forms.ContextMenuStrip cmsVoucherMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.DataGridView dgvVouchers;
        private System.Windows.Forms.TableLayoutPanel tlpMainHeader;
        private System.Windows.Forms.Panel MainHeaderPanel;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbVoucherType;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnAddNewVoucher;
        private System.Windows.Forms.TableLayoutPanel tplMainFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel plMainfooterLable;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label lblRecordsNumber;
    }
}