namespace Ebda3Soft_AccountingSystem.Invoices
{
    partial class frmShowInvoiceInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gbInvoiceHeader = new System.Windows.Forms.GroupBox();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPaymentValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTypeValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccountValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInvoiceIDValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbInvoiceHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(702, 610);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(576, 610);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 40);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "طباعة الفاتورة";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gbInvoiceHeader
            // 
            this.gbInvoiceHeader.Controls.Add(this.lblCreatedByValue);
            this.gbInvoiceHeader.Controls.Add(this.label6);
            this.gbInvoiceHeader.Controls.Add(this.lblPaymentValue);
            this.gbInvoiceHeader.Controls.Add(this.label5);
            this.gbInvoiceHeader.Controls.Add(this.lblTypeValue);
            this.gbInvoiceHeader.Controls.Add(this.label4);
            this.gbInvoiceHeader.Controls.Add(this.lblAccountValue);
            this.gbInvoiceHeader.Controls.Add(this.label3);
            this.gbInvoiceHeader.Controls.Add(this.lblDateValue);
            this.gbInvoiceHeader.Controls.Add(this.label2);
            this.gbInvoiceHeader.Controls.Add(this.lblInvoiceIDValue);
            this.gbInvoiceHeader.Controls.Add(this.label1);
            this.gbInvoiceHeader.Location = new System.Drawing.Point(12, 12);
            this.gbInvoiceHeader.Name = "gbInvoiceHeader";
            this.gbInvoiceHeader.Size = new System.Drawing.Size(810, 133);
            this.gbInvoiceHeader.TabIndex = 2;
            this.gbInvoiceHeader.TabStop = false;
            this.gbInvoiceHeader.Text = "بيانات الفاتورة العامة";
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedByValue.Location = new System.Drawing.Point(54, 94);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(44, 17);
            this.lblCreatedByValue.TabIndex = 11;
            this.lblCreatedByValue.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "بواسطة المستخدم:";
            // 
            // lblPaymentValue
            // 
            this.lblPaymentValue.AutoSize = true;
            this.lblPaymentValue.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaymentValue.Location = new System.Drawing.Point(54, 63);
            this.lblPaymentValue.Name = "lblPaymentValue";
            this.lblPaymentValue.Size = new System.Drawing.Size(44, 17);
            this.lblPaymentValue.TabIndex = 9;
            this.lblPaymentValue.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "طريقة الدفع:";
            // 
            // lblTypeValue
            // 
            this.lblTypeValue.AutoSize = true;
            this.lblTypeValue.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTypeValue.Location = new System.Drawing.Point(54, 34);
            this.lblTypeValue.Name = "lblTypeValue";
            this.lblTypeValue.Size = new System.Drawing.Size(44, 17);
            this.lblTypeValue.TabIndex = 7;
            this.lblTypeValue.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "نوع الفاتورة:";
            // 
            // lblAccountValue
            // 
            this.lblAccountValue.AutoSize = true;
            this.lblAccountValue.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccountValue.Location = new System.Drawing.Point(540, 94);
            this.lblAccountValue.Name = "lblAccountValue";
            this.lblAccountValue.Size = new System.Drawing.Size(44, 17);
            this.lblAccountValue.TabIndex = 5;
            this.lblAccountValue.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "اسم الحساب:";
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateValue.Location = new System.Drawing.Point(540, 63);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(44, 17);
            this.lblDateValue.TabIndex = 3;
            this.lblDateValue.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "تاريخ الفاتورة:";
            // 
            // lblInvoiceIDValue
            // 
            this.lblInvoiceIDValue.AutoSize = true;
            this.lblInvoiceIDValue.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceIDValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInvoiceIDValue.Location = new System.Drawing.Point(540, 34);
            this.lblInvoiceIDValue.Name = "lblInvoiceIDValue";
            this.lblInvoiceIDValue.Size = new System.Drawing.Size(44, 17);
            this.lblInvoiceIDValue.TabIndex = 1;
            this.lblInvoiceIDValue.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة:";
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.AllowUserToAddRows = false;
            this.dgvInvoiceItems.AllowUserToDeleteRows = false;
            this.dgvInvoiceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceItems.Location = new System.Drawing.Point(12, 151);
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.ReadOnly = true;
            this.dgvInvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceItems.Size = new System.Drawing.Size(810, 444);
            this.dgvInvoiceItems.TabIndex = 3;
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmountValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalAmountValue.Location = new System.Drawing.Point(159, 616);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(53, 23);
            this.lblTotalAmountValue.TabIndex = 4;
            this.lblTotalAmountValue.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(25, 619);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "إجمالي الفاتورة:";
            // 
            // frmShowInvoiceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 661);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalAmountValue);
            this.Controls.Add(this.dgvInvoiceItems);
            this.Controls.Add(this.gbInvoiceHeader);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowInvoiceInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الفاتورة";
            this.Load += new System.EventHandler(this.frmShowInvoiceInfo_Load);
            this.gbInvoiceHeader.ResumeLayout(false);
            this.gbInvoiceHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox gbInvoiceHeader;
        private System.Windows.Forms.Label lblInvoiceIDValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAccountValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPaymentValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTypeValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvInvoiceItems;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label label8;
    }
}