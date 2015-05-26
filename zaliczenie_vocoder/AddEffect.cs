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
        private string file_path;

        public AddEffectForm(string file_path)
        {
            InitializeComponent();
            this.file_path = file_path;
            this.effect_file_name.Text = Path.GetFileName(file_path);
        }

        private void AddEffect_Load(object sender, EventArgs e)
        {

        }

        public void generateEffect()
        {
            Effect effect = new Effect(this.file_path);
            effect.GenerateQuery(effect_tempo_track.Value, effect_pitch_track.Value, effect_rate_track.Value, effect_bpm_track.Value);
        }

        private void effect_generate_button_Click(object sender, EventArgs e)
        {
            generateEffect();
        }
    }
}
