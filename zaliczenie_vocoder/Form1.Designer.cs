﻿namespace vocoder
{
    partial class MainForm
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
            this.new_record_bnt = new System.Windows.Forms.Button();
            this.bnt_open_file = new System.Windows.Forms.Button();
            this.bnt_close_app = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amazing Voice";
            // 
            // new_record_bnt
            // 
            this.new_record_bnt.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_record_bnt.Location = new System.Drawing.Point(16, 140);
            this.new_record_bnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_record_bnt.Name = "new_record_bnt";
            this.new_record_bnt.Size = new System.Drawing.Size(185, 97);
            this.new_record_bnt.TabIndex = 1;
            this.new_record_bnt.Text = "New record";
            this.new_record_bnt.UseVisualStyleBackColor = true;
            this.new_record_bnt.Click += new System.EventHandler(this.new_record_bnt_Click);
            // 
            // bnt_open_file
            // 
            this.bnt_open_file.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_open_file.Location = new System.Drawing.Point(427, 140);
            this.bnt_open_file.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_open_file.Name = "bnt_open_file";
            this.bnt_open_file.Size = new System.Drawing.Size(185, 97);
            this.bnt_open_file.TabIndex = 2;
            this.bnt_open_file.Text = "Open file";
            this.bnt_open_file.UseVisualStyleBackColor = true;
            this.bnt_open_file.Click += new System.EventHandler(this.bnt_open_file_Click);
            // 
            // bnt_close_app
            // 
            this.bnt_close_app.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_close_app.Location = new System.Drawing.Point(220, 267);
            this.bnt_close_app.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_close_app.Name = "bnt_close_app";
            this.bnt_close_app.Size = new System.Drawing.Size(185, 97);
            this.bnt_close_app.TabIndex = 3;
            this.bnt_close_app.Text = "Close";
            this.bnt_close_app.UseVisualStyleBackColor = true;
            this.bnt_close_app.Click += new System.EventHandler(this.bnt_close_app_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(628, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.koniecToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.koniecToolStripMenuItem.Text = "New record";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 432);
            this.Controls.Add(this.bnt_close_app);
            this.Controls.Add(this.bnt_open_file);
            this.Controls.Add(this.new_record_bnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Amazing Voice";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button new_record_bnt;
        private System.Windows.Forms.Button bnt_open_file;
        private System.Windows.Forms.Button bnt_close_app;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

