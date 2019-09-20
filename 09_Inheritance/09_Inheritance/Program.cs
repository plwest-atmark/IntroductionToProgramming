using _09_Inheritance.Animals;
using System;
using System.Collections.Generic;

namespace _09_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //? We have a couple of ways to create lists with complex objects.
            //?     This is a standard way since usually we don't know exactly what we
            //?     need for a list when it's first created. However, if we DO know
            //?     what we need when we create the list, we will "instantiate" the
            //?     list with values right away.

            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Horse());

            //? This is a good way to instantiate. It's easy to read.
            //?     If you want to use this method for your list creation, there
            //?     no problem with doing it this way.
            //List<Animal> animals = new List<Animal>
            //{
            //    new Cat(),
            //    new Dog(),
            //    new Horse()
            //};

            foreach (Animal animal in animals)
            {
                Console.WriteLine();
                Console.WriteLine($"-------------- {animal.AnimalName} --------------");

                animal.MakeAnimalSound();
                animal.PerformAnimalAction();
                animal.Sleep();
                Console.WriteLine();
            }

        }
    }
}
