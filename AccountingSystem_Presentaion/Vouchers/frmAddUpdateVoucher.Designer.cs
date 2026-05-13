using System.Windows.Forms;

namespace Ebda3Soft_AccountingSystem.AccountsDirectory
{
    partial class frmAddUpdateVoucher
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
            this.tcVoucherInfo = new System.Windows.Forms.TabControl();
            this.tpAccountInfo = new System.Windows.Forms.TabPage();
            this.ctrlAccountCardWithFilter1 = new Ebda3Soft_AccountingSystem.AccountsDirectory.Controls.ctrlAccountCardWithFilter();
            this.btnNextTab = new System.Windows.Forms.Button();
            this.tpVoucherDetails = new System.Windows.Forms.TabPage();
            this.gbVoucherDetails = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rbPayment = new System.Windows.Forms.RadioButton();
            this.rbReceipt = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVoucherId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcVoucherInfo.SuspendLayout();
            this.tpAccountInfo.SuspendLayout();
            this.tpVoucherDetails.SuspendLayout();
            this.gbVoucherDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcVoucherInfo
            // 
            this.tcVoucherInfo.Controls.Add(this.tpAccountInfo);
            this.tcVoucherInfo.Controls.Add(this.tpVoucherDetails);
            this.tcVoucherInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcVoucherInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcVoucherInfo.Location = new System.Drawing.Point(0, 0);
            this.tcVoucherInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tcVoucherInfo.Name = "tcVoucherInfo";
            this.tcVoucherInfo.RightToLeftLayout = true;
            this.tcVoucherInfo.SelectedIndex = 0;
            this.tcVoucherInfo.Size = new System.Drawing.Size(1095, 470);
            this.tcVoucherInfo.TabIndex = 0;
            // 
            // tpAccountInfo
            // 
            this.tpAccountInfo.Controls.Add(this.ctrlAccountCardWithFilter1);
            this.tpAccountInfo.Controls.Add(this.btnNextTab);
            this.tpAccountInfo.Location = new System.Drawing.Point(4, 27);
            this.tpAccountInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tpAccountInfo.Name = "tpAccountInfo";
            this.tpAccountInfo.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tpAccountInfo.Size = new System.Drawing.Size(1087, 439);
            this.tpAccountInfo.TabIndex = 0;
            this.tpAccountInfo.Text = "بيانات الحساب";
            this.tpAccountInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlAccountCardWithFilter1
            // 
            this.ctrlAccountCardWithFilter1.FilterEnabled = true;
            this.ctrlAccountCardWithFilter1.Location = new System.Drawing.Point(59, 31);
            this.ctrlAccountCardWithFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlAccountCardWithFilter1.Name = "ctrlAccountCardWithFilter1";
            this.ctrlAccountCardWithFilter1.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ctrlAccountCardWithFilter1.ShowAddAccount = true;
            this.ctrlAccountCardWithFilter1.Size = new System.Drawing.Size(972, 319);
            this.ctrlAccountCardWithFilter1.TabIndex = 1;
            // 
            // btnNextTab
            // 
            this.btnNextTab.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNextTab.Location = new System.Drawing.Point(919, 354);
            this.btnNextTab.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(100, 29);
            this.btnNextTab.TabIndex = 0;
            this.btnNextTab.Text = "التالي";
            this.btnNextTab.UseVisualStyleBackColor = true;
            this.btnNextTab.Click += new System.EventHandler(this.btnNextTab_Click);
            // 
            // tpVoucherDetails
            // 
            this.tpVoucherDetails.Controls.Add(this.gbVoucherDetails);
            this.tpVoucherDetails.Controls.Add(this.btnSave);
            this.tpVoucherDetails.Controls.Add(this.btnClose);
            this.tpVoucherDetails.Location = new System.Drawing.Point(4, 27);
            this.tpVoucherDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tpVoucherDetails.Name = "tpVoucherDetails";
            this.tpVoucherDetails.Padding = new System.Windows.Forms.Padding(2);
            this.tpVoucherDetails.Size = new System.Drawing.Size(1087, 439);
            this.tpVoucherDetails.TabIndex = 1;
            this.tpVoucherDetails.Text = "تفاصيل السند";
            this.tpVoucherDetails.UseVisualStyleBackColor = true;
            // 
            // gbVoucherDetails
            // 
            this.gbVoucherDetails.Controls.Add(this.txtNotes);
            this.gbVoucherDetails.Controls.Add(this.label5);
            this.gbVoucherDetails.Controls.Add(this.dtpVoucherDate);
            this.gbVoucherDetails.Controls.Add(this.label4);
            this.gbVoucherDetails.Controls.Add(this.rbPayment);
            this.gbVoucherDetails.Controls.Add(this.rbReceipt);
            this.gbVoucherDetails.Controls.Add(this.label3);
            this.gbVoucherDetails.Controls.Add(this.txtAmount);
            this.gbVoucherDetails.Controls.Add(this.label2);
            this.gbVoucherDetails.Controls.Add(this.lblVoucherId);
            this.gbVoucherDetails.Controls.Add(this.label1);
            this.gbVoucherDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbVoucherDetails.Location = new System.Drawing.Point(297, 35);
            this.gbVoucherDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gbVoucherDetails.Name = "gbVoucherDetails";
            this.gbVoucherDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gbVoucherDetails.Size = new System.Drawing.Size(500, 325);
            this.gbVoucherDetails.TabIndex = 0;
            this.gbVoucherDetails.TabStop = false;
            this.gbVoucherDetails.Text = "المعلومات المالية للسند";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(37, 202);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(335, 99);
            this.txtNotes.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "ملاحظات:";
            // 
            // dtpVoucherDate
            // 
            this.dtpVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVoucherDate.Location = new System.Drawing.Point(171, 162);
            this.dtpVoucherDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpVoucherDate.Name = "dtpVoucherDate";
            this.dtpVoucherDate.Size = new System.Drawing.Size(201, 29);
            this.dtpVoucherDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "التاريخ:";
            // 
            // rbPayment
            // 
            this.rbPayment.AutoSize = true;
            this.rbPayment.Location = new System.Drawing.Point(230, 120);
            this.rbPayment.Margin = new System.Windows.Forms.Padding(2);
            this.rbPayment.Name = "rbPayment";
            this.rbPayment.Size = new System.Drawing.Size(65, 25);
            this.rbPayment.TabIndex = 6;
            this.rbPayment.Text = "صرف";
            this.rbPayment.UseVisualStyleBackColor = true;
            // 
            // rbReceipt
            // 
            this.rbReceipt.AutoSize = true;
            this.rbReceipt.Checked = true;
            this.rbReceipt.Location = new System.Drawing.Point(310, 120);
            this.rbReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.rbReceipt.Name = "rbReceipt";
            this.rbReceipt.Size = new System.Drawing.Size(62, 25);
            this.rbReceipt.TabIndex = 5;
            this.rbReceipt.TabStop = true;
            this.rbReceipt.Text = "قبض";
            this.rbReceipt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "نوع السند:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(171, 80);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(201, 29);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "المبلغ:";
            // 
            // lblVoucherId
            // 
            this.lblVoucherId.AutoSize = true;
            this.lblVoucherId.Location = new System.Drawing.Point(330, 39);
            this.lblVoucherId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVoucherId.Name = "lblVoucherId";
            this.lblVoucherId.Size = new System.Drawing.Size(37, 21);
            this.lblVoucherId.TabIndex = 1;
            this.lblVoucherId.Text = "###";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم السند:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Location = new System.Drawing.Point(700, 373);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClose.Location = new System.Drawing.Point(1160, 369);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 470);
            this.Controls.Add(this.tcVoucherInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateVoucher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة / تعديل سند";
            this.Load += new System.EventHandler(this.frmAddUpdateVoucher_Load);
            this.tcVoucherInfo.ResumeLayout(false);
            this.tpAccountInfo.ResumeLayout(false);
            this.tpVoucherDetails.ResumeLayout(false);
            this.gbVoucherDetails.ResumeLayout(false);
            this.gbVoucherDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcVoucherInfo;
        private System.Windows.Forms.TabPage tpAccountInfo;
        private System.Windows.Forms.TabPage tpVoucherDetails;
        private System.Windows.Forms.Button btnNextTab;
        private System.Windows.Forms.GroupBox gbVoucherDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVoucherId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPayment;
        private System.Windows.Forms.RadioButton rbReceipt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpVoucherDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private AccountsDirectory.Controls.ctrlAccountCardWithFilter ctrlAccountCardWithFilter1;
    }
}