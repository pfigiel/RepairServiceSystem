namespace RepairServicesSystem
{
    partial class CreateUser
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
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.RadioButtonManager = new System.Windows.Forms.RadioButton();
            this.RadioButtonWorker = new System.Windows.Forms.RadioButton();
            this.RadioButtonClient = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(49, 55);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(142, 20);
            this.TextBoxFirstName.TabIndex = 1;
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(49, 109);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(142, 20);
            this.TextBoxLastName.TabIndex = 2;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(49, 161);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(142, 20);
            this.TextBoxLogin.TabIndex = 3;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(49, 217);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(142, 20);
            this.TextBoxPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(197, 254);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(96, 23);
            this.ButtonBack.TabIndex = 59;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(95, 254);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(96, 23);
            this.ButtonSave.TabIndex = 58;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonAdmin);
            this.groupBox1.Controls.Add(this.RadioButtonManager);
            this.groupBox1.Controls.Add(this.RadioButtonWorker);
            this.groupBox1.Controls.Add(this.RadioButtonClient);
            this.groupBox1.Location = new System.Drawing.Point(207, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 120);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Role";
            // 
            // RadioButtonAdmin
            // 
            this.RadioButtonAdmin.AutoSize = true;
            this.RadioButtonAdmin.Location = new System.Drawing.Point(16, 96);
            this.RadioButtonAdmin.Name = "RadioButtonAdmin";
            this.RadioButtonAdmin.Size = new System.Drawing.Size(85, 17);
            this.RadioButtonAdmin.TabIndex = 3;
            this.RadioButtonAdmin.TabStop = true;
            this.RadioButtonAdmin.Text = "Administrator";
            this.RadioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // RadioButtonManager
            // 
            this.RadioButtonManager.AutoSize = true;
            this.RadioButtonManager.Location = new System.Drawing.Point(16, 73);
            this.RadioButtonManager.Name = "RadioButtonManager";
            this.RadioButtonManager.Size = new System.Drawing.Size(67, 17);
            this.RadioButtonManager.TabIndex = 2;
            this.RadioButtonManager.TabStop = true;
            this.RadioButtonManager.Text = "Manager";
            this.RadioButtonManager.UseVisualStyleBackColor = true;
            // 
            // RadioButtonWorker
            // 
            this.RadioButtonWorker.AutoSize = true;
            this.RadioButtonWorker.Location = new System.Drawing.Point(16, 50);
            this.RadioButtonWorker.Name = "RadioButtonWorker";
            this.RadioButtonWorker.Size = new System.Drawing.Size(60, 17);
            this.RadioButtonWorker.TabIndex = 1;
            this.RadioButtonWorker.TabStop = true;
            this.RadioButtonWorker.Text = "Worker";
            this.RadioButtonWorker.UseVisualStyleBackColor = true;
            // 
            // RadioButtonClient
            // 
            this.RadioButtonClient.AutoSize = true;
            this.RadioButtonClient.Location = new System.Drawing.Point(16, 25);
            this.RadioButtonClient.Name = "RadioButtonClient";
            this.RadioButtonClient.Size = new System.Drawing.Size(51, 17);
            this.RadioButtonClient.TabIndex = 0;
            this.RadioButtonClient.TabStop = true;
            this.RadioButtonClient.Text = "Client";
            this.RadioButtonClient.UseVisualStyleBackColor = true;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 295);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.TextBoxLastName);
            this.Controls.Add(this.TextBoxFirstName);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonAdmin;
        private System.Windows.Forms.RadioButton RadioButtonManager;
        private System.Windows.Forms.RadioButton RadioButtonWorker;
        private System.Windows.Forms.RadioButton RadioButtonClient;
    }
}