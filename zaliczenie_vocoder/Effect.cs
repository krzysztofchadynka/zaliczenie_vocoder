using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace vocoder
{
    class Effect
    {
        private string file_patch;

        public Effect(string file_patch)
        {
            if (!file_patch.Contains(".wav")) { file_patch += ".wav"; }
            this.file_patch = file_patch;
        }

        public string getNewPath()
        {
            return Path.GetDirectoryName(this.file_patch) + "\\" + Path.GetFileNameWithoutExtension(this.file_patch) + "_output.wav";
        }

        public void GenerateQuery(int tempo = 0, int pitch = 0, int rate = 0)
        {
            Process proccess = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = @"C:\Windows\System32\cmd.exe";
            startInfo.Arguments = "/c soundstretch " + this.file_patch + " " + Path.GetDirectoryName(this.file_patch) 
                + "\\"+ Path.GetFileNameWithoutExtension(this.file_patch)+"_output.wav -tempo=" + tempo + 
                " -pitch=" + pitch + 
                " -rate=" + rate;
            proccess.StartInfo = startInfo;
            proccess.Start();
        }
    }
}
