using System;
using _10_Interfaces.Interfaces;

namespace _10_Interfaces.Phones
{
    internal class GalaxyA30 : IPhone
    {
        /// <summary>
        /// The private variable and constuctor would usually be in a base class for all the
        /// phone types. We would call this class Phone, and put all the shared code there so
        /// we are not writing code over and over and over again. However, for this demo, I have chosen
        /// to leave them seperate so it can be seen how things are being done differently in each
        /// of the classes.
        /// </summary>
        private string _phoneType;
        public GalaxyA30()
        {
            _phoneType = this.GetType().ToString().Replace("_10_Interfaces.Phones.", "");
        }
        public void Dial()
        {
            Console.WriteLine($"Dailing the phone from my {_phoneType}");
            Console.WriteLine("     No one answered my phone call.");
        }

        public void PlayGame()
        {
            Console.WriteLine($"Playing a game on my {_phoneType}");
            Console.WriteLine("     VICTORY!");
        }

        public void Ring()
        {
            Console.WriteLine($"!!!!! My {_phoneType} is ringing.");
            Console.WriteLine("     MUTE!!!!!!!!!  I'm going back to playing my game now.");
        }
    }
}