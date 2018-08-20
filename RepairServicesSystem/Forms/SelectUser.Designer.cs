namespace RepairServicesSystem
{
    partial class SelectUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.DataViewUsers = new System.Windows.Forms.DataGridView();
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "First Name";
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(166, 60);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLastName.TabIndex = 31;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(53, 60);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxFirstName.TabIndex = 30;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(285, 58);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(96, 23);
            this.ButtonSearch.TabIndex = 65;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // DataViewUsers
            // 
            this.DataViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewUsers.Location = new System.Drawing.Point(51, 100);
            this.DataViewUsers.Name = "DataViewUsers";
            this.DataViewUsers.Size = new System.Drawing.Size(329, 347);
            this.DataViewUsers.TabIndex = 66;
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Location = new System.Drawing.Point(125, 469);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(96, 23);
            this.ButtonSelect.TabIndex = 67;
            this.ButtonSelect.Text = "Select";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(236, 469);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(96, 23);
            this.ButtonBack.TabIndex = 68;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // SelectUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 515);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonSelect);
            this.Controls.Add(this.DataViewUsers);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxLastName);
            this.Controls.Add(this.TextBoxFirstName);
            this.Name = "SelectUser";
            this.Text = "SelectUser";
            ((System.ComponentModel.ISupportInitialize)(this.DataViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.DataGridView DataViewUsers;
        private System.Windows.Forms.Button ButtonSelect;
        private System.Windows.Forms.Button ButtonBack;
    }
}