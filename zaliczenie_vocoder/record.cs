using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Audio;
using NAudio;
using NAudio.Wave;
using System.Threading;
using System.Windows.Forms;

namespace vocoder
{
    public class Record
    {
        private WaveIn source;
        private WaveFileWriter waveFile;
        private AudioFileReader reader;

        public Record()
        {
            source = new WaveIn();
            source.WaveFormat = new WaveFormat(44100, 1);
        }

        public void recordAudio(bool record)
        {
            //if (record)
                
        }

        public void saveFile()
        {
        }

        public void openFile(String path)
        {
            this.reader = new AudioFileReader(path);
            play(100);
        }

        public void play(int time)
        {
            if (this.reader != null)
            {
                IWavePlayer player = new WaveOut(WaveCallbackInfo.FunctionCallback());
                player.Init(this.reader);
                player.Play();
                if (time > 0) { Thread.Sleep(time); }// for pasued thread after 5sec
                player.Stop();
                player.Dispose();
            }
            else
            {
                MessageBox.Show("You didn't select any audio file to play");
            }
        }
    }
}
