namespace Ebda3Soft_AccountingSystem.people.Controls
{
    partial class ctrlPersonCardWithFilter
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
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.txtFilterValue = new System.Windows.Forms.MaskedTextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.chxIsServiceProvider = new System.Windows.Forms.CheckBox();
            this.ctrlPersonCard1 = new Ebda3Soft_AccountingSystem.people.Controls.ctrlPersonCard();
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
            this.gbFilter.Controls.Add(this.btnFindPerson);
            this.gbFilter.Controls.Add(this.btnAddPerson);
            this.gbFilter.Controls.Add(this.txtFilterValue);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbFilter.Location = new System.Drawing.Point(7, 6);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gbFilter.Size = new System.Drawing.Size(673, 69);
            this.gbFilter.TabIndex = 5;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "الفلترة";
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.AutoSize = true;
            this.btnFindPerson.Location = new System.Drawing.Point(480, 29);
            this.btnFindPerson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(70, 32);
            this.btnFindPerson.TabIndex = 6;
            this.btnFindPerson.Text = "بحث";
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.AutoSize = true;
            this.btnAddPerson.Location = new System.Drawing.Point(554, 29);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(107, 32);
            this.btnAddPerson.TabIndex = 7;
            this.btnAddPerson.Text = "إضافة شخص";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BeepOnError = true;
            this.txtFilterValue.Location = new System.Drawing.Point(9, 32);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(257, 29);
            this.txtFilterValue.TabIndex = 5;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "الرقم التعريفي"});
            this.cbFilterBy.Location = new System.Drawing.Point(270, 32);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(206, 29);
            this.cbFilterBy.TabIndex = 4;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // chxIsServiceProvider
            // 
            this.chxIsServiceProvider.AutoSize = true;
            this.chxIsServiceProvider.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxIsServiceProvider.Location = new System.Drawing.Point(561, 356);
            this.chxIsServiceProvider.Name = "chxIsServiceProvider";
            this.chxIsServiceProvider.Size = new System.Drawing.Size(100, 24);
            this.chxIsServiceProvider.TabIndex = 8;
            this.chxIsServiceProvider.Text = "مقدم خدمة";
            this.chxIsServiceProvider.UseVisualStyleBackColor = true;
            this.chxIsServiceProvider.CheckedChanged += new System.EventHandler(this.chxIsServiceProvider_CheckedChanged);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(7, 80);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrlPersonCard1.Size = new System.Drawing.Size(675, 317);
            this.ctrlPersonCard1.TabIndex = 6;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chxIsServiceProvider);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.gbFilter);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ctrlPersonCardWithFilter";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(689, 403);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.MaskedTextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.CheckBox chxIsServiceProvider;
    }
}
