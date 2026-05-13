using System.Windows.Forms;

namespace Ebda3Soft_AccountingSystem
{
    partial class frmAddUpdateAccount
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
            this.tcAccountInfo = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNextTab = new System.Windows.Forms.Button();
            this.tpAccountDetails = new System.Windows.Forms.TabPage();
            this.gbAccountDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccountId = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.labelAccountType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCardWithFilter1 = new Ebda3Soft_AccountingSystem.people.Controls.ctrlPersonCardWithFilter();
            this.tcAccountInfo.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpAccountDetails.SuspendLayout();
            this.gbAccountDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAccountInfo
            // 
            this.tcAccountInfo.Controls.Add(this.tpPersonInfo);
            this.tcAccountInfo.Controls.Add(this.tpAccountDetails);
            this.tcAccountInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAccountInfo.Location = new System.Drawing.Point(0, 0);
            this.tcAccountInfo.Name = "tcAccountInfo";
            this.tcAccountInfo.SelectedIndex = 0;
            this.tcAccountInfo.Size = new System.Drawing.Size(1069, 621);
            this.tcAccountInfo.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonInfo.Controls.Add(this.btnNextTab);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(10);
            this.tpPersonInfo.Size = new System.Drawing.Size(1061, 595);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNextTab
            // 
            this.btnNextTab.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNextTab.Location = new System.Drawing.Point(706, 482);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(150, 45);
            this.btnNextTab.TabIndex = 0;
            this.btnNextTab.Text = "Next";
            this.btnNextTab.UseVisualStyleBackColor = true;
            this.btnNextTab.Click += new System.EventHandler(this.btnNextTab_Click);
            // 
            // tpAccountDetails
            // 
            this.tpAccountDetails.Controls.Add(this.gbAccountDetails);
            this.tpAccountDetails.Controls.Add(this.btnSave);
            this.tpAccountDetails.Controls.Add(this.btnClose);
            this.tpAccountDetails.Location = new System.Drawing.Point(4, 22);
            this.tpAccountDetails.Name = "tpAccountDetails";
            this.tpAccountDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccountDetails.Size = new System.Drawing.Size(1061, 595);
            this.tpAccountDetails.TabIndex = 1;
            this.tpAccountDetails.Text = "Account Details";
            this.tpAccountDetails.UseVisualStyleBackColor = true;
            // 
            // gbAccountDetails
            // 
            this.gbAccountDetails.Controls.Add(this.label1);
            this.gbAccountDetails.Controls.Add(this.lblAccountId);
            this.gbAccountDetails.Controls.Add(this.txtAccountName);
            this.gbAccountDetails.Controls.Add(this.cbAccountType);
            this.gbAccountDetails.Controls.Add(this.labelAccountName);
            this.gbAccountDetails.Controls.Add(this.labelAccountType);
            this.gbAccountDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbAccountDetails.Location = new System.Drawing.Point(268, 126);
            this.gbAccountDetails.Name = "gbAccountDetails";
            this.gbAccountDetails.Size = new System.Drawing.Size(534, 273);
            this.gbAccountDetails.TabIndex = 0;
            this.gbAccountDetails.TabStop = false;
            this.gbAccountDetails.Text = "Account Financial Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "###";
            // 
            // lblAccountId
            // 
            this.lblAccountId.AutoSize = true;
            this.lblAccountId.Location = new System.Drawing.Point(45, 40);
            this.lblAccountId.Name = "lblAccountId";
            this.lblAccountId.Size = new System.Drawing.Size(88, 21);
            this.lblAccountId.TabIndex = 4;
            this.lblAccountId.Text = "Account ID:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(170, 93);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(280, 29);
            this.txtAccountName.TabIndex = 0;
            this.txtAccountName.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountName_Validating);
            // 
            // cbAccountType
            // 
            this.cbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Items.AddRange(new object[] {
            "Customer",
            "Supplier",
            "Employee",
            "ServiceProvider",
            "Partner"});
            this.cbAccountType.Location = new System.Drawing.Point(170, 161);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(280, 29);
            this.cbAccountType.TabIndex = 1;
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Location = new System.Drawing.Point(45, 96);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(115, 21);
            this.labelAccountName.TabIndex = 2;
            this.labelAccountName.Text = "Account Name:";
            // 
            // labelAccountType
            // 
            this.labelAccountType.AutoSize = true;
            this.labelAccountType.Location = new System.Drawing.Point(45, 164);
            this.labelAccountType.Name = "labelAccountType";
            this.labelAccountType.Size = new System.Drawing.Size(105, 21);
            this.labelAccountType.TabIndex = 3;
            this.labelAccountType.Text = "Account Type:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Location = new System.Drawing.Point(552, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClose.Location = new System.Drawing.Point(413, 437);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(174, 76);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(694, 401);
            this.ctrlPersonCardWithFilter1.TabIndex = 1;
            // 
            // frmAddUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 621);
            this.Controls.Add(this.tcAccountInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateAccount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Account";
            this.Activated += new System.EventHandler(this.frmAddUpdateAccount_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateAccount_Load);
            this.tcAccountInfo.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpAccountDetails.ResumeLayout(false);
            this.gbAccountDetails.ResumeLayout(false);
            this.gbAccountDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl tcAccountInfo;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpAccountDetails;
        private System.Windows.Forms.Button btnNextTab;
        private people.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.GroupBox gbAccountDetails;
        private System.Windows.Forms.Label lblAccountId;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.Label labelAccountType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Label label1;
    }
}