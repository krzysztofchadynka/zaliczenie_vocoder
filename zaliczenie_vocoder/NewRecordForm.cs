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
        }

        private void stop_recordButton_Click(object sender, EventArgs e)
        {
            changeButtonsStatus(false);
        }

        private void NewRecordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
