namespace RepairServicesSystem
{
    partial class Activities
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
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxStatus = new System.Windows.Forms.TextBox();
            this.TextBoxPersonelId = new System.Windows.Forms.TextBox();
            this.TextBoxRequestId = new System.Windows.Forms.TextBox();
            this.TextBoxActivityId = new System.Windows.Forms.TextBox();
            this.DataViewActivities = new System.Windows.Forms.DataGridView();
            this.ButtonView = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TextBoxActivityType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonSearch.Location = new System.Drawing.Point(608, 49);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(96, 26);
            this.ButtonSearch.TabIndex = 25;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Personel Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Request Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Activity Id";
            // 
            // TextBoxStatus
            // 
            this.TextBoxStatus.Location = new System.Drawing.Point(382, 53);
            this.TextBoxStatus.Name = "TextBoxStatus";
            this.TextBoxStatus.Size = new System.Drawing.Size(100, 20);
            this.TextBoxStatus.TabIndex = 20;
            // 
            // TextBoxPersonelId
            // 
            this.TextBoxPersonelId.Location = new System.Drawing.Point(269, 53);
            this.TextBoxPersonelId.Name = "TextBoxPersonelId";
            this.TextBoxPersonelId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPersonelId.TabIndex = 19;
            // 
            // TextBoxRequestId
            // 
            this.TextBoxRequestId.Location = new System.Drawing.Point(156, 53);
            this.TextBoxRequestId.Name = "TextBoxRequestId";
            this.TextBoxRequestId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRequestId.TabIndex = 18;
            // 
            // TextBoxActivityId
            // 
            this.TextBoxActivityId.Location = new System.Drawing.Point(43, 53);
            this.TextBoxActivityId.Name = "TextBoxActivityId";
            this.TextBoxActivityId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxActivityId.TabIndex = 17;
            // 
            // DataViewActivities
            // 
            this.DataViewActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewActivities.Location = new System.Drawing.Point(43, 83);
            this.DataViewActivities.Name = "DataViewActivities";
            this.DataViewActivities.Size = new System.Drawing.Size(552, 180);
            this.DataViewActivities.TabIndex = 26;
            // 
            // ButtonView
            // 
            this.ButtonView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonView.Location = new System.Drawing.Point(608, 175);
            this.ButtonView.Name = "ButtonView";
            this.ButtonView.Size = new System.Drawing.Size(96, 26);
            this.ButtonView.TabIndex = 30;
            this.ButtonView.Text = "View activity";
            this.ButtonView.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonEdit.Location = new System.Drawing.Point(608, 143);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(96, 26);
            this.ButtonEdit.TabIndex = 29;
            this.ButtonEdit.Text = "Edit activity";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonAdd.Location = new System.Drawing.Point(608, 111);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(96, 26);
            this.ButtonAdd.TabIndex = 27;
            this.ButtonAdd.Text = "Add activity";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TextBoxActivityType
            // 
            this.TextBoxActivityType.Location = new System.Drawing.Point(495, 53);
            this.TextBoxActivityType.Name = "TextBoxActivityType";
            this.TextBoxActivityType.Size = new System.Drawing.Size(100, 20);
            this.TextBoxActivityType.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Activity type";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(608, 237);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(96, 26);
            this.ButtonBack.TabIndex = 33;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // Activities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 304);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxActivityType);
            this.Controls.Add(this.ButtonView);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.DataViewActivities);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxStatus);
            this.Controls.Add(this.TextBoxPersonelId);
            this.Controls.Add(this.TextBoxRequestId);
            this.Controls.Add(this.TextBoxActivityId);
            this.Name = "Activities";
            this.Text = "Activities";
            ((System.ComponentModel.ISupportInitialize)(this.DataViewActivities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxStatus;
        private System.Windows.Forms.TextBox TextBoxPersonelId;
        private System.Windows.Forms.TextBox TextBoxRequestId;
        private System.Windows.Forms.TextBox TextBoxActivityId;
        private System.Windows.Forms.DataGridView DataViewActivities;
        private System.Windows.Forms.Button ButtonView;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox TextBoxActivityType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonBack;
    }
}