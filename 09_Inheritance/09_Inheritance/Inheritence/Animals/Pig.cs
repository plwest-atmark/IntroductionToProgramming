using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Inheritance.Animals
{
    class Pig : Animal
    {
        public Pig() : base()
        {

        }

        public override void MakeAnimalSound()
        {
            Console.WriteLine("Oink!");
        }
        public override void PerformAnimalAction()
        {
            Console.WriteLine("have like and dislike about food");
        }
    }
}
