using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Game_mini
{
    public class Sound
    {
        private static Sound instance;
        private static bool flag = true;
        private static SoundPlayer mainSound = new SoundPlayer("funkid.wav");
        private static SoundPlayer correctSound = new SoundPlayer("correct.wav");
        private static SoundPlayer incorrectSound = new SoundPlayer("incorrect.wav");

        public static Sound Instance
        {
            get { if (instance == null) instance = new Sound(); return Sound.instance; }
            private set { Sound.instance = value; }
        }

        public static bool Flag { get => flag; set => flag = value; }
        public static SoundPlayer MainSound { get => mainSound; set => mainSound = value; }
        public static SoundPlayer CorrectSound { get => correctSound; set => correctSound = value; }
        public static SoundPlayer IncorrectSound { get => incorrectSound; set => incorrectSound = value; }

        private Sound() { }
    }
}
