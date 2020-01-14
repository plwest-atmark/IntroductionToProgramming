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
            bool someCondition = true;

            //? This creates a variable. The value type is an integer, so sum becomes an
            //?     strongly typed int variable when we instantiate it.
            var sum = 10;

            //? After that, we use the boolean that we set to false above and if it is true
            //?     the program will run what is inside of the "if" statement. If it is false,
            //?     the code inside the if statement is false. Try changing the someCondition
            //?     bool to be true and false and see the difference in the output.
            Console.WriteLine($"The value of our conditional is {someCondition}");
            if (someCondition) // this is where we check our "conditional"
            {
                Console.WriteLine("The condition was true, so this is code is executed.");
                sum = sum + 5;
                sum = sum * 2;
            }
            // This will be 10 if our condition is false, and 30 if the condition is true
            // This is how we can make changes to the flow of our program based on the
            // "condition" of a situation.
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


            //! Example 1: Using a switch statement to check the value of a number.

            //! The switch statement is used to allow us to check a variable
            //! and then decide to do one of many different options. This can be useful,
            //! but we should never use this to check a large number of values.  If
            //! we find ourselves doing that in our code, then there is probably a better
            //! way of determining the logical path for our code.
            uint guessedNumber = 1; // try different numbers to see resulting behavior
            switch (guessedNumber) // This is where we put the variable, method, or value to be checked.
            {
                case 0:  // each case will be checked in order. This one checks to see if the value is 0
                    Console.WriteLine("Sorry, 0 is not a valid guess.");
                    break;  // we use a break statement to exit out of the switch
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


            //! Example: Use a logical expression to make a true/false decision.
            
            //! Using Comparison Operators, we can use other types of variables
            //!     to determine a true/false condition and make a decision based
            //!     on this for executing code.
            int x = 15;
            int y = 10;
            Console.WriteLine(String.Format("x < 10 = {0}", x < 10));
            Console.WriteLine(String.Format("y >= 0 = {0}", y >= 0));

            Footer();
            #endregion

            #region Conditional Logical 
            Header("Conditional Logical");

            //! Example 1: This shows the outcome of doing the following operations.
            //!
            //! NOTE: We are not limited to just using these logic keywords with just "true"
            //!       and "false", but can use anything that is a bool type. Methods can also
            //!       be used if their return type is a bool.

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

            //! "Flags" are nothing more than Boolean values that we name in such a way
            //!     that it's more of a question than a variable name.  In this example,
            //!     "isPositive" is a good name for a "flag" because it expresses the
            //!     condition in a simple word using the "is" to make it a question. 
            //!     Some examples would be "isValid", "isAuthorized", etc..
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

        #region Helpers
        private static void DisplayLogicalExpressions()
        {
            Console.WriteLine("==  // equal");
            Console.WriteLine("!=  // not equal");
            Console.WriteLine(">   // greater than");
            Console.WriteLine("<   // less than");
            Console.WriteLine(">=  // greater than or equal");
            Console.WriteLine("<=  // less than or equal");
            Console.WriteLine();
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
        #endregion
    }
}
