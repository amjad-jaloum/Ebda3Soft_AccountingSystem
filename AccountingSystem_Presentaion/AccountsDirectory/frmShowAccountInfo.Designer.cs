namespace Ebda3Soft_AccountingSystem.BasicData.AccountsDirectory
{
    partial class frmShowAccountInfo
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
            this.ctrlAccountCard1 = new Ebda3Soft_AccountingSystem.AccountsDirectory.Controls.ctrlAccountCard();
            this.SuspendLayout();
            // 
            // ctrlAccountCard1
            // 
            this.ctrlAccountCard1.Location = new System.Drawing.Point(11, 11);
            this.ctrlAccountCard1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlAccountCard1.Name = "ctrlAccountCard1";
            this.ctrlAccountCard1.Size = new System.Drawing.Size(536, 136);
            this.ctrlAccountCard1.TabIndex = 0;
            // 
            // frmShowAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 158);
            this.Controls.Add(this.ctrlAccountCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowAccountInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "frmShowAccountInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private Ebda3Soft_AccountingSystem.AccountsDirectory.Controls.ctrlAccountCard ctrlAccountCard1;
    }
}