namespace Ebda3Soft_AccountingSystem.Reports
{
    partial class frmAccountStateReport
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
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAccountStatement = new System.Windows.Forms.DataGridView();
            this.gbAccountFilter = new System.Windows.Forms.GroupBox();
            this.ctrlAccountCardWithFilter1 = new Ebda3Soft_AccountingSystem.AccountsDirectory.Controls.ctrlAccountCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountStatement)).BeginInit();
            this.gbAccountFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblAccountBalance.ForeColor = System.Drawing.Color.Black;
            this.lblAccountBalance.Location = new System.Drawing.Point(135, 608);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(53, 23);
            this.lblAccountBalance.TabIndex = 7;
            this.lblAccountBalance.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 611);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "الرصيد الحالي:";
            // 
            // dgvAccountStatement
            // 
            this.dgvAccountStatement.AllowUserToAddRows = false;
            this.dgvAccountStatement.AllowUserToDeleteRows = false;
            this.dgvAccountStatement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountStatement.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccountStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountStatement.Location = new System.Drawing.Point(17, 319);
            this.dgvAccountStatement.Name = "dgvAccountStatement";
            this.dgvAccountStatement.ReadOnly = true;
            this.dgvAccountStatement.Size = new System.Drawing.Size(659, 271);
            this.dgvAccountStatement.TabIndex = 5;
            // 
            // gbAccountFilter
            // 
            this.gbAccountFilter.Controls.Add(this.ctrlAccountCardWithFilter1);
            this.gbAccountFilter.Location = new System.Drawing.Point(17, 31);
            this.gbAccountFilter.Name = "gbAccountFilter";
            this.gbAccountFilter.Size = new System.Drawing.Size(659, 282);
            this.gbAccountFilter.TabIndex = 4;
            this.gbAccountFilter.TabStop = false;
            this.gbAccountFilter.Text = "اختيار الحساب";
            // 
            // ctrlAccountCardWithFilter1
            // 
            this.ctrlAccountCardWithFilter1.AutoSize = true;
            this.ctrlAccountCardWithFilter1.FilterEnabled = true;
            this.ctrlAccountCardWithFilter1.Location = new System.Drawing.Point(5, 18);
            this.ctrlAccountCardWithFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlAccountCardWithFilter1.Name = "ctrlAccountCardWithFilter1";
            this.ctrlAccountCardWithFilter1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ctrlAccountCardWithFilter1.ShowAddAccount = false;
            this.ctrlAccountCardWithFilter1.Size = new System.Drawing.Size(654, 235);
            this.ctrlAccountCardWithFilter1.TabIndex = 0;
            this.ctrlAccountCardWithFilter1.OnAccountSelected += new System.Action<int>(this.ctrlAccountCardWithFilter1_OnAccountSelected);
            // 
            // frmAccountStateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 661);
            this.Controls.Add(this.lblAccountBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAccountStatement);
            this.Controls.Add(this.gbAccountFilter);
            this.Name = "frmAccountStateReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير حالة حساب";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountStatement)).EndInit();
            this.gbAccountFilter.ResumeLayout(false);
            this.gbAccountFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAccountStatement;
        private System.Windows.Forms.GroupBox gbAccountFilter;
        private AccountsDirectory.Controls.ctrlAccountCardWithFilter ctrlAccountCardWithFilter1;
    }
}