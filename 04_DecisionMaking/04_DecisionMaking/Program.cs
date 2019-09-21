using System;

namespace _04_DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {

            #region If This Then That
            Header("The bool simple type");

            //? The bool keyword is an alias of System.Boolean. It is used to 
            //?     declare variables to store the Boolean values: true and false.
            bool someCondition = false;

            //? This creates a variable. The value type is an integer, so sum becomes an
            //?     strongly typed int variable when we instantiate it.

            //? After that, we use the boolean that we set to false above and if it is true
            //?     the program will run what is inside of the "if" statement. If it is false,
            //?     the code inside the if statement is false. Try changing the someCondition
            //?     bool to be true and false and see the difference in the output.
            var sum = 10;
            if (someCondition)
            {
                Console.WriteLine("The condition was true, so this is code is executed.");
                sum = sum + 5;
                sum = sum * 2;
            }
            Console.WriteLine(sum);

            Footer();
            #endregion

            #region Or Else!
            Header("Or Else Statement");



            //? This shows that if we have more than one line in a conditional, we need to 
            //?     put our code inside of {} brackets.
            //? Try changing what the value of answer is and see the results in the console.

            Console.WriteLine("What is the capital of Ohio?");
            Console.WriteLine();
            var answer = "Columbus"; //! please note that we use the .ToLower to ensure user input is processed
            if (answer.ToLower() == "columbus")
            {
                Console.WriteLine($"The answer given was {answer}.");
                Console.WriteLine("This is CORRECT!");
            }
            else
            {
                Console.WriteLine($"The answer given was {answer}.");
                Console.WriteLine("Sorry, that's not the right answer.");
            }

            Footer();
            #endregion

            #region Switch Statements
            Header("Switch Statements");

            uint guessedNumber = 1; // try different numbers to see resulting behavior
            switch (guessedNumber)
            {
                case 0:
                    Console.WriteLine("Sorry, 0 is not a valid guess.");
                    break;
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("You guessed low.");
                    break;
                case 4:
                    Console.WriteLine("You guessed the right number!");
                    break;
                default:
                    Console.WriteLine("You guessed high.");
                    break;
            }

            Footer();
            #endregion


            #region Logical Expressions
            #region Comparison Operators
            Header("Comparison Operators");
            DisplayLogicalExpressions();

            int x = 15;
            int y = 10;
            Console.WriteLine(x < 10);
            Console.WriteLine(y >= 0);

            Footer();
            #endregion

            #region Conditional Logical 
            Header("Conditional Logical");

            Console.WriteLine(String.Format("true && true   = {0}",true && true));    // true
            Console.WriteLine(String.Format("true && false  = {0}", true && false));   // false
            Console.WriteLine(String.Format("false && false = {0}", false && false));  // false
            Console.WriteLine(String.Format("true || true   = {0}", true || true));    // true
            Console.WriteLine(String.Format("true || false  = {0}", true || false));   // true
            Console.WriteLine(String.Format("false || false = {0}", false || false));  // false
            Console.WriteLine(String.Format("true ^ true    = {0}", true ^ true));     // false
            Console.WriteLine(String.Format("true ^ false   = {0}", true ^ false));    // true
            Console.WriteLine(String.Format("false ^ false  = {0}", false ^ false));   // false
            Console.WriteLine(String.Format("!true  = {0}", !true));           // false
            Console.WriteLine(String.Format("!false = {0}", !false));          // true


            int a = 5;
            int b = 10;
            Console.WriteLine();
            Console.WriteLine($"Example: a = {a}, b = {b}, conditional = (a < b) && (b < 20)");
            if ((a < b) && (b < 20))
            {
                Console.WriteLine("The entire condition is true, so we execute the code inside the {}");
            }

            Footer();
            #endregion

            #region Flags
            Header("Flags");
            int z = 10;
            bool isPositive = z > 0;
            if (isPositive)
            {
                Console.WriteLine("The FLAG is set to true!");
            }
            Footer();
            #endregion

            #endregion
        }

        private static void DisplayLogicalExpressions()
        {
            Console.WriteLine("==  // equal");
            Console.WriteLine("!=  // not equal");
            Console.WriteLine(">   // greater than");
            Console.WriteLine("<   // less than");
            Console.WriteLine(">=  // greater than or equal");
            Console.WriteLine("<=  // less than or equal");
        }

        private static void DisplayConditionalLogic()
        {
            Console.WriteLine("&&  // logical AND");
            Console.WriteLine("||  // logical OR");
            Console.WriteLine("!   // logical NOT (often read as 'bang')");
            Console.WriteLine("^   // logical XOR (exclusive OR)");
            Console.WriteLine();
            Console.WriteLine("true && true    // true");
            Console.WriteLine("true && false   // false");
            Console.WriteLine("false && false  // false");
            Console.WriteLine();
            Console.WriteLine("true || true    // true");
            Console.WriteLine("true || false   // true");
            Console.WriteLine("false || false  // false");
            Console.WriteLine();
            Console.WriteLine("true ^ true     // false");
            Console.WriteLine("true ^ false    // true");
            Console.WriteLine("false ^ false   // false");
            Console.WriteLine();
            Console.WriteLine("!true           // false");
            Console.WriteLine("!false          // true");
            Console.WriteLine();
        }

        private static void Footer()
        {
            // add two lines
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void Header(string header)
        {
            // add a header and an additional line.
            Console.WriteLine("-----------------------------" + header + "-----------------------------");
            Console.WriteLine();
        }
    }
}
