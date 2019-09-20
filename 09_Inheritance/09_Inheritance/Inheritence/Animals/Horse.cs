using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Inheritance.Animals
{
    class Horse : Animal // See the "Cat" class for details
    {
        public override void MakeAnimalSound()
        {
            Console.WriteLine("Neeeeeh!");
        }
        public override void PerformAnimalAction()
        {
            Console.WriteLine("Swat flies with tail.");
        }
    }
}
