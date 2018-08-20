namespace RepairServicesSystem
{
    partial class Users
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
            this.ButtonAddUser = new System.Windows.Forms.Button();
            this.ButtonEditUser = new System.Windows.Forms.Button();
            this.ButtonFindUser = new System.Windows.Forms.Button();
            this.DataViewUsers = new System.Windows.Forms.DataGridView();
            this.ButtonDeleteUser = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.Location = new System.Drawing.Point(799, 52);
            this.ButtonAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(161, 34);
            this.ButtonAddUser.TabIndex = 0;
            this.ButtonAddUser.Text = "Add new user";
            this.ButtonAddUser.UseVisualStyleBackColor = true;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // ButtonEditUser
            // 
            this.ButtonEditUser.Location = new System.Drawing.Point(799, 94);
            this.ButtonEditUser.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonEditUser.Name = "ButtonEditUser";
            this.ButtonEditUser.Size = new System.Drawing.Size(161, 34);
            this.ButtonEditUser.TabIndex = 1;
            this.ButtonEditUser.Text = "Edit user";
            this.ButtonEditUser.UseVisualStyleBackColor = true;
            this.ButtonEditUser.Click += new System.EventHandler(this.ButtonEditUser_Click);
            // 
            // ButtonFindUser
            // 
            this.ButtonFindUser.Location = new System.Drawing.Point(799, 135);
            this.ButtonFindUser.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonFindUser.Name = "ButtonFindUser";
            this.ButtonFindUser.Size = new System.Drawing.Size(161, 34);
            this.ButtonFindUser.TabIndex = 2;
            this.ButtonFindUser.Text = "Find user";
            this.ButtonFindUser.UseVisualStyleBackColor = true;
            this.ButtonFindUser.Click += new System.EventHandler(this.ButtonFindUser_Click);
            // 
            // DataViewUsers
            // 
            this.DataViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewUsers.Location = new System.Drawing.Point(36, 52);
            this.DataViewUsers.Margin = new System.Windows.Forms.Padding(4);
            this.DataViewUsers.Name = "DataViewUsers";
            this.DataViewUsers.Size = new System.Drawing.Size(725, 276);
            this.DataViewUsers.TabIndex = 3;
            this.DataViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewUsers_CellContentClick);
            // 
            // ButtonDeleteUser
            // 
            this.ButtonDeleteUser.Location = new System.Drawing.Point(799, 177);
            this.ButtonDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDeleteUser.Name = "ButtonDeleteUser";
            this.ButtonDeleteUser.Size = new System.Drawing.Size(161, 34);
            this.ButtonDeleteUser.TabIndex = 4;
            this.ButtonDeleteUser.Text = "Delete user";
            this.ButtonDeleteUser.UseVisualStyleBackColor = true;
            this.ButtonDeleteUser.Click += new System.EventHandler(this.ButtonDeleteUser_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(799, 293);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(161, 34);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 386);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonDeleteUser);
            this.Controls.Add(this.DataViewUsers);
            this.Controls.Add(this.ButtonFindUser);
            this.Controls.Add(this.ButtonEditUser);
            this.Controls.Add(this.ButtonAddUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Users";
            this.Text = "AdminView";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddUser;
        private System.Windows.Forms.Button ButtonEditUser;
        private System.Windows.Forms.Button ButtonFindUser;
        private System.Windows.Forms.DataGridView DataViewUsers;
        private System.Windows.Forms.Button ButtonDeleteUser;
        private System.Windows.Forms.Button ButtonBack;
    }
}