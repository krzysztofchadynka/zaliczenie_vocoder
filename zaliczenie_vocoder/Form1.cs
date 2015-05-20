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

        public MainForm()
        {
            InitializeComponent();
        }

        private void new_record_bnt_Click(object sender, EventArgs e)
        {
            NewRecordForm form = new NewRecordForm();
            form.Show();
        }
    }
}
