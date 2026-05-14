using Ebda3Soft_AccountingSystem.BasicData;

namespace Ebda3Soft_AccountingSystem.Invoices.InvoiceDetails
{
    partial class frmLisInvoiceDetails
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
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.pbDetailsIcon = new System.Windows.Forms.PictureBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.tplFooter = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFooterInfo = new System.Windows.Forms.Panel();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblItemsCountValue = new System.Windows.Forms.Label();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.lblInvoiceIDValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetailsIcon)).BeginInit();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).BeginInit();
            this.tplFooter.SuspendLayout();
            this.pnlFooterInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpForm
            // 
            this.tlpForm.ColumnCount = 2;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpForm.Controls.Add(this.pbDetailsIcon, 1, 0);
            this.tlpForm.Controls.Add(this.tlpMain, 0, 0);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 1;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.Size = new System.Drawing.Size(900, 543);
            this.tlpForm.TabIndex = 0;
            // 
            // pbDetailsIcon
            // 
            this.pbDetailsIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDetailsIcon.Location = new System.Drawing.Point(15, 16);
            this.pbDetailsIcon.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.pbDetailsIcon.Name = "pbDetailsIcon";
            this.pbDetailsIcon.Size = new System.Drawing.Size(135, 511);
            this.pbDetailsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDetailsIcon.TabIndex = 1;
            this.pbDetailsIcon.TabStop = false;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.dgvInvoiceDetails, 0, 1);
            this.tlpMain.Controls.Add(this.tplFooter, 0, 2);
            this.tlpMain.Controls.Add(this.panel1, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(167, 2);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpMain.Size = new System.Drawing.Size(731, 539);
            this.tlpMain.TabIndex = 0;
            // 
            // dgvInvoiceDetails
            // 
            this.dgvInvoiceDetails.AllowUserToAddRows = false;
            this.dgvInvoiceDetails.AllowUserToDeleteRows = false;
            this.dgvInvoiceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceDetails.Location = new System.Drawing.Point(2, 54);
            this.dgvInvoiceDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvInvoiceDetails.MultiSelect = false;
            this.dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            this.dgvInvoiceDetails.ReadOnly = true;
            this.dgvInvoiceDetails.RowHeadersWidth = 51;
            this.dgvInvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceDetails.Size = new System.Drawing.Size(727, 418);
            this.dgvInvoiceDetails.TabIndex = 1;
            // 
            // tplFooter
            // 
            this.tplFooter.ColumnCount = 2;
            this.tplFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tplFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tplFooter.Controls.Add(this.btnClose, 1, 0);
            this.tplFooter.Controls.Add(this.pnlFooterInfo, 0, 0);
            this.tplFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplFooter.Location = new System.Drawing.Point(2, 476);
            this.tplFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tplFooter.Name = "tplFooter";
            this.tplFooter.RowCount = 1;
            this.tplFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplFooter.Size = new System.Drawing.Size(727, 61);
            this.tplFooter.TabIndex = 3;
            // 
            // pnlFooterInfo
            // 
            this.pnlFooterInfo.Controls.Add(this.lblTotalAmountValue);
            this.pnlFooterInfo.Controls.Add(this.lblTotalAmount);
            this.pnlFooterInfo.Controls.Add(this.lblItemsCountValue);
            this.pnlFooterInfo.Controls.Add(this.lblItemsCount);
            this.pnlFooterInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooterInfo.Location = new System.Drawing.Point(184, 2);
            this.pnlFooterInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlFooterInfo.Name = "pnlFooterInfo";
            this.pnlFooterInfo.Size = new System.Drawing.Size(541, 57);
            this.pnlFooterInfo.TabIndex = 1;
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmountValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalAmountValue.Location = new System.Drawing.Point(15, 16);
            this.lblTotalAmountValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(44, 21);
            this.lblTotalAmountValue.TabIndex = 3;
            this.lblTotalAmountValue.Text = "0.00$";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.Location = new System.Drawing.Point(75, 16);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(99, 21);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "إجمالي المبلغ:";
            // 
            // lblItemsCountValue
            // 
            this.lblItemsCountValue.AutoSize = true;
            this.lblItemsCountValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblItemsCountValue.Location = new System.Drawing.Point(424, 16);
            this.lblItemsCountValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemsCountValue.Name = "lblItemsCountValue";
            this.lblItemsCountValue.Size = new System.Drawing.Size(15, 20);
            this.lblItemsCountValue.TabIndex = 1;
            this.lblItemsCountValue.Text = "0";
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.AutoSize = true;
            this.lblItemsCount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblItemsCount.Location = new System.Drawing.Point(443, 16);
            this.lblItemsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(93, 20);
            this.lblItemsCount.TabIndex = 0;
            this.lblItemsCount.Text = "عدد الاصناف:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInvoiceID);
            this.panel1.Controls.Add(this.lblInvoiceIDValue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 46);
            this.panel1.TabIndex = 5;
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInvoiceID.Location = new System.Drawing.Point(634, 11);
            this.lblInvoiceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(85, 20);
            this.lblInvoiceID.TabIndex = 10;
            this.lblInvoiceID.Text = "رقم الفاتورة:";
            // 
            // lblInvoiceIDValue
            // 
            this.lblInvoiceIDValue.AutoSize = true;
            this.lblInvoiceIDValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceIDValue.Location = new System.Drawing.Point(585, 11);
            this.lblInvoiceIDValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceIDValue.Name = "lblInvoiceIDValue";
            this.lblInvoiceIDValue.Size = new System.Drawing.Size(45, 20);
            this.lblInvoiceIDValue.TabIndex = 11;
            this.lblInvoiceIDValue.Text = "[???]";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Location = new System.Drawing.Point(2, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(178, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmLisInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 543);
            this.Controls.Add(this.tlpForm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLisInvoiceDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عرض تفاصيل الفاتورة";
            this.tlpForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDetailsIcon)).EndInit();
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).EndInit();
            this.tplFooter.ResumeLayout(false);
            this.pnlFooterInfo.ResumeLayout(false);
            this.pnlFooterInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.PictureBox pbDetailsIcon;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.DataGridView dgvInvoiceDetails;
        private System.Windows.Forms.TableLayoutPanel tplFooter;
        private System.Windows.Forms.Panel pnlFooterInfo;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblItemsCountValue;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label lblInvoiceIDValue;
        private System.Windows.Forms.Button btnClose;
    }
}