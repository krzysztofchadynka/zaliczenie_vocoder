using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace vocoder
{
    public partial class AddEffectForm : Form
    {
        private string file_path, new_path;
        private bool modified = false;
        private bool isPlaying = false;
        private Record record;

        public AddEffectForm(string file_path)
        {
            InitializeComponent();
            this.file_path = file_path;
            this.effect_file_name.Text = Path.GetFileName(file_path);
            record = new Record();
        }

        private void AddEffect_Load(object sender, EventArgs e)
        {

        }

        private void generateEffect()
        {
            Effect effect = new Effect(this.file_path);
            this.new_path = effect.getNewPath();
            effect.GenerateQuery(effect_tempo_track.Value, effect_pitch_track.Value, effect_rate_track.Value);
            this.modified = true;
        }

        private void effect_generate_button_Click(object sender, EventArgs e)
        {
            generateEffect();
        }

        private void effect_play_button_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                
                if (!this.modified) record.openFile(this.file_path);
                else record.openFile(this.new_path);
                effect_play_button.Text = "Stop";
                isPlaying = true;
                record.play();      
            }
            else
            {
                effect_play_button.Text = "Play";
                isPlaying = false;
                record.stop();
            }
        }
    }
}
