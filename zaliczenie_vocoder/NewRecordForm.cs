using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Audio;

namespace vocoder
{
    public partial class NewRecordForm : Form
    {
        private Record new_record;
        private AddEffectForm add_effect;

        public NewRecordForm()
        {
            InitializeComponent();
        }

        private void changeButtonsStatus(bool recording)
        {
            if (recording)
            {
                record_voiceButton.Visible = false;
                stop_recordButton.Visible = true;
            }
            else
            {
                record_voiceButton.Visible = true;
                stop_recordButton.Visible = false;
            }
        }

        private void record_voiceButton_Click(object sender, EventArgs e)
        {
            changeButtonsStatus(true);
            new_record = new Record();
            if (selectRecordFolderDialog.ShowDialog() == DialogResult.OK)
            {
                new_record.recordAudio(selectRecordFolderDialog.SelectedPath, recordNameTextBox.Text);
            }
        }

        private void stop_recordButton_Click(object sender, EventArgs e)
        {
            changeButtonsStatus(false);
            
            if (new_record != null)
            {
                new_record.stopRecording();
                add_effect = new AddEffectForm(selectRecordFolderDialog.SelectedPath + "\\" + recordNameTextBox.Text);
                add_effect.Show();
            }
        }

        private void NewRecordForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
