namespace vocoder
{
    partial class NewRecordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.record_voiceButton = new System.Windows.Forms.Button();
            this.stop_recordButton = new System.Windows.Forms.Button();
            this.openRecordDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectRecordFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.recordNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(142, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "New record";
            // 
            // record_voiceButton
            // 
            this.record_voiceButton.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.record_voiceButton.Location = new System.Drawing.Point(148, 155);
            this.record_voiceButton.Name = "record_voiceButton";
            this.record_voiceButton.Size = new System.Drawing.Size(174, 51);
            this.record_voiceButton.TabIndex = 1;
            this.record_voiceButton.Text = "Record";
            this.record_voiceButton.UseVisualStyleBackColor = true;
            this.record_voiceButton.Click += new System.EventHandler(this.record_voiceButton_Click);
            // 
            // stop_recordButton
            // 
            this.stop_recordButton.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.stop_recordButton.Location = new System.Drawing.Point(148, 155);
            this.stop_recordButton.Name = "stop_recordButton";
            this.stop_recordButton.Size = new System.Drawing.Size(174, 51);
            this.stop_recordButton.TabIndex = 4;
            this.stop_recordButton.Text = "Stop";
            this.stop_recordButton.UseVisualStyleBackColor = true;
            this.stop_recordButton.Visible = false;
            this.stop_recordButton.Click += new System.EventHandler(this.stop_recordButton_Click);
            // 
            // openRecordDialog
            // 
            this.openRecordDialog.FileName = "record";
            // 
            // recordNameTextBox
            // 
            this.recordNameTextBox.Location = new System.Drawing.Point(148, 110);
            this.recordNameTextBox.Name = "recordNameTextBox";
            this.recordNameTextBox.Size = new System.Drawing.Size(174, 20);
            this.recordNameTextBox.TabIndex = 5;
            this.recordNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Put record name";
            // 
            // NewRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 351);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recordNameTextBox);
            this.Controls.Add(this.stop_recordButton);
            this.Controls.Add(this.record_voiceButton);
            this.Controls.Add(this.label1);
            this.Name = "NewRecordForm";
            this.Text = "New Record";
            this.Load += new System.EventHandler(this.NewRecordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button record_voiceButton;
        private System.Windows.Forms.Button stop_recordButton;
        public System.Windows.Forms.OpenFileDialog openRecordDialog;
        public System.Windows.Forms.FolderBrowserDialog selectRecordFolderDialog;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox recordNameTextBox;
    }
}