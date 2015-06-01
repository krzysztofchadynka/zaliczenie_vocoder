namespace vocoder
{
    partial class AddEffectForm
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
            this.effect_file_name = new System.Windows.Forms.Label();
            this.effect_tempo_track = new System.Windows.Forms.TrackBar();
            this.effect_pitch_track = new System.Windows.Forms.TrackBar();
            this.effect_rate_track = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.effect_generate_button = new System.Windows.Forms.Button();
            this.effect_play_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.effect_tempo_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effect_pitch_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effect_rate_track)).BeginInit();
            this.SuspendLayout();
            // 
            // effect_file_name
            // 
            this.effect_file_name.AutoSize = true;
            this.effect_file_name.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Bold);
            this.effect_file_name.Location = new System.Drawing.Point(106, 9);
            this.effect_file_name.Name = "effect_file_name";
            this.effect_file_name.Size = new System.Drawing.Size(0, 36);
            this.effect_file_name.TabIndex = 0;
            // 
            // effect_tempo_track
            // 
            this.effect_tempo_track.Location = new System.Drawing.Point(112, 73);
            this.effect_tempo_track.Maximum = 200;
            this.effect_tempo_track.Minimum = -95;
            this.effect_tempo_track.Name = "effect_tempo_track";
            this.effect_tempo_track.Size = new System.Drawing.Size(347, 45);
            this.effect_tempo_track.TabIndex = 1;
            // 
            // effect_pitch_track
            // 
            this.effect_pitch_track.Location = new System.Drawing.Point(112, 141);
            this.effect_pitch_track.Maximum = 60;
            this.effect_pitch_track.Minimum = -60;
            this.effect_pitch_track.Name = "effect_pitch_track";
            this.effect_pitch_track.Size = new System.Drawing.Size(347, 45);
            this.effect_pitch_track.TabIndex = 2;
            // 
            // effect_rate_track
            // 
            this.effect_rate_track.Location = new System.Drawing.Point(112, 202);
            this.effect_rate_track.Maximum = 200;
            this.effect_rate_track.Minimum = -95;
            this.effect_rate_track.Name = "effect_rate_track";
            this.effect_rate_track.Size = new System.Drawing.Size(347, 45);
            this.effect_rate_track.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pitch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(19, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rate";
            // 
            // effect_generate_button
            // 
            this.effect_generate_button.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.effect_generate_button.Location = new System.Drawing.Point(24, 278);
            this.effect_generate_button.Name = "effect_generate_button";
            this.effect_generate_button.Size = new System.Drawing.Size(154, 51);
            this.effect_generate_button.TabIndex = 9;
            this.effect_generate_button.Text = "Generate";
            this.effect_generate_button.UseVisualStyleBackColor = true;
            this.effect_generate_button.Click += new System.EventHandler(this.effect_generate_button_Click);
            // 
            // effect_play_button
            // 
            this.effect_play_button.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.effect_play_button.Location = new System.Drawing.Point(305, 278);
            this.effect_play_button.Name = "effect_play_button";
            this.effect_play_button.Size = new System.Drawing.Size(154, 51);
            this.effect_play_button.TabIndex = 10;
            this.effect_play_button.Text = "Play";
            this.effect_play_button.UseVisualStyleBackColor = true;
            this.effect_play_button.Click += new System.EventHandler(this.effect_play_button_Click);
            // 
            // AddEffectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 351);
            this.Controls.Add(this.effect_play_button);
            this.Controls.Add(this.effect_generate_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.effect_rate_track);
            this.Controls.Add(this.effect_pitch_track);
            this.Controls.Add(this.effect_tempo_track);
            this.Controls.Add(this.effect_file_name);
            this.Name = "AddEffectForm";
            this.Text = "AddEffectForm";
            this.Load += new System.EventHandler(this.AddEffect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.effect_tempo_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effect_pitch_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effect_rate_track)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label effect_file_name;
        private System.Windows.Forms.TrackBar effect_tempo_track;
        private System.Windows.Forms.TrackBar effect_pitch_track;
        private System.Windows.Forms.TrackBar effect_rate_track;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button effect_generate_button;
        private System.Windows.Forms.Button effect_play_button;
    }
}