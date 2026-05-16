namespace Ebda3Soft_AccountingSystem
{
    partial class frmListItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListItems));
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.pbItemIcon = new System.Windows.Forms.PictureBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.cmsItemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showItemInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMainHeader = new System.Windows.Forms.TableLayoutPanel();
            this.MainHeaderPanel = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.tplMainFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.plMainfooterLable = new System.Windows.Forms.Panel();
            this.lblRowsCountValue = new System.Windows.Forms.Label();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemIcon)).BeginInit();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.cmsItemMenu.SuspendLayout();
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
            this.tlpForm.Controls.Add(this.pbItemIcon, 1, 0);
            this.tlpForm.Controls.Add(this.tlpMain, 0, 0);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 1;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.Size = new System.Drawing.Size(1069, 598);
            this.tlpForm.TabIndex = 1;
            // 
            // pbItemIcon
            // 
            this.pbItemIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbItemIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbItemIcon.Image")));
            this.pbItemIcon.Location = new System.Drawing.Point(20, 20);
            this.pbItemIcon.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.pbItemIcon.Name = "pbItemIcon";
            this.pbItemIcon.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.pbItemIcon.Size = new System.Drawing.Size(140, 558);
            this.pbItemIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemIcon.TabIndex = 1;
            this.pbItemIcon.TabStop = false;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.dgvItems, 0, 1);
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
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.ContextMenuStrip = this.cmsItemMenu;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(3, 63);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 62;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(877, 466);
            this.dgvItems.TabIndex = 1;
            // 
            // cmsItemMenu
            // 
            this.cmsItemMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsItemMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showItemInfoToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsItemMenu.Name = "cmsItemMenu";
            this.cmsItemMenu.Size = new System.Drawing.Size(128, 70);
            // 
            // showItemInfoToolStripMenuItem
            // 
            this.showItemInfoToolStripMenuItem.Name = "showItemInfoToolStripMenuItem";
            this.showItemInfoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.showItemInfoToolStripMenuItem.Text = "عرض التفاصيل";
            this.showItemInfoToolStripMenuItem.Click += new System.EventHandler(this.showItemInfoToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.editToolStripMenuItem.Text = "تعديل الصنف";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.deleteToolStripMenuItem.Text = "حذف الصنف";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tlpMainHeader
            // 
            this.tlpMainHeader.ColumnCount = 2;
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpMainHeader.Controls.Add(this.MainHeaderPanel, 0, 0);
            this.tlpMainHeader.Controls.Add(this.btnAddNewItem, 1, 0);
            this.tlpMainHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpMainHeader.Name = "tlpMainHeader";
            this.tlpMainHeader.RowCount = 1;
            this.tlpMainHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainHeader.Size = new System.Drawing.Size(877, 54);
            this.tlpMainHeader.TabIndex = 2;
            // 
            // MainHeaderPanel
            // 
            this.MainHeaderPanel.Controls.Add(this.txtSearch);
            this.MainHeaderPanel.Controls.Add(this.cbFilter);
            this.MainHeaderPanel.Controls.Add(this.lblFilter);
            this.MainHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainHeaderPanel.Location = new System.Drawing.Point(183, 3);
            this.MainHeaderPanel.Name = "MainHeaderPanel";
            this.MainHeaderPanel.Size = new System.Drawing.Size(691, 48);
            this.MainHeaderPanel.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(238, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Items.AddRange(new object[] {
            "لا شيء",
            "الرقم التعريفي",
            "اسم الصنف",
            "اسم الوحدة"});
            this.cbFilter.Location = new System.Drawing.Point(448, 15);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(140, 21);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(605, 15);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(75, 18);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "تصفية حسب:";
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewItem.Location = new System.Drawing.Point(3, 3);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(174, 48);
            this.btnAddNewItem.TabIndex = 1;
            this.btnAddNewItem.Text = "إضافة صنف جديد";
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // tplMainFooter
            // 
            this.tplMainFooter.ColumnCount = 2;
            this.tplMainFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tplMainFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tplMainFooter.Controls.Add(this.btnClose, 1, 0);
            this.tplMainFooter.Controls.Add(this.plMainfooterLable, 0, 0);
            this.tplMainFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplMainFooter.Location = new System.Drawing.Point(3, 535);
            this.tplMainFooter.Name = "tplMainFooter";
            this.tplMainFooter.RowCount = 1;
            this.tplMainFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplMainFooter.Size = new System.Drawing.Size(877, 54);
            this.tplMainFooter.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Windows.Forms.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(258, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // plMainfooterLable
            // 
            this.plMainfooterLable.Controls.Add(this.lblRowsCountValue);
            this.plMainfooterLable.Controls.Add(this.lblRecordsNumber);
            this.plMainfooterLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMainfooterLable.Location = new System.Drawing.Point(267, 3);
            this.plMainfooterLable.Name = "plMainfooterLable";
            this.plMainfooterLable.Size = new System.Drawing.Size(607, 48);
            this.plMainfooterLable.TabIndex = 1;
            // 
            // lblRowsCountValue
            // 
            this.lblRowsCountValue.AutoSize = true;
            this.lblRowsCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsCountValue.Location = new System.Drawing.Point(499, 15);
            this.lblRowsCountValue.Name = "lblRowsCountValue";
            this.lblRowsCountValue.Size = new System.Drawing.Size(16, 18);
            this.lblRowsCountValue.TabIndex = 0;
            this.lblRowsCountValue.Text = "0";
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsNumber.Location = new System.Drawing.Point(521, 15);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(79, 18);
            this.lblRecordsNumber.TabIndex = 1;
            this.lblRecordsNumber.Text = "عدد الأصناف:";
            // 
            // frmListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 598);
            this.Controls.Add(this.tlpForm);
            this.Name = "frmListItems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دليل الأصناف المخزنية";
            this.Load += new System.EventHandler(this.frmListItems_Load);
            this.tlpForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemIcon)).EndInit();
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.cmsItemMenu.ResumeLayout(false);
            this.tlpMainHeader.ResumeLayout(false);
            this.MainHeaderPanel.ResumeLayout(false);
            this.MainHeaderPanel.PerformLayout();
            this.tplMainFooter.ResumeLayout(false);
            this.plMainfooterLable.ResumeLayout(false);
            this.plMainfooterLable.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpMainHeader;
        private System.Windows.Forms.TableLayoutPanel tplMainFooter;
        private System.Windows.Forms.Panel MainHeaderPanel;
        private System.Windows.Forms.Panel plMainfooterLable;

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRowsCountValue;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.PictureBox pbItemIcon;

        private System.Windows.Forms.ContextMenuStrip cmsItemMenu;
        private System.Windows.Forms.ToolStripMenuItem showItemInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}