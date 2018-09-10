namespace RepairServicesSystem
{
    partial class Objects
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxClientId = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonAddObject = new System.Windows.Forms.Button();
            this.AddReqBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.ButtonEditObject = new System.Windows.Forms.Button();
            this.ButtonGoToRequests = new System.Windows.Forms.Button();
            this.ButtonSearchClient = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxObjectType = new System.Windows.Forms.ComboBox();
            this.OPNBtn = new System.Windows.Forms.RadioButton();
            this.PROBtn = new System.Windows.Forms.RadioButton();
            this.CANBtn = new System.Windows.Forms.RadioButton();
            this.FINBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Client id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(102, 86);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxName.TabIndex = 10;
            // 
            // TextBoxClientId
            // 
            this.TextBoxClientId.Location = new System.Drawing.Point(102, 60);
            this.TextBoxClientId.Name = "TextBoxClientId";
            this.TextBoxClientId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClientId.TabIndex = 9;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.No;
            this.ButtonSearch.Location = new System.Drawing.Point(465, 143);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(96, 26);
            this.ButtonSearch.TabIndex = 16;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 180);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ButtonAddObject
            // 
            this.ButtonAddObject.Cursor = System.Windows.Forms.Cursors.No;
            this.ButtonAddObject.Location = new System.Drawing.Point(465, 201);
            this.ButtonAddObject.Name = "ButtonAddObject";
            this.ButtonAddObject.Size = new System.Drawing.Size(96, 26);
            this.ButtonAddObject.TabIndex = 18;
            this.ButtonAddObject.Text = "Add object";
            this.ButtonAddObject.UseVisualStyleBackColor = true;
            this.ButtonAddObject.Click += new System.EventHandler(this.ButtonAddObject_Click);
            // 
            // AddReqBtn
            // 
            this.AddReqBtn.Cursor = System.Windows.Forms.Cursors.No;
            this.AddReqBtn.Location = new System.Drawing.Point(465, 297);
            this.AddReqBtn.Name = "AddReqBtn";
            this.AddReqBtn.Size = new System.Drawing.Size(96, 26);
            this.AddReqBtn.TabIndex = 19;
            this.AddReqBtn.Text = "Add request";
            this.AddReqBtn.UseVisualStyleBackColor = true;
            this.AddReqBtn.Click += new System.EventHandler(this.AddReqBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Cursor = System.Windows.Forms.Cursors.No;
            this.ViewBtn.Location = new System.Drawing.Point(465, 265);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(96, 26);
            this.ViewBtn.TabIndex = 22;
            this.ViewBtn.Text = "View object";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // ButtonEditObject
            // 
            this.ButtonEditObject.Cursor = System.Windows.Forms.Cursors.No;
            this.ButtonEditObject.Location = new System.Drawing.Point(465, 233);
            this.ButtonEditObject.Name = "ButtonEditObject";
            this.ButtonEditObject.Size = new System.Drawing.Size(96, 26);
            this.ButtonEditObject.TabIndex = 21;
            this.ButtonEditObject.Text = "Edit object";
            this.ButtonEditObject.UseVisualStyleBackColor = true;
            this.ButtonEditObject.Click += new System.EventHandler(this.ButtonEditObject_Click);
            // 
            // ButtonGoToRequests
            // 
            this.ButtonGoToRequests.Cursor = System.Windows.Forms.Cursors.No;
            this.ButtonGoToRequests.Location = new System.Drawing.Point(214, 357);
            this.ButtonGoToRequests.Name = "ButtonGoToRequests";
            this.ButtonGoToRequests.Size = new System.Drawing.Size(96, 26);
            this.ButtonGoToRequests.TabIndex = 23;
            this.ButtonGoToRequests.Text = "Go to requests";
            this.ButtonGoToRequests.UseVisualStyleBackColor = true;
            this.ButtonGoToRequests.Click += new System.EventHandler(this.button4_Click);
            // 
            // ButtonSearchClient
            // 
            this.ButtonSearchClient.Location = new System.Drawing.Point(209, 60);
            this.ButtonSearchClient.Name = "ButtonSearchClient";
            this.ButtonSearchClient.Size = new System.Drawing.Size(29, 20);
            this.ButtonSearchClient.TabIndex = 71;
            this.ButtonSearchClient.Text = "...";
            this.ButtonSearchClient.UseVisualStyleBackColor = true;
            this.ButtonSearchClient.Click += new System.EventHandler(this.ButtonSearchClient_Click);
            // 
            // backBtn
            // 
            this.backBtn.Cursor = System.Windows.Forms.Cursors.No;
            this.backBtn.Location = new System.Drawing.Point(465, 357);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(96, 26);
            this.backBtn.TabIndex = 72;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Type:";
            // 
            // ComboBoxObjectType
            // 
            this.ComboBoxObjectType.FormattingEnabled = true;
            this.ComboBoxObjectType.Location = new System.Drawing.Point(102, 113);
            this.ComboBoxObjectType.Name = "ComboBoxObjectType";
            this.ComboBoxObjectType.Size = new System.Drawing.Size(100, 21);
            this.ComboBoxObjectType.TabIndex = 74;
            // 
            // OPNBtn
            // 
            this.OPNBtn.AutoSize = true;
            this.OPNBtn.Location = new System.Drawing.Point(16, 25);
            this.OPNBtn.Name = "OPNBtn";
            this.OPNBtn.Size = new System.Drawing.Size(48, 17);
            this.OPNBtn.TabIndex = 0;
            this.OPNBtn.TabStop = true;
            this.OPNBtn.Text = "OPN";
            this.OPNBtn.UseVisualStyleBackColor = true;
            // 
            // PROBtn
            // 
            this.PROBtn.AutoSize = true;
            this.PROBtn.Location = new System.Drawing.Point(16, 50);
            this.PROBtn.Name = "PROBtn";
            this.PROBtn.Size = new System.Drawing.Size(48, 17);
            this.PROBtn.TabIndex = 1;
            this.PROBtn.TabStop = true;
            this.PROBtn.Text = "PRO";
            this.PROBtn.UseVisualStyleBackColor = true;
            // 
            // CANBtn
            // 
            this.CANBtn.AutoSize = true;
            this.CANBtn.Location = new System.Drawing.Point(16, 73);
            this.CANBtn.Name = "CANBtn";
            this.CANBtn.Size = new System.Drawing.Size(47, 17);
            this.CANBtn.TabIndex = 2;
            this.CANBtn.TabStop = true;
            this.CANBtn.Text = "CAN";
            this.CANBtn.UseVisualStyleBackColor = true;
            // 
            // FINBtn
            // 
            this.FINBtn.AutoSize = true;
            this.FINBtn.Location = new System.Drawing.Point(16, 96);
            this.FINBtn.Name = "FINBtn";
            this.FINBtn.Size = new System.Drawing.Size(42, 17);
            this.FINBtn.TabIndex = 3;
            this.FINBtn.TabStop = true;
            this.FINBtn.Text = "FIN";
            this.FINBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FINBtn);
            this.groupBox1.Controls.Add(this.CANBtn);
            this.groupBox1.Controls.Add(this.PROBtn);
            this.groupBox1.Controls.Add(this.OPNBtn);
            this.groupBox1.Location = new System.Drawing.Point(305, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 120);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Code type";
            // 
            // Objects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 410);
            this.Controls.Add(this.ComboBoxObjectType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.ButtonSearchClient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonGoToRequests);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.ButtonEditObject);
            this.Controls.Add(this.AddReqBtn);
            this.Controls.Add(this.ButtonAddObject);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxClientId);
            this.Name = "Objects";
            this.Text = "Objects";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxClientId;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonAddObject;
        private System.Windows.Forms.Button AddReqBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button ButtonEditObject;
        private System.Windows.Forms.Button ButtonGoToRequests;
        private System.Windows.Forms.Button ButtonSearchClient;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxObjectType;
        private System.Windows.Forms.RadioButton OPNBtn;
        private System.Windows.Forms.RadioButton PROBtn;
        private System.Windows.Forms.RadioButton CANBtn;
        private System.Windows.Forms.RadioButton FINBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}