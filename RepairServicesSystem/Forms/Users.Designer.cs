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
            this.ButtonAddUser.Location = new System.Drawing.Point(599, 42);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(121, 28);
            this.ButtonAddUser.TabIndex = 0;
            this.ButtonAddUser.Text = "Add new user";
            this.ButtonAddUser.UseVisualStyleBackColor = true;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // ButtonEditUser
            // 
            this.ButtonEditUser.Location = new System.Drawing.Point(599, 76);
            this.ButtonEditUser.Name = "ButtonEditUser";
            this.ButtonEditUser.Size = new System.Drawing.Size(121, 28);
            this.ButtonEditUser.TabIndex = 1;
            this.ButtonEditUser.Text = "Edit user";
            this.ButtonEditUser.UseVisualStyleBackColor = true;
            this.ButtonEditUser.Click += new System.EventHandler(this.ButtonEditUser_Click);
            // 
            // ButtonFindUser
            // 
            this.ButtonFindUser.Location = new System.Drawing.Point(599, 110);
            this.ButtonFindUser.Name = "ButtonFindUser";
            this.ButtonFindUser.Size = new System.Drawing.Size(121, 28);
            this.ButtonFindUser.TabIndex = 2;
            this.ButtonFindUser.Text = "Find user";
            this.ButtonFindUser.UseVisualStyleBackColor = true;
            this.ButtonFindUser.Click += new System.EventHandler(this.ButtonFindUser_Click);
            // 
            // DataViewUsers
            // 
            this.DataViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewUsers.Location = new System.Drawing.Point(27, 42);
            this.DataViewUsers.Name = "DataViewUsers";
            this.DataViewUsers.Size = new System.Drawing.Size(544, 224);
            this.DataViewUsers.TabIndex = 3;
            // 
            // ButtonDeleteUser
            // 
            this.ButtonDeleteUser.Location = new System.Drawing.Point(599, 144);
            this.ButtonDeleteUser.Name = "ButtonDeleteUser";
            this.ButtonDeleteUser.Size = new System.Drawing.Size(121, 28);
            this.ButtonDeleteUser.TabIndex = 4;
            this.ButtonDeleteUser.Text = "Delete user";
            this.ButtonDeleteUser.UseVisualStyleBackColor = true;
            this.ButtonDeleteUser.Click += new System.EventHandler(this.ButtonDeleteUser_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(599, 238);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(121, 28);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 314);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonDeleteUser);
            this.Controls.Add(this.DataViewUsers);
            this.Controls.Add(this.ButtonFindUser);
            this.Controls.Add(this.ButtonEditUser);
            this.Controls.Add(this.ButtonAddUser);
            this.Name = "Users";
            this.Text = "AdminView";
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