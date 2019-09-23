using System;
using _10_Interfaces.Interfaces;

namespace _10_Interfaces.Phones
{
    internal class GalaxyA30 : IPhone
    {
        private string _phoneType;
        public GalaxyA30()
        {
            _phoneType = this.GetType().ToString().Replace("_10_Interfaces.Phones.", "");
        }
        public void Dial()
        {
            Console.WriteLine($"Dailing the phone from my {_phoneType}");
        }

        public void PlayGame()
        {
            Console.WriteLine($"Playing a game on my {_phoneType}");
        }

        public void Ring()
        {
            Console.WriteLine($"!!!!! My {_phoneType} is ringing.");
        }
    }
}