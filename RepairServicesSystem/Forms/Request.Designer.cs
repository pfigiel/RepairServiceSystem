namespace RepairServicesSystem
{
    partial class Request
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
            this.ButtonAddActivity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxObjectNumber = new System.Windows.Forms.TextBox();
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
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.ButtonUsers = new System.Windows.Forms.Button();
            this.TextBoxPersonelId = new System.Windows.Forms.TextBox();
            this.ButtonObjects = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonShowActivities
            // 
            this.ButtonShowActivities.Location = new System.Drawing.Point(301, 410);
            this.ButtonShowActivities.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonShowActivities.Name = "ButtonShowActivities";
            this.ButtonShowActivities.Size = new System.Drawing.Size(128, 28);
            this.ButtonShowActivities.TabIndex = 23;
            this.ButtonShowActivities.Text = "Show activities";
            this.ButtonShowActivities.UseVisualStyleBackColor = true;
            this.ButtonShowActivities.Click += new System.EventHandler(this.ButtonShowActivities_Click);
            // 
            // ButtonAddActivity
            // 
            this.ButtonAddActivity.Location = new System.Drawing.Point(145, 410);
            this.ButtonAddActivity.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddActivity.Name = "ButtonAddActivity";
            this.ButtonAddActivity.Size = new System.Drawing.Size(128, 28);
            this.ButtonAddActivity.TabIndex = 22;
            this.ButtonAddActivity.Text = "Add activity";
            this.ButtonAddActivity.UseVisualStyleBackColor = true;
            this.ButtonAddActivity.Click += new System.EventHandler(this.ButtonAddActivity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Personel id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Object number:";
            // 
            // TextBoxObjectNumber
            // 
            this.TextBoxObjectNumber.Location = new System.Drawing.Point(57, 65);
            this.TextBoxObjectNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxObjectNumber.Name = "TextBoxObjectNumber";
            this.TextBoxObjectNumber.Size = new System.Drawing.Size(155, 22);
            this.TextBoxObjectNumber.TabIndex = 12;
            // 
            // DateTimePickerEnd
            // 
            this.DateTimePickerEnd.Location = new System.Drawing.Point(547, 118);
            this.DateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerEnd.Name = "DateTimePickerEnd";
            this.DateTimePickerEnd.Size = new System.Drawing.Size(284, 22);
            this.DateTimePickerEnd.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Closing date";
            // 
            // DateTimePickerStart
            // 
            this.DateTimePickerStart.Location = new System.Drawing.Point(547, 65);
            this.DateTimePickerStart.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerStart.Name = "DateTimePickerStart";
            this.DateTimePickerStart.Size = new System.Drawing.Size(283, 22);
            this.DateTimePickerStart.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 57;
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
            this.groupBox1.TabIndex = 56;
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
            this.label5.TabIndex = 55;
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
            this.TextBoxDescription.TabIndex = 54;
            this.TextBoxDescription.TextChanged += new System.EventHandler(this.TextBoxDescription_TextChanged);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(624, 410);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(128, 28);
            this.ButtonBack.TabIndex = 53;
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
            this.ButtonSave.TabIndex = 52;
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
            this.label3.TabIndex = 51;
            this.label3.Text = "Result";
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(547, 229);
            this.TextBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxResult.Multiline = true;
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxResult.Size = new System.Drawing.Size(204, 147);
            this.TextBoxResult.TabIndex = 61;
            // 
            // ButtonUsers
            // 
            this.ButtonUsers.Location = new System.Drawing.Point(221, 122);
            this.ButtonUsers.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUsers.Name = "ButtonUsers";
            this.ButtonUsers.Size = new System.Drawing.Size(36, 25);
            this.ButtonUsers.TabIndex = 72;
            this.ButtonUsers.Text = "...";
            this.ButtonUsers.UseVisualStyleBackColor = true;
            this.ButtonUsers.Click += new System.EventHandler(this.ButtonUsers_Click);
            // 
            // TextBoxPersonelId
            // 
            this.TextBoxPersonelId.Location = new System.Drawing.Point(57, 122);
            this.TextBoxPersonelId.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPersonelId.Name = "TextBoxPersonelId";
            this.TextBoxPersonelId.Size = new System.Drawing.Size(155, 22);
            this.TextBoxPersonelId.TabIndex = 71;
            // 
            // ButtonObjects
            // 
            this.ButtonObjects.Location = new System.Drawing.Point(221, 65);
            this.ButtonObjects.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonObjects.Name = "ButtonObjects";
            this.ButtonObjects.Size = new System.Drawing.Size(36, 25);
            this.ButtonObjects.TabIndex = 73;
            this.ButtonObjects.Text = "...";
            this.ButtonObjects.UseVisualStyleBackColor = true;
            this.ButtonObjects.Click += new System.EventHandler(this.ButtonObjects_Click);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 474);
            this.Controls.Add(this.ButtonObjects);
            this.Controls.Add(this.ButtonUsers);
            this.Controls.Add(this.TextBoxPersonelId);
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
            this.Controls.Add(this.ButtonShowActivities);
            this.Controls.Add(this.ButtonAddActivity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxObjectNumber);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Request";
            this.Text = "Request";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonShowActivities;
        private System.Windows.Forms.Button ButtonAddActivity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxObjectNumber;
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
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Button ButtonUsers;
        private System.Windows.Forms.TextBox TextBoxPersonelId;
        private System.Windows.Forms.Button ButtonObjects;
    }
}