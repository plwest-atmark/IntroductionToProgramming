using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Classes
{
    /// <summary>
    /// This is the Calculator class.  It will contain "Methods" that will perform "calculations".
    /// 
    /// It should function "similar" to a real life calculator when it is finished.
    /// 
    /// To use this, another "class" will create an "instance" of this class.  Meaning it will create a new Calculator.
    /// 
    /// To do this you use the following code:
    /// 
    /// Calculator calculator = new Calculator();
    /// 
    /// You can name your variable whatever you thing is appropriate. In other words we could also create one with the following:
    /// 
    /// Calculator calc = new Calculator();
    /// 
    /// 
    /// To use the Calculator, you use the "name" you gave it and "call a method" that is inside of it.
    /// 
    /// You have to give it the correct "arguments" or "parameters".  Each method can return a value. This value should be placed
    ///     inside a variable in the other class.
    ///     
    /// For example:
    /// 
    /// Calculator calc = new Calculator();
    /// var a = 5;
    /// var b = 6;
    /// 
    /// var sum = calc.AddInt(a,b);
    /// Console.WriteLine($"The sum of {a} and {b} = {sum}.");
    /// 
    /// This will "use" the Calculator called calc to add two integer variables together. It will "return" an int as an answer.
    /// 
    /// </summary>
    public class Calculator
    {

        // This is a "private" variable. This is also called a "field" and is ONLY used by this class.
        // If there are 100 calculators created, EACH calculator has it's own _random field.
        //
        // A variable of the "Random" type is that will generate a "random" number.
        // We can set the random to return different types of random numbers.
        private Random _random;

        /// <summary>
        /// This is the "construtor".  Notice that the name of the class and the name of this "Method" are the same.d
        /// 
        /// This Method will ALWAYS be called when you "new" calcuator is created.
        /// 
        /// We can have as many of these as we want.  If I want to create 10000 calculators, I can do this.
        /// 
        /// A class will ALWAYS have a purpose.  This class is called "Calculator", so what do you think it should do?
        /// </summary>
        public Calculator()
        {

            // Since we have a field "_random", it is inside of the constructor that we will
            // "initiate" these fields.  This is not always done, but for good coding practices, it is usually followed.
            _random = new Random();
        }


        /// <summary>
        /// This method will add two integers together and return the answer to the "caller"
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int AddInt(int a, int b)
        {
            // Notice that we do not HAVE to create a variable to return when we are done with a method that has
            // a return type.  We can return it directly as shown here.
            return a + b;
        }

        /// <summary>
        /// 
        /// This method will add two double variables and return the answer to the caller.  We need a seperate Method for doubles because we cannot
        /// add doubles with the AddInt(int a, int b) method.
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double AddDouble(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Again, we need another method to return the value as a decimal.  This is because C# is a "strongly typed" language.
        /// 
        /// We MUST decide what a variable type will be, and we MUST use that type. We cannot mix them or our program will not work.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public decimal AddDecimal(decimal a, decimal b)
        {
            return a + b;
        }


        // Let's add the methods for "subtraction", "multiplication" and "division" below this line

        // ----------------------------------------------------------------------------------------


        // subtraction methods
        public int SubInt(int a, int b)
        {
            return a - b;
        }

        public double SubDouble(double a, double b)
        {
            return a - b;
        }

        public Decimal SubDecimal(decimal a, decimal b)
        {
            return a - b;
        }

        // multiplicaton methods
        public int MulInt(int a, int b)
        {
            return a * b;
        }

        public int MulInt(int a, int b, int c)
        {
            return a * b * c;
        }

        public double MulDouble(double a, double b)
        {
            return a * b;
        }
        
        public double MulDouble(double a, double b, double c)
        {
            return a * b * c;
        }

        public double MulDouble(double a, double b, double c, double d)
        {
            return a * b * c * d;
        }

        public decimal MulDecimal(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal MulDecimal( decimal a, decimal b, decimal c)
        {
            return a * b * c;
        }
        // division methods

        public int DivInt(int a, int b)
        {
            return a / b;
        }
        
        

        public double DivDouble(double a, double b)
        {
            return a / b;
        }
        
        public decimal DivDecimal(decimal a, decimal b)
        {
            return a / b;
        }

        
        public int RemInt(int a, int b)
        {
            return a % b;
        }
        
        public double  RemDouble (double a, double b)
        {
            return a % b;
        }

        public decimal RemDecimal(decimal a, decimal b)
        {
            return a % b;
        }

        public int PowInt(int a, int b)
        {
            return a ^ b;
        }
       
        
        
    }
}
