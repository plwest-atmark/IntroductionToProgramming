using _10_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Interfaces.Phones
{
    class IPhone6 : IPhone
    {
        private string _phoneType;
        public IPhone6()
        {
            _phoneType = this.GetType().ToString().Replace("_10_Interfaces.Phones.", "");
        }
        public void Dial()
        {
            Console.WriteLine($"Dailing the phone from my {_phoneType}");
            Console.WriteLine("     Phone failed to dial!");
        }

        public void PlayGame()
        {
            Console.WriteLine($"Playing a game on my {_phoneType}");
            Console.WriteLine("     Phone crashed!");
        }

        public void Ring()
        {
            Console.WriteLine($"!!!!! My {_phoneType} is ringing.");
            Console.WriteLine("     This is the phone company, get a new phone!");
        }
    }
}
