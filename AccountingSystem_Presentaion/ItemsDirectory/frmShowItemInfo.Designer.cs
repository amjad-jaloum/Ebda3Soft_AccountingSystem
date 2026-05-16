namespace Ebda3Soft_AccountingSystem.BasicData.ItemsDirectory
{
    partial class frmShowItemInfo
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
            this.ctrlItemCard1 = new Ebda3Soft_AccountingSystem.ItemsDirectory.Controls.ctrlItemCard();
            this.SuspendLayout();
            // 
            // ctrlItemCard1
            // 
            this.ctrlItemCard1.AutoSize = true;
            this.ctrlItemCard1.Location = new System.Drawing.Point(12, 12);
            this.ctrlItemCard1.Name = "ctrlItemCard1";
            this.ctrlItemCard1.Size = new System.Drawing.Size(439, 130);
            this.ctrlItemCard1.TabIndex = 0;
            // 
            // frmShowItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 177);
            this.Controls.Add(this.ctrlItemCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowItemInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "frmShowItemInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ebda3Soft_AccountingSystem.ItemsDirectory.Controls.ctrlItemCard ctrlItemCard1;
    }
}