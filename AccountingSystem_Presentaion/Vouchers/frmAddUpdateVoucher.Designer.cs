using System.Windows.Forms;

namespace Ebda3Soft_AccountingSystem.Vouchers
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
            this.ctrlAccountCardWithFilter1 = new Ebda3Soft_AccountingSystem.AccountsDirectory.Controls.ctrlAccountCardWithFilter();
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
            this.tcVoucherInfo.Name = "tcVoucherInfo";
            this.tcVoucherInfo.RightToLeftLayout = true;
            this.tcVoucherInfo.SelectedIndex = 0;
            this.tcVoucherInfo.Size = new System.Drawing.Size(1615, 723);
            this.tcVoucherInfo.TabIndex = 0;
            // 
            // tpAccountInfo
            // 
            this.tpAccountInfo.Controls.Add(this.ctrlAccountCardWithFilter1);
            this.tpAccountInfo.Controls.Add(this.btnNextTab);
            this.tpAccountInfo.Location = new System.Drawing.Point(4, 35);
            this.tpAccountInfo.Name = "tpAccountInfo";
            this.tpAccountInfo.Padding = new System.Windows.Forms.Padding(10);
            this.tpAccountInfo.Size = new System.Drawing.Size(1607, 684);
            this.tpAccountInfo.TabIndex = 0;
            this.tpAccountInfo.Text = "بيانات الحساب";
            this.tpAccountInfo.UseVisualStyleBackColor = true;
            // 
            // btnNextTab
            // 
            this.btnNextTab.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNextTab.Location = new System.Drawing.Point(1324, 531);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(150, 45);
            this.btnNextTab.TabIndex = 0;
            this.btnNextTab.Text = "التالي";
            this.btnNextTab.UseVisualStyleBackColor = true;
            // 
            // tpVoucherDetails
            // 
            this.tpVoucherDetails.Controls.Add(this.gbVoucherDetails);
            this.tpVoucherDetails.Controls.Add(this.btnSave);
            this.tpVoucherDetails.Controls.Add(this.btnClose);
            this.tpVoucherDetails.Location = new System.Drawing.Point(4, 35);
            this.tpVoucherDetails.Name = "tpVoucherDetails";
            this.tpVoucherDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpVoucherDetails.Size = new System.Drawing.Size(1607, 684);
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
            this.gbVoucherDetails.Location = new System.Drawing.Point(445, 54);
            this.gbVoucherDetails.Name = "gbVoucherDetails";
            this.gbVoucherDetails.Size = new System.Drawing.Size(750, 500);
            this.gbVoucherDetails.TabIndex = 0;
            this.gbVoucherDetails.TabStop = false;
            this.gbVoucherDetails.Text = "المعلومات المالية للسند";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(56, 310);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(500, 150);
            this.txtNotes.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "ملاحظات:";
            // 
            // dtpVoucherDate
            // 
            this.dtpVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVoucherDate.Location = new System.Drawing.Point(256, 250);
            this.dtpVoucherDate.Name = "dtpVoucherDate";
            this.dtpVoucherDate.Size = new System.Drawing.Size(300, 39);
            this.dtpVoucherDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "التاريخ:";
            // 
            // rbPayment
            // 
            this.rbPayment.AutoSize = true;
            this.rbPayment.Location = new System.Drawing.Point(345, 185);
            this.rbPayment.Name = "rbPayment";
            this.rbPayment.Size = new System.Drawing.Size(93, 36);
            this.rbPayment.TabIndex = 6;
            this.rbPayment.Text = "صرف";
            this.rbPayment.UseVisualStyleBackColor = true;
            // 
            // rbReceipt
            // 
            this.rbReceipt.AutoSize = true;
            this.rbReceipt.Checked = true;
            this.rbReceipt.Location = new System.Drawing.Point(465, 185);
            this.rbReceipt.Name = "rbReceipt";
            this.rbReceipt.Size = new System.Drawing.Size(91, 36);
            this.rbReceipt.TabIndex = 5;
            this.rbReceipt.TabStop = true;
            this.rbReceipt.Text = "قبض";
            this.rbReceipt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "نوع السند:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(256, 123);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(300, 39);
            this.txtAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "المبلغ:";
            // 
            // lblVoucherId
            // 
            this.lblVoucherId.AutoSize = true;
            this.lblVoucherId.Location = new System.Drawing.Point(495, 60);
            this.lblVoucherId.Name = "lblVoucherId";
            this.lblVoucherId.Size = new System.Drawing.Size(56, 32);
            this.lblVoucherId.TabIndex = 1;
            this.lblVoucherId.Text = "###";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم السند:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Location = new System.Drawing.Point(1050, 574);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 45);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClose.Location = new System.Drawing.Point(1740, 567);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlAccountCardWithFilter1
            // 
            this.ctrlAccountCardWithFilter1.Location = new System.Drawing.Point(88, 48);
            this.ctrlAccountCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlAccountCardWithFilter1.Name = "ctrlAccountCardWithFilter1";
            this.ctrlAccountCardWithFilter1.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.ctrlAccountCardWithFilter1.Size = new System.Drawing.Size(1418, 476);
            this.ctrlAccountCardWithFilter1.TabIndex = 1;
            // 
            // frmAddUpdateVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 723);
            this.Controls.Add(this.tcVoucherInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateVoucher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة / تعديل سند";
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