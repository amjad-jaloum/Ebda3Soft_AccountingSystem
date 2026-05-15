namespace Ebda3Soft_AccountingSystem
{
    partial class frmAddUpdateItem
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
            this.gbUnitSelection = new System.Windows.Forms.GroupBox();
            this.cbUnitTypes = new System.Windows.Forms.ComboBox();
            this.lblUnitType = new System.Windows.Forms.Label();
            this.gbItemInfo = new System.Windows.Forms.GroupBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemIDValue = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpForm.SuspendLayout();
            this.gbUnitSelection.SuspendLayout();
            this.gbItemInfo.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpForm
            // 
            this.tlpForm.ColumnCount = 1;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.Controls.Add(this.gbUnitSelection, 0, 1);
            this.tlpForm.Controls.Add(this.gbItemInfo, 0, 2);
            this.tlpForm.Controls.Add(this.tlpFooter, 0, 3);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.tlpForm.RowCount = 4;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpForm.Size = new System.Drawing.Size(750, 646);
            this.tlpForm.TabIndex = 0;
            // 
            // gbUnitSelection
            // 
            this.gbUnitSelection.Controls.Add(this.cbUnitTypes);
            this.gbUnitSelection.Controls.Add(this.lblUnitType);
            this.gbUnitSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUnitSelection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbUnitSelection.Location = new System.Drawing.Point(19, 51);
            this.gbUnitSelection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUnitSelection.Name = "gbUnitSelection";
            this.gbUnitSelection.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUnitSelection.Size = new System.Drawing.Size(712, 144);
            this.gbUnitSelection.TabIndex = 0;
            this.gbUnitSelection.TabStop = false;
            this.gbUnitSelection.Text = "تحديد وحدة القياس";
            // 
            // cbUnitTypes
            // 
            this.cbUnitTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnitTypes.FormattingEnabled = true;
            this.cbUnitTypes.Items.AddRange(new object[] {
            "كيلو",
            "جرام",
            "حبة",
            "كيس",
            "كرتون",
            "لتر",
            "جالون",
            "ربطة"});
            this.cbUnitTypes.Location = new System.Drawing.Point(60, 57);
            this.cbUnitTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbUnitTypes.Name = "cbUnitTypes";
            this.cbUnitTypes.Size = new System.Drawing.Size(418, 36);
            this.cbUnitTypes.TabIndex = 0;
            // 
            // lblUnitType
            // 
            this.lblUnitType.AutoSize = true;
            this.lblUnitType.Location = new System.Drawing.Point(540, 62);
            this.lblUnitType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitType.Name = "lblUnitType";
            this.lblUnitType.Size = new System.Drawing.Size(106, 28);
            this.lblUnitType.TabIndex = 1;
            this.lblUnitType.Text = "نوع الوحدة:";
            // 
            // gbItemInfo
            // 
            this.gbItemInfo.Controls.Add(this.txtItemName);
            this.gbItemInfo.Controls.Add(this.lblItemName);
            this.gbItemInfo.Controls.Add(this.lblItemIDValue);
            this.gbItemInfo.Controls.Add(this.lblItemID);
            this.gbItemInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbItemInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbItemInfo.Location = new System.Drawing.Point(19, 205);
            this.gbItemInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbItemInfo.Name = "gbItemInfo";
            this.gbItemInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbItemInfo.Size = new System.Drawing.Size(712, 329);
            this.gbItemInfo.TabIndex = 1;
            this.gbItemInfo.TabStop = false;
            this.gbItemInfo.Text = "بيانات الصنف الأساسية";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(60, 142);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(418, 34);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.Validating += new System.ComponentModel.CancelEventHandler(this.txtItemName_Validating);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(540, 146);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(116, 28);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "اسم الصنف:";
            // 
            // lblItemIDValue
            // 
            this.lblItemIDValue.AutoSize = true;
            this.lblItemIDValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemIDValue.Location = new System.Drawing.Point(420, 69);
            this.lblItemIDValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemIDValue.Name = "lblItemIDValue";
            this.lblItemIDValue.Size = new System.Drawing.Size(56, 28);
            this.lblItemIDValue.TabIndex = 2;
            this.lblItemIDValue.Text = "[???]";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(540, 69);
            this.lblItemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(110, 28);
            this.lblItemID.TabIndex = 3;
            this.lblItemID.Text = "رقم الصنف:";
            // 
            // tlpFooter
            // 
            this.tlpFooter.ColumnCount = 2;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.Controls.Add(this.btnSave, 0, 0);
            this.tlpFooter.Controls.Add(this.btnClose, 1, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFooter.Location = new System.Drawing.Point(19, 544);
            this.tlpFooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpFooter.Size = new System.Drawing.Size(712, 82);
            this.tlpFooter.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(360, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(348, 72);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(4, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(348, 72);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "إلغاء";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 646);
            this.Controls.Add(this.tlpForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة / تعديل صنف";
            this.Load += new System.EventHandler(this.frmAddEditItem_Load);
            this.tlpForm.ResumeLayout(false);
            this.gbUnitSelection.ResumeLayout(false);
            this.gbUnitSelection.PerformLayout();
            this.gbItemInfo.ResumeLayout(false);
            this.gbItemInfo.PerformLayout();
            this.tlpFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.GroupBox gbUnitSelection;
        private System.Windows.Forms.GroupBox gbItemInfo;
        private System.Windows.Forms.ComboBox cbUnitTypes;
        private System.Windows.Forms.Label lblUnitType;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemIDValue;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}