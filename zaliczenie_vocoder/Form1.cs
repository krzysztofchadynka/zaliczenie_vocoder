using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vocoder
{
    public partial class MainForm : Form
    {
        public static string patch;
        public Record record;

        public MainForm()
        {
            InitializeComponent();
            record = new Record();
        }

        private void new_record_bnt_Click(object sender, EventArgs e)
        {
            NewRecordForm form = new NewRecordForm();
            form.Show();
        }

        private void bnt_open_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "WAV files (*.wav)|*.wav|All files (*.*)|*.*"; 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AddEffectForm form = new AddEffectForm(ofd.FileName);
                form.Show();
            }
        }

        private void bnt_close_app_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
