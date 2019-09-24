using System;
using System.Text;

namespace _05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Expression-Based Loops
            Header("Expression-Based Loops");

            //! Example 1: Use conditional logic to make a guessing game
            //!            that will continue until the number is correct.
            //!
            //! This kind of "loop till it's right" can be effective in some cases,
            //! However, we must ensure that the program will eventually meet the
            //! conditions of the while so we exit the loop and our program can continue.
            int numberToGuess = new Random().Next(1, 101); // a number from 1 to 100
            int currentGuess = 0; // start with an incorrect guess
            while (currentGuess != numberToGuess)
            {
                Console.WriteLine("Guess the number (1 to 100): ");
                currentGuess = int.Parse(Console.ReadLine());
                if (currentGuess < numberToGuess)
                {
                    Console.WriteLine("You guessed too low! Try again!");
                }
                if (currentGuess > numberToGuess)
                {
                    Console.WriteLine("You guessed too high! Try again!");
                }
            }
            Console.WriteLine("You got it! Good job!");

            Footer();
            #endregion

            #region Using break to exit a loop (infinite loops)
            Header("Using break to exit a loop (infinite loops)");
            //! Example 1: This is an example of a loop that does not function
            //!            properly and will never exit the loop. This is how many programs
            //!            freeze and stop working.
            //numberToGuess = new Random().Next(1, 101); // a number from 1 to 100
            //while (true) // this sets up an infinite loop, since true will always evaluate to true
            //{
            //    Console.WriteLine("Guess the number (1 to 100): ");
            //    currentGuess = int.Parse(Console.ReadLine());
            //    if (currentGuess == numberToGuess) break;
            //    if (currentGuess < numberToGuess)
            //    {
            //        Console.WriteLine("You guessed too low! Try again!");
            //    }
            //    if (currentGuess > numberToGuess)
            //    {
            //        Console.WriteLine("You guessed too high! Try again!");
            //    }

            //    //! This line here will FORCE you out of the loop even if the conditions
            //    //! for the loop are never met. The break command can be used with all the
            //    //! different types of loops.
            //    // break;
            //}
            //Console.WriteLine("You got it! Good job!");

            Footer();
            #endregion


            #region Looping a Known Number of Times
            Header("Looping a Known Number of Times", addMargin: false);
            #region For Loops
            Header("For Loops");

            //! Example 1: Loop using a for loop 10 times. Each time it will print
            //!            the value of the "counter" variable.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Footer();
            #endregion

            #region Starting From Different Values
            Header("Starting From Different Values");

            //! Example 1: Loop 5 times, starting from 5 and going to 10.
            //!            Sometimes we need to do something a number of times,
            //!            but the intial values are not known. We perform a calculation
            //!            to determine the "endingNumber" and then do a for loop.
            int startingNumber = 5; // change to whatever value you want to start from
            int endingNumber = startingNumber + 5; // change to whatever number you want to be the last displayed
            for (int i = startingNumber; i <= endingNumber; i++)
            {
                Console.WriteLine(i);
            }

            Footer();
            #endregion

            #region Counting Up By Different Increments
            Header("Counting Up By Different Increments");

            //! Example 1: Loop through the numbers 1 to 50, and print the odd numbers.
            //!            Because of the need to only print the odd numbers, there is no
            //!            reason to increment by 1, but we can do it by 2 at a times to
            //!            avoid having to do extra work that has no benefit.
            Console.WriteLine("Odd Numbers from 1-49:");
            for (int i = 1; i < 50; i += 2)
            {
                Console.WriteLine(i);
            }

            Footer();
            #endregion

            #region Counting Down By Different Increments
            Header("Counting Down By Different Increments");


            //! Example 1: Count down from 10 using a for loop.
            //!            We are not limited in only incrementing up,
            //!            but can also decrement(--)
            Console.WriteLine("Countdown started...");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("LIFTOFF!");

            Footer();
            #endregion

            #region Nested Loops
            Header("Nested Loops");

            //! Example 1: Use a "nested loop" to create a multiplication table.
            //!            There is no limit to the amount of loops we put inside of
            //!            other loops. However, they must use a different "counter" name
            //!            for each. In this case, we are using i for the "outer" loop and
            //!            j for the "inner loop".
            Console.WriteLine("Multiplication Table:");
            Console.WriteLine(" 0|  1  2  3  4  5  6  7  8  9");
            Console.WriteLine("-------------------------------");
            for (int i = 1; i < 10; i++)
            {
                Console.Write($" {i}|");
                for (int j = 1; j < 10; j++)
                {
                    string product = (i * j).ToString();
                    Console.Write(product.PadLeft(3));
                }
                Console.WriteLine();
            }

            Footer();
            #endregion

            #endregion

        }


        #region Helpers
        private static void Footer()
        {
            // add two lines
            Console.WriteLine();
            Console.WriteLine();
        }
        private static void Header(string header, int width = 75, bool addMargin = true)
        {
            // add a header and an additional line.

            var sideSize = (width - header.Length) / 2;
            string side = new string('-', sideSize);

            Console.WriteLine(side + " " + header + " " + side);
            if (addMargin)
                Console.WriteLine();
        }
        #endregion
    }
}
