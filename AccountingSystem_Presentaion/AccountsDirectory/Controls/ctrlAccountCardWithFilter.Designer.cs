namespace Ebda3Soft_AccountingSystem.AccountsDirectory.Controls
{
    partial class ctrlAccountCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnFindAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtFilterValue = new System.Windows.Forms.MaskedTextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.ctrlAccountCard1 = new Ebda3Soft_AccountingSystem.AccountsDirectory.Controls.ctrlAccountCard();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFindAccount);
            this.gbFilter.Controls.Add(this.btnAddAccount);
            this.gbFilter.Controls.Add(this.txtFilterValue);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbFilter.Location = new System.Drawing.Point(10, 9);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gbFilter.Size = new System.Drawing.Size(955, 106);
            this.gbFilter.TabIndex = 5;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "تصفية";
            // 
            // btnFindAccount
            // 
            this.btnFindAccount.AutoSize = true;
            this.btnFindAccount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnFindAccount.Location = new System.Drawing.Point(628, 39);
            this.btnFindAccount.Name = "btnFindAccount";
            this.btnFindAccount.Size = new System.Drawing.Size(153, 49);
            this.btnFindAccount.TabIndex = 6;
            this.btnFindAccount.Text = "بحث";
            this.btnFindAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.AutoSize = true;
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAddAccount.Location = new System.Drawing.Point(787, 39);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(153, 49);
            this.btnAddAccount.TabIndex = 7;
            this.btnAddAccount.Text = "إضافة حساب";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BeepOnError = true;
            this.txtFilterValue.Location = new System.Drawing.Point(226, 48);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(257, 39);
            this.txtFilterValue.TabIndex = 5;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "رقم الحساب",
            "اسم الحساب"});
            this.cbFilterBy.Location = new System.Drawing.Point(14, 48);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(206, 40);
            this.cbFilterBy.TabIndex = 4;
            // 
            // ctrlAccountCard1
            // 
            this.ctrlAccountCard1.Location = new System.Drawing.Point(10, 123);
            this.ctrlAccountCard1.Name = "ctrlAccountCard1";
            this.ctrlAccountCard1.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ctrlAccountCard1.Size = new System.Drawing.Size(958, 227);
            this.ctrlAccountCard1.TabIndex = 6;
            // 
            // ctrlAccountCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlAccountCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlAccountCardWithFilter";
            this.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Size = new System.Drawing.Size(978, 359);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnFindAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.MaskedTextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private ctrlAccountCard ctrlAccountCard1;
    }
}
