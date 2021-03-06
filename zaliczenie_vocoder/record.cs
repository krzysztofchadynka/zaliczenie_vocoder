﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Audio;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using System.Threading;

namespace vocoder
{
    public class Record
    {
        private WaveIn source;
        private WaveFileWriter waveFile;
        private NewRecordForm record_form;
        private AudioFileReader reader;
        private IWavePlayer player;

        public Record()
        {
            source = new WaveIn();
            source.WaveFormat = new WaveFormat(44100, 1);
            record_form = new NewRecordForm();
        }

        public void recordAudio(string path, string record_name)
        {
            saveFile(path, record_name);
            source.StartRecording();
        }

        public void stopRecording()
        {
            source.StopRecording();
        }

        public void saveFile(string path, string record_name)
        {
            source.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
            source.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);
            waveFile = new WaveFileWriter(@path + "\\" + record_name + ".wav", source.WaveFormat);
        }

        void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                waveFile.Flush();
            }
        }

        void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (source != null)
            {
                source.Dispose();
                source = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();
                waveFile = null;
            }
        }

        public void openFile(String path)
        {
            Console.Out.WriteLine("Path: " + path);
            this.reader = new AudioFileReader(path);
        }

        public void play()
        {
            if (this.reader != null)
            {
                player = new WaveOut(WaveCallbackInfo.FunctionCallback());
                player.Init(this.reader);
                player.Play();
            }
            else
            {
                MessageBox.Show("You didn't select any audio file to play");
            }
        }

        public void stop()
        {
            player.Stop();
            player.Dispose();
        }
    }
}
