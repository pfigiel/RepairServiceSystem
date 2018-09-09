namespace RepairServicesSystem
{
    partial class Object
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
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxClientId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonShowRequest = new System.Windows.Forms.Button();
            this.ButtonAddRequest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBFIN = new System.Windows.Forms.RadioButton();
            this.RBCAN = new System.Windows.Forms.RadioButton();
            this.RBPRO = new System.Windows.Forms.RadioButton();
            this.RBOPN = new System.Windows.Forms.RadioButton();
            this.ButtonSearchClient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(47, 56);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(115, 20);
            this.TextBoxName.TabIndex = 1;
            // 
            // TextBoxClientId
            // 
            this.TextBoxClientId.Location = new System.Drawing.Point(47, 99);
            this.TextBoxClientId.Name = "TextBoxClientId";
            this.TextBoxClientId.Size = new System.Drawing.Size(82, 20);
            this.TextBoxClientId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client id";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(219, 97);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(96, 23);
            this.ButtonBack.TabIndex = 57;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(219, 70);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(96, 23);
            this.ButtonSave.TabIndex = 56;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonShowRequest
            // 
            this.ButtonShowRequest.Location = new System.Drawing.Point(445, 339);
            this.ButtonShowRequest.Name = "ButtonShowRequest";
            this.ButtonShowRequest.Size = new System.Drawing.Size(96, 23);
            this.ButtonShowRequest.TabIndex = 55;
            this.ButtonShowRequest.Text = "Show requests";
            this.ButtonShowRequest.UseVisualStyleBackColor = true;
            this.ButtonShowRequest.Click += new System.EventHandler(this.ButtonShowRequest_Click);
            // 
            // ButtonAddRequest
            // 
            this.ButtonAddRequest.Location = new System.Drawing.Point(547, 339);
            this.ButtonAddRequest.Name = "ButtonAddRequest";
            this.ButtonAddRequest.Size = new System.Drawing.Size(96, 23);
            this.ButtonAddRequest.TabIndex = 54;
            this.ButtonAddRequest.Text = "Add request";
            this.ButtonAddRequest.UseVisualStyleBackColor = true;
            this.ButtonAddRequest.Click += new System.EventHandler(this.ButtonAddRequest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBFIN);
            this.groupBox1.Controls.Add(this.RBCAN);
            this.groupBox1.Controls.Add(this.RBPRO);
            this.groupBox1.Controls.Add(this.RBOPN);
            this.groupBox1.Location = new System.Drawing.Point(47, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 120);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Code type";
            // 
            // RBFIN
            // 
            this.RBFIN.AutoSize = true;
            this.RBFIN.Location = new System.Drawing.Point(16, 96);
            this.RBFIN.Name = "RBFIN";
            this.RBFIN.Size = new System.Drawing.Size(42, 17);
            this.RBFIN.TabIndex = 3;
            this.RBFIN.TabStop = true;
            this.RBFIN.Text = "FIN";
            this.RBFIN.UseVisualStyleBackColor = true;
            // 
            // RBCAN
            // 
            this.RBCAN.AutoSize = true;
            this.RBCAN.Location = new System.Drawing.Point(16, 73);
            this.RBCAN.Name = "RBCAN";
            this.RBCAN.Size = new System.Drawing.Size(47, 17);
            this.RBCAN.TabIndex = 2;
            this.RBCAN.TabStop = true;
            this.RBCAN.Text = "CAN";
            this.RBCAN.UseVisualStyleBackColor = true;
            // 
            // RBPRO
            // 
            this.RBPRO.AutoSize = true;
            this.RBPRO.Location = new System.Drawing.Point(16, 50);
            this.RBPRO.Name = "RBPRO";
            this.RBPRO.Size = new System.Drawing.Size(48, 17);
            this.RBPRO.TabIndex = 1;
            this.RBPRO.TabStop = true;
            this.RBPRO.Text = "PRO";
            this.RBPRO.UseVisualStyleBackColor = true;
            // 
            // RBOPN
            // 
            this.RBOPN.AutoSize = true;
            this.RBOPN.Location = new System.Drawing.Point(16, 25);
            this.RBOPN.Name = "RBOPN";
            this.RBOPN.Size = new System.Drawing.Size(48, 17);
            this.RBOPN.TabIndex = 0;
            this.RBOPN.TabStop = true;
            this.RBOPN.Text = "OPN";
            this.RBOPN.UseVisualStyleBackColor = true;
            // 
            // ButtonSearchClient
            // 
            this.ButtonSearchClient.Location = new System.Drawing.Point(135, 99);
            this.ButtonSearchClient.Name = "ButtonSearchClient";
            this.ButtonSearchClient.Size = new System.Drawing.Size(27, 20);
            this.ButtonSearchClient.TabIndex = 70;
            this.ButtonSearchClient.Text = "...";
            this.ButtonSearchClient.UseVisualStyleBackColor = true;
            this.ButtonSearchClient.Click += new System.EventHandler(this.ButtonSearchClient_Click);
            // 
            // Object
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 374);
            this.Controls.Add(this.ButtonSearchClient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonShowRequest);
            this.Controls.Add(this.ButtonAddRequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxClientId);
            this.Controls.Add(this.TextBoxName);
            this.Name = "Object";
            this.Text = "Object";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxClientId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonShowRequest;
        private System.Windows.Forms.Button ButtonAddRequest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBFIN;
        private System.Windows.Forms.RadioButton RBCAN;
        private System.Windows.Forms.RadioButton RBPRO;
        private System.Windows.Forms.RadioButton RBOPN;
        private System.Windows.Forms.Button ButtonSearchClient;
    }
}