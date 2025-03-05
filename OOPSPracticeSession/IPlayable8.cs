using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    interface IPlayable8
    {
        void Play(); // Interface method (must be implemented in derived classes)
    }

    class MusicPlayer : IPlayable8
    {
        public void Play()
        {
            Console.WriteLine("Playing music...");
        }
    }

    class VideoPlayer : IPlayable8
    {
        public void Play()
        {
            Console.WriteLine("Playing video....");
        }
    }

}
