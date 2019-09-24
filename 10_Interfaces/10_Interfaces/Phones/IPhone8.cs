using _10_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Interfaces.Phones
{
    class IPhone8 : IPhone
    {
        private string _phoneType;
        public IPhone8()
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
