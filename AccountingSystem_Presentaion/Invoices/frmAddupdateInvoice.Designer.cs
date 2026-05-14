namespace Ebda3Soft_AccountingSystem.Invoices
{
    partial class frmAddupdateInvoice
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
            this.tcInvoiceInfo = new System.Windows.Forms.TabControl();
            this.tpAccountInfo = new System.Windows.Forms.TabPage();
            this.ctrlAccountCardWithFilter1 = new Ebda3Soft_AccountingSystem.AccountsDirectory.Controls.ctrlAccountCardWithFilter();
            this.tpInvoiceDetails = new System.Windows.Forms.TabPage();
            this.dgvInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.gbInvoiceHeader = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tcInvoiceInfo.SuspendLayout();
            this.tpAccountInfo.SuspendLayout();
            this.tpInvoiceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).BeginInit();
            this.gbInvoiceHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcInvoiceInfo
            // 
            this.tcInvoiceInfo.Controls.Add(this.tpAccountInfo);
            this.tcInvoiceInfo.Controls.Add(this.tpInvoiceDetails);
            this.tcInvoiceInfo.Location = new System.Drawing.Point(12, 12);
            this.tcInvoiceInfo.Name = "tcInvoiceInfo";
            this.tcInvoiceInfo.SelectedIndex = 0;
            this.tcInvoiceInfo.Size = new System.Drawing.Size(860, 552);
            this.tcInvoiceInfo.TabIndex = 6;
            // 
            // tpAccountInfo
            // 
            this.tpAccountInfo.Controls.Add(this.btnNext);
            this.tpAccountInfo.Controls.Add(this.ctrlAccountCardWithFilter1);
            this.tpAccountInfo.Location = new System.Drawing.Point(4, 22);
            this.tpAccountInfo.Name = "tpAccountInfo";
            this.tpAccountInfo.Size = new System.Drawing.Size(852, 524);
            this.tpAccountInfo.TabIndex = 0;
            this.tpAccountInfo.Text = "بيانات الحساب";
            // 
            // ctrlAccountCardWithFilter1
            // 
            this.ctrlAccountCardWithFilter1.FilterEnabled = true;
            this.ctrlAccountCardWithFilter1.Location = new System.Drawing.Point(97, 134);
            this.ctrlAccountCardWithFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlAccountCardWithFilter1.Name = "ctrlAccountCardWithFilter1";
            this.ctrlAccountCardWithFilter1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ctrlAccountCardWithFilter1.ShowAddAccount = true;
            this.ctrlAccountCardWithFilter1.Size = new System.Drawing.Size(652, 233);
            this.ctrlAccountCardWithFilter1.TabIndex = 0;
            // 
            // tpInvoiceDetails
            // 
            this.tpInvoiceDetails.Controls.Add(this.label2);
            this.tpInvoiceDetails.Controls.Add(this.label1);
            this.tpInvoiceDetails.Controls.Add(this.lblTotalAmount);
            this.tpInvoiceDetails.Controls.Add(this.txtNotes);
            this.tpInvoiceDetails.Controls.Add(this.dgvInvoiceDetails);
            this.tpInvoiceDetails.Controls.Add(this.gbInvoiceHeader);
            this.tpInvoiceDetails.Controls.Add(this.btnAddItem);
            this.tpInvoiceDetails.Controls.Add(this.btnRemoveItem);
            this.tpInvoiceDetails.Location = new System.Drawing.Point(4, 22);
            this.tpInvoiceDetails.Name = "tpInvoiceDetails";
            this.tpInvoiceDetails.Size = new System.Drawing.Size(852, 526);
            this.tpInvoiceDetails.TabIndex = 1;
            this.tpInvoiceDetails.Text = "تفاصيل الفاتورة";
            // 
            // dgvInvoiceDetails
            // 
            this.dgvInvoiceDetails.AllowUserToAddRows = false;
            this.dgvInvoiceDetails.AllowUserToDeleteRows = false;
            this.dgvInvoiceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetails.Location = new System.Drawing.Point(15, 118);
            this.dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            this.dgvInvoiceDetails.ReadOnly = true;
            this.dgvInvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceDetails.Size = new System.Drawing.Size(820, 338);
            this.dgvInvoiceDetails.TabIndex = 0;
            // 
            // gbInvoiceHeader
            // 
            this.gbInvoiceHeader.Controls.Add(this.cbPaymentMethod);
            this.gbInvoiceHeader.Controls.Add(this.dtpInvoiceDate);
            this.gbInvoiceHeader.Location = new System.Drawing.Point(15, 15);
            this.gbInvoiceHeader.Name = "gbInvoiceHeader";
            this.gbInvoiceHeader.Size = new System.Drawing.Size(820, 61);
            this.gbInvoiceHeader.TabIndex = 1;
            this.gbInvoiceHeader.TabStop = false;
            this.gbInvoiceHeader.Text = "معلومات الفاتورة العامة";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmount.Location = new System.Drawing.Point(707, 496);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(45, 19);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "0.00";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "نقداً (Cash)",
            "آجل (Credit)"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(544, 27);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(270, 21);
            this.cbPaymentMethod.TabIndex = 1;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Location = new System.Drawing.Point(268, 27);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(270, 20);
            this.dtpInvoiceDate.TabIndex = 2;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(15, 462);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(733, 20);
            this.txtNotes.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(725, 82);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(110, 30);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "إضافة صنف";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(609, 82);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(110, 30);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "حذف صنف";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(750, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ الفاتورة";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(620, 570);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(758, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "الاجمالي:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(619, 372);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 40);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "التالي";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(754, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "الملاحظات:";
            // 
            // frmAddupdateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 624);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcInvoiceInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddupdateInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة / تعديل فاتورة";
            this.tcInvoiceInfo.ResumeLayout(false);
            this.tpAccountInfo.ResumeLayout(false);
            this.tpInvoiceDetails.ResumeLayout(false);
            this.tpInvoiceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).EndInit();
            this.gbInvoiceHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcInvoiceInfo;
        private System.Windows.Forms.TabPage tpAccountInfo;
        private System.Windows.Forms.TabPage tpInvoiceDetails;
        private System.Windows.Forms.DataGridView dgvInvoiceDetails;
        private System.Windows.Forms.GroupBox gbInvoiceHeader;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private Ebda3Soft_AccountingSystem.AccountsDirectory.Controls.ctrlAccountCardWithFilter ctrlAccountCardWithFilter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblInvoiceId; // أضفه إذا لم يكن موجوداً لعرض رقم الفاتورة
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
    }

}