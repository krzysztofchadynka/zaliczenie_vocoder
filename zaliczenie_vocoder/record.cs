﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Audio;
using NAudio;
using NAudio.Wave;

namespace vocoder
{
    class Record
    {
        private WaveIn source;
        private WaveFileWriter waveFile;

        public Record()
        {
            source = new WaveIn();
            source.WaveFormat = new WaveFormat(44100, 1);
        }

        public void recordAudio()
        {

        }

        public void saveFile()
        {
        }

        public void openFile()
        {
           
        }
    }
}
