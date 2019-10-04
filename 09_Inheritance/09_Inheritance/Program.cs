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


            // Due to inheritance and polymorphism, it does not matter which "child" class we use, we can use them all
            // as if they are the base class Animal. This means that the classes that inherit a base class can then be used
            // in the same way regarless of how they actually do the work.  In this case, each of our Animals perform different
            // actions that are written to the Console. 

            //? A real world example would be a logging system.  We can create different logging systems with a base logging
            //? class, and then log information differently depending on which one we use.  However, since they inherit the 
            //? same base class, we can use them the same way. This allows the "consumer" of the class to not worry about HOW
            //? the logging system works or where it logs. It's not the "consumers" job to worry about this. It's the logging
            //? systems responsiblity.  This is a means to change HOW something works, but not change the user of the system.
            //? This is a powerful tool and is used extensively through software development and Object-Oritented Programming.
            foreach (Animal animal in animals)
            {
                Console.WriteLine();
                Console.WriteLine($"-------------- {animal.AnimalName} --------------");

                //! It does not matter which "kind" of animal it is, we use the same method for all animals and they
                //! perform different actions based on what they have been implemented to do.
                animal.MakeAnimalSound();
                animal.PerformAnimalAction();
                animal.Sleep();
                Console.WriteLine();
            }

        }
    }
}
