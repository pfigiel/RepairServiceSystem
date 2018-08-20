namespace RepairServicesSystem
{
    partial class Activity
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxSequenceNumber = new System.Windows.Forms.TextBox();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.DateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonFinished = new System.Windows.Forms.RadioButton();
            this.RadioButtonCancelled = new System.Windows.Forms.RadioButton();
            this.RadioButtonInProgress = new System.Windows.Forms.RadioButton();
            this.RadioButtonOpen = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowRequestBtn = new System.Windows.Forms.Button();
            this.ShowPersonelBtn = new System.Windows.Forms.Button();
            this.TextBoxPersonelId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxActivityType = new System.Windows.Forms.TextBox();
            this.TextBoxReqId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReqIdBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Personel id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Sequence number";
            // 
            // TextBoxSequenceNumber
            // 
            this.TextBoxSequenceNumber.Location = new System.Drawing.Point(57, 231);
            this.TextBoxSequenceNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSequenceNumber.Name = "TextBoxSequenceNumber";
            this.TextBoxSequenceNumber.Size = new System.Drawing.Size(199, 22);
            this.TextBoxSequenceNumber.TabIndex = 53;
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(547, 229);
            this.TextBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxResult.Multiline = true;
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxResult.Size = new System.Drawing.Size(204, 147);
            this.TextBoxResult.TabIndex = 73;
            this.TextBoxResult.TextChanged += new System.EventHandler(this.TextBoxResult_TextChanged);
            // 
            // DateTimePickerEnd
            // 
            this.DateTimePickerEnd.Location = new System.Drawing.Point(547, 118);
            this.DateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerEnd.Name = "DateTimePickerEnd";
            this.DateTimePickerEnd.Size = new System.Drawing.Size(284, 22);
            this.DateTimePickerEnd.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Closing date";
            // 
            // DateTimePickerStart
            // 
            this.DateTimePickerStart.Location = new System.Drawing.Point(547, 65);
            this.DateTimePickerStart.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerStart.Name = "DateTimePickerStart";
            this.DateTimePickerStart.Size = new System.Drawing.Size(283, 22);
            this.DateTimePickerStart.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "Opening date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonFinished);
            this.groupBox1.Controls.Add(this.RadioButtonCancelled);
            this.groupBox1.Controls.Add(this.RadioButtonInProgress);
            this.groupBox1.Controls.Add(this.RadioButtonOpen);
            this.groupBox1.Location = new System.Drawing.Point(297, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(205, 148);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // RadioButtonFinished
            // 
            this.RadioButtonFinished.AutoSize = true;
            this.RadioButtonFinished.Location = new System.Drawing.Point(21, 118);
            this.RadioButtonFinished.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonFinished.Name = "RadioButtonFinished";
            this.RadioButtonFinished.Size = new System.Drawing.Size(82, 21);
            this.RadioButtonFinished.TabIndex = 3;
            this.RadioButtonFinished.TabStop = true;
            this.RadioButtonFinished.Text = "Finished";
            this.RadioButtonFinished.UseVisualStyleBackColor = true;
            // 
            // RadioButtonCancelled
            // 
            this.RadioButtonCancelled.AutoSize = true;
            this.RadioButtonCancelled.Location = new System.Drawing.Point(21, 90);
            this.RadioButtonCancelled.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonCancelled.Name = "RadioButtonCancelled";
            this.RadioButtonCancelled.Size = new System.Drawing.Size(91, 21);
            this.RadioButtonCancelled.TabIndex = 2;
            this.RadioButtonCancelled.TabStop = true;
            this.RadioButtonCancelled.Text = "Cancelled";
            this.RadioButtonCancelled.UseVisualStyleBackColor = true;
            // 
            // RadioButtonInProgress
            // 
            this.RadioButtonInProgress.AutoSize = true;
            this.RadioButtonInProgress.Location = new System.Drawing.Point(21, 62);
            this.RadioButtonInProgress.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonInProgress.Name = "RadioButtonInProgress";
            this.RadioButtonInProgress.Size = new System.Drawing.Size(100, 21);
            this.RadioButtonInProgress.TabIndex = 1;
            this.RadioButtonInProgress.TabStop = true;
            this.RadioButtonInProgress.Text = "In progress";
            this.RadioButtonInProgress.UseVisualStyleBackColor = true;
            // 
            // RadioButtonOpen
            // 
            this.RadioButtonOpen.AutoSize = true;
            this.RadioButtonOpen.Location = new System.Drawing.Point(21, 31);
            this.RadioButtonOpen.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonOpen.Name = "RadioButtonOpen";
            this.RadioButtonOpen.Size = new System.Drawing.Size(64, 21);
            this.RadioButtonOpen.TabIndex = 0;
            this.RadioButtonOpen.TabStop = true;
            this.RadioButtonOpen.Text = "Open";
            this.RadioButtonOpen.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 67;
            this.label5.Text = "Description";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(301, 229);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDescription.Size = new System.Drawing.Size(204, 147);
            this.TextBoxDescription.TabIndex = 66;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(624, 410);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(128, 28);
            this.ButtonBack.TabIndex = 65;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(464, 410);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(128, 28);
            this.ButtonSave.TabIndex = 64;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Result";
            // 
            // ShowRequestBtn
            // 
            this.ShowRequestBtn.Location = new System.Drawing.Point(57, 62);
            this.ShowRequestBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ShowRequestBtn.Name = "ShowRequestBtn";
            this.ShowRequestBtn.Size = new System.Drawing.Size(200, 28);
            this.ShowRequestBtn.TabIndex = 74;
            this.ShowRequestBtn.Text = "Show request";
            this.ShowRequestBtn.UseVisualStyleBackColor = true;
            this.ShowRequestBtn.Click += new System.EventHandler(this.ShowRequestBtn_Click);
            // 
            // ShowPersonelBtn
            // 
            this.ShowPersonelBtn.Location = new System.Drawing.Point(221, 187);
            this.ShowPersonelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ShowPersonelBtn.Name = "ShowPersonelBtn";
            this.ShowPersonelBtn.Size = new System.Drawing.Size(36, 25);
            this.ShowPersonelBtn.TabIndex = 76;
            this.ShowPersonelBtn.Text = "...";
            this.ShowPersonelBtn.UseVisualStyleBackColor = true;
            this.ShowPersonelBtn.Click += new System.EventHandler(this.ShowPersonelBtn_Click);
            // 
            // TextBoxPersonelId
            // 
            this.TextBoxPersonelId.Location = new System.Drawing.Point(57, 187);
            this.TextBoxPersonelId.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPersonelId.Name = "TextBoxPersonelId";
            this.TextBoxPersonelId.Size = new System.Drawing.Size(155, 22);
            this.TextBoxPersonelId.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Activity type";
            // 
            // TextBoxActivityType
            // 
            this.TextBoxActivityType.Location = new System.Drawing.Point(57, 132);
            this.TextBoxActivityType.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxActivityType.Name = "TextBoxActivityType";
            this.TextBoxActivityType.Size = new System.Drawing.Size(199, 22);
            this.TextBoxActivityType.TabIndex = 77;
            // 
            // TextBoxReqId
            // 
            this.TextBoxReqId.Location = new System.Drawing.Point(56, 281);
            this.TextBoxReqId.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxReqId.Name = "TextBoxReqId";
            this.TextBoxReqId.Size = new System.Drawing.Size(155, 22);
            this.TextBoxReqId.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "Request Id";
            // 
            // ReqIdBtn
            // 
            this.ReqIdBtn.Location = new System.Drawing.Point(220, 281);
            this.ReqIdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReqIdBtn.Name = "ReqIdBtn";
            this.ReqIdBtn.Size = new System.Drawing.Size(36, 25);
            this.ReqIdBtn.TabIndex = 80;
            this.ReqIdBtn.Text = "...";
            this.ReqIdBtn.UseVisualStyleBackColor = true;
            this.ReqIdBtn.Click += new System.EventHandler(this.ReqIdBtn_Click);
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 474);
            this.Controls.Add(this.ReqIdBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxReqId);
            this.Controls.Add(this.TextBoxActivityType);
            this.Controls.Add(this.ShowPersonelBtn);
            this.Controls.Add(this.TextBoxPersonelId);
            this.Controls.Add(this.ShowRequestBtn);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.DateTimePickerEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DateTimePickerStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxSequenceNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Activity";
            this.Text = "Activity";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxSequenceNumber;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.DateTimePicker DateTimePickerEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateTimePickerStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonFinished;
        private System.Windows.Forms.RadioButton RadioButtonCancelled;
        private System.Windows.Forms.RadioButton RadioButtonInProgress;
        private System.Windows.Forms.RadioButton RadioButtonOpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowRequestBtn;
        private System.Windows.Forms.Button ShowPersonelBtn;
        private System.Windows.Forms.TextBox TextBoxPersonelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxActivityType;
        private System.Windows.Forms.TextBox TextBoxReqId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReqIdBtn;
    }
}