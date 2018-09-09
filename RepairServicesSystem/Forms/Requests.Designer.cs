namespace RepairServicesSystem
{
    partial class Requests
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
            this.ButtonShowActivities = new System.Windows.Forms.Button();
            this.ButtonViewRequest = new System.Windows.Forms.Button();
            this.ButtonEditRequest = new System.Windows.Forms.Button();
            this.ButtonAddRequest = new System.Windows.Forms.Button();
            this.DataViewRequests = new System.Windows.Forms.DataGridView();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxObjectNumber = new System.Windows.Forms.TextBox();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonAny = new System.Windows.Forms.RadioButton();
            this.RadioButtonFinished = new System.Windows.Forms.RadioButton();
            this.RadioButtonCancelled = new System.Windows.Forms.RadioButton();
            this.RadioButtonInProgress = new System.Windows.Forms.RadioButton();
            this.RadioButtonOpen = new System.Windows.Forms.RadioButton();
            this.ButtonPersonel = new System.Windows.Forms.Button();
            this.TextBoxPersonelId = new System.Windows.Forms.TextBox();
            this.ButtonAddClient = new System.Windows.Forms.Button();
            this.ButtonSearchObject = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ButtonGoToObjects = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRequests)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonShowActivities
            // 
            this.ButtonShowActivities.Cursor = System.Windows.Forms.Cursors.No;
            this.ButtonShowActivities.Location = new System.Drawing.Point(661, 260);
            this.ButtonShowActivities.Name = "ButtonShowActivities";
            this.ButtonShowActivities.Size = new System.Drawing.Size(96, 26);
            this.ButtonShowActivities.TabIndex = 38;
            this.ButtonShowActivities.Text = "Show activities";
            this.ButtonShowActivities.UseVisualStyleBackColor = true;
            this.ButtonShowActivities.Click += new System.EventHandler(this.ButtonShowActivities_Click);
            // 
            // ButtonViewRequest
            // 
            this.ButtonViewRequest.Cursor = System.Windows.Forms.Cursors.No;
            this.ButtonViewRequest.Location = new System.Drawing.Point(661, 228);
            this.ButtonViewRequest.Name = "ButtonViewRequest";
            this.ButtonViewRequest.Size = new System.Drawing.Size(96, 26);
            this.ButtonViewRequest.TabIndex = 37;
            this.ButtonViewRequest.Text = "View request";
            this.ButtonViewRequest.UseVisualStyleBackColor = true;
            this.ButtonViewRequest.Click += new System.EventHandler(this.ButtonViewRequest_Click);
            // 
            // ButtonEditRequest
            // 
            this.ButtonEditRequest.Cursor = System.Windows.Forms.Cursors.No;
            this.ButtonEditRequest.Location = new System.Drawing.Point(661, 195);
            this.ButtonEditRequest.Name = "ButtonEditRequest";
            this.ButtonEditRequest.Size = new System.Drawing.Size(96, 26);
            this.ButtonEditRequest.TabIndex = 36;
            this.ButtonEditRequest.Text = "Edit request";
            this.ButtonEditRequest.UseVisualStyleBackColor = true;
            this.ButtonEditRequest.Click += new System.EventHandler(this.ButtonEditRequest_Click);
            // 
            // ButtonAddRequest
            // 
            this.ButtonAddRequest.Cursor = System.Windows.Forms.Cursors.No;
            this.ButtonAddRequest.Location = new System.Drawing.Point(661, 162);
            this.ButtonAddRequest.Name = "ButtonAddRequest";
            this.ButtonAddRequest.Size = new System.Drawing.Size(96, 26);
            this.ButtonAddRequest.TabIndex = 34;
            this.ButtonAddRequest.Text = "Add request";
            this.ButtonAddRequest.UseVisualStyleBackColor = true;
            this.ButtonAddRequest.Click += new System.EventHandler(this.ButtonAddRequest_Click);
            // 
            // DataViewRequests
            // 
            this.DataViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewRequests.Location = new System.Drawing.Point(28, 130);
            this.DataViewRequests.Name = "DataViewRequests";
            this.DataViewRequests.Size = new System.Drawing.Size(612, 225);
            this.DataViewRequests.TabIndex = 33;
            this.DataViewRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewRequests_CellContentClick);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.No;
            this.ButtonSearch.Location = new System.Drawing.Point(661, 130);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(96, 26);
            this.ButtonSearch.TabIndex = 32;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Personel Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Object number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Request Id";
            // 
            // TextBoxObjectNumber
            // 
            this.TextBoxObjectNumber.Location = new System.Drawing.Point(157, 37);
            this.TextBoxObjectNumber.Name = "TextBoxObjectNumber";
            this.TextBoxObjectNumber.Size = new System.Drawing.Size(68, 20);
            this.TextBoxObjectNumber.TabIndex = 25;
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(28, 37);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxId.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Result";
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(414, 38);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.Size = new System.Drawing.Size(100, 20);
            this.TextBoxResult.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonAny);
            this.groupBox1.Controls.Add(this.RadioButtonFinished);
            this.groupBox1.Controls.Add(this.RadioButtonCancelled);
            this.groupBox1.Controls.Add(this.RadioButtonInProgress);
            this.groupBox1.Controls.Add(this.RadioButtonOpen);
            this.groupBox1.Location = new System.Drawing.Point(28, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 51);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // RadioButtonAny
            // 
            this.RadioButtonAny.AutoSize = true;
            this.RadioButtonAny.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonAny.Name = "RadioButtonAny";
            this.RadioButtonAny.Size = new System.Drawing.Size(43, 17);
            this.RadioButtonAny.TabIndex = 4;
            this.RadioButtonAny.TabStop = true;
            this.RadioButtonAny.Text = "Any";
            this.RadioButtonAny.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFinished
            // 
            this.RadioButtonFinished.AutoSize = true;
            this.RadioButtonFinished.Location = new System.Drawing.Point(273, 19);
            this.RadioButtonFinished.Name = "RadioButtonFinished";
            this.RadioButtonFinished.Size = new System.Drawing.Size(64, 17);
            this.RadioButtonFinished.TabIndex = 3;
            this.RadioButtonFinished.TabStop = true;
            this.RadioButtonFinished.Text = "Finished";
            this.RadioButtonFinished.UseVisualStyleBackColor = true;
            // 
            // RadioButtonCancelled
            // 
            this.RadioButtonCancelled.AutoSize = true;
            this.RadioButtonCancelled.Location = new System.Drawing.Point(195, 19);
            this.RadioButtonCancelled.Name = "RadioButtonCancelled";
            this.RadioButtonCancelled.Size = new System.Drawing.Size(72, 17);
            this.RadioButtonCancelled.TabIndex = 2;
            this.RadioButtonCancelled.TabStop = true;
            this.RadioButtonCancelled.Text = "Cancelled";
            this.RadioButtonCancelled.UseVisualStyleBackColor = true;
            // 
            // RadioButtonInProgress
            // 
            this.RadioButtonInProgress.AutoSize = true;
            this.RadioButtonInProgress.Location = new System.Drawing.Point(112, 19);
            this.RadioButtonInProgress.Name = "RadioButtonInProgress";
            this.RadioButtonInProgress.Size = new System.Drawing.Size(77, 17);
            this.RadioButtonInProgress.TabIndex = 1;
            this.RadioButtonInProgress.TabStop = true;
            this.RadioButtonInProgress.Text = "In progress";
            this.RadioButtonInProgress.UseVisualStyleBackColor = true;
            // 
            // RadioButtonOpen
            // 
            this.RadioButtonOpen.AutoSize = true;
            this.RadioButtonOpen.Location = new System.Drawing.Point(55, 19);
            this.RadioButtonOpen.Name = "RadioButtonOpen";
            this.RadioButtonOpen.Size = new System.Drawing.Size(51, 17);
            this.RadioButtonOpen.TabIndex = 0;
            this.RadioButtonOpen.TabStop = true;
            this.RadioButtonOpen.Text = "Open";
            this.RadioButtonOpen.UseVisualStyleBackColor = true;
            // 
            // ButtonPersonel
            // 
            this.ButtonPersonel.Location = new System.Drawing.Point(358, 37);
            this.ButtonPersonel.Name = "ButtonPersonel";
            this.ButtonPersonel.Size = new System.Drawing.Size(27, 20);
            this.ButtonPersonel.TabIndex = 72;
            this.ButtonPersonel.Text = "...";
            this.ButtonPersonel.UseVisualStyleBackColor = true;
            this.ButtonPersonel.Click += new System.EventHandler(this.ButtonPersonel_Click);
            // 
            // TextBoxPersonelId
            // 
            this.TextBoxPersonelId.Location = new System.Drawing.Point(287, 37);
            this.TextBoxPersonelId.Name = "TextBoxPersonelId";
            this.TextBoxPersonelId.Size = new System.Drawing.Size(65, 20);
            this.TextBoxPersonelId.TabIndex = 71;
            // 
            // ButtonAddClient
            // 
            this.ButtonAddClient.Location = new System.Drawing.Point(661, 292);
            this.ButtonAddClient.Name = "ButtonAddClient";
            this.ButtonAddClient.Size = new System.Drawing.Size(96, 23);
            this.ButtonAddClient.TabIndex = 73;
            this.ButtonAddClient.Text = "Add client";
            this.ButtonAddClient.UseVisualStyleBackColor = true;
            this.ButtonAddClient.Click += new System.EventHandler(this.ButtonAddClient_Click);
            // 
            // ButtonSearchObject
            // 
            this.ButtonSearchObject.Location = new System.Drawing.Point(231, 37);
            this.ButtonSearchObject.Name = "ButtonSearchObject";
            this.ButtonSearchObject.Size = new System.Drawing.Size(27, 20);
            this.ButtonSearchObject.TabIndex = 74;
            this.ButtonSearchObject.Text = "...";
            this.ButtonSearchObject.UseVisualStyleBackColor = true;
            this.ButtonSearchObject.Click += new System.EventHandler(this.ButtonSearchObject_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(661, 332);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(96, 23);
            this.BackBtn.TabIndex = 75;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ButtonGoToObjects
            // 
            this.ButtonGoToObjects.Location = new System.Drawing.Point(269, 361);
            this.ButtonGoToObjects.Name = "ButtonGoToObjects";
            this.ButtonGoToObjects.Size = new System.Drawing.Size(96, 23);
            this.ButtonGoToObjects.TabIndex = 76;
            this.ButtonGoToObjects.Text = "Go to objects";
            this.ButtonGoToObjects.UseVisualStyleBackColor = true;
            this.ButtonGoToObjects.Click += new System.EventHandler(this.ButtonAddObject_Click);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 388);
            this.Controls.Add(this.ButtonGoToObjects);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ButtonSearchObject);
            this.Controls.Add(this.ButtonAddClient);
            this.Controls.Add(this.ButtonPersonel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBoxPersonelId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.ButtonShowActivities);
            this.Controls.Add(this.ButtonViewRequest);
            this.Controls.Add(this.ButtonEditRequest);
            this.Controls.Add(this.ButtonAddRequest);
            this.Controls.Add(this.DataViewRequests);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxObjectNumber);
            this.Controls.Add(this.TextBoxId);
            this.Name = "Requests";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRequests)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonShowActivities;
        private System.Windows.Forms.Button ButtonViewRequest;
        private System.Windows.Forms.Button ButtonEditRequest;
        private System.Windows.Forms.Button ButtonAddRequest;
        private System.Windows.Forms.DataGridView DataViewRequests;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxObjectNumber;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonFinished;
        private System.Windows.Forms.RadioButton RadioButtonCancelled;
        private System.Windows.Forms.RadioButton RadioButtonInProgress;
        private System.Windows.Forms.RadioButton RadioButtonOpen;
        private System.Windows.Forms.Button ButtonPersonel;
        private System.Windows.Forms.TextBox TextBoxPersonelId;
        private System.Windows.Forms.RadioButton RadioButtonAny;
        private System.Windows.Forms.Button ButtonAddClient;
        private System.Windows.Forms.Button ButtonSearchObject;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ButtonGoToObjects;
    }
}