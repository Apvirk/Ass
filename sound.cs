using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameshoot
{
    class sound
    {
        public void play_back_sound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\hp\Downloads\gun-gunshot-01.wav");
            player.Play();
        }
            
        public void shoot_sound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\hp\Downloads\gun-gunshot-01.wav");
            player.Play();
        }
        public void spin_sound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\hp\Downloads\spin.wav");
            player.Play();


        }
        public void load_sound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\hp\Downloads\gun-cocking-01.wav");
            player.Play();
        }
    }
}
