using System;

namespace _07_Methods
{
    /// <summary>
    /// In this program we will learn the basics of "Methods" and how they are used.
    /// 
    /// Each method has a signature.  The signature of a method allows the program to identify
    ///     the method and know where to go when it is called.   You can consider it an address
    ///     for the method inside of the code.
    ///     
    ///     Method signatures are always in the following format:
    ///     
    ///     {access modifier} {return type} {method name}({arguments})  
    ///     
    /// Please note that when creating methods it is important to "name" them for what they do.
    ///     If I have a method that Adds two integer numbers, then the method name should be Add 
    ///     and the signature of this method would be:
    ///     
    ///             public int Add(int a, int b)
    ///             
    ///     In this example, the method is public, it will return an interger value, and when you call
    ///         this method you have to provide it 2 integer numbers.
    ///     
    /// Each method has an "access modifier", this is part of the signature to tell the program
    ///     who can use the method.  It is like conversation.  We tell some people information that
    ///     we do not tell other people.  For information we tell everyone, that's "public".  For information
    ///     that we only tell our family, that's "internal". For information we do not tell anyone, 
    ///     that's "private"
    ///     
    /// In this example I have created a "MyMethodsClass" that has some methods that only prints
    ///     some text to the Console depending on the Method that is called from the Main Method.
    ///     
    /// NOTE:  The method "static void Main(string[] args)" is a very special Method is is called when any
    ///             program is started.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // First, we have to create a "class" that has methods we can "call" or "execute".
            MyMethodsClass methods = new MyMethodsClass();


            // Then we use the name we gave your "instance" of the class, and "call" what we need to use.
            methods.ThisIsAPublicMethod();
            NewLine(1);
            methods.ThisIsAnInternalMethod();
            NewLine(1);
            methods.ThisIsAPublicMethodThatCallsAPrivateMethod();
            NewLine(1);
        }

        #region Formatting
        static public void NewLine(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine();
            }
        }
        #endregion
    }

    class MyMethodsClass
    {
        public void ThisIsAPublicMethod()
        {
            //? This method has a "public" access modifier. Anyone that creates a "MyMethodsClass" can use
            //?     this method.
            Console.WriteLine(@"This is a public method called ""ThisIsAPublicMethod"".  It has no return value.");
        }

        internal void ThisIsAnInternalMethod()
        {
            //? This method has an "internal" access modifier. Anyone that creates a "MyMethodsClass"
            //?     AND is in the same namespace can use this method.
            Console.WriteLine(@"This is a internal method called ""ThisIsAnInternalMethod"".  It has no return value.");
        }

        private void ThisIsAPrivateMethod()
        {
            //? This method has a "private" access modifier. No one except for THIS class
            //?     can call or use this method.  Private methods are a good way to "keep code clean"
            //?     In the example projects, I have created a method that I use over and over
            //?     that creates a "new line" as many times as I want.  I would have coded a LOT more
            //?     lines of code in the programs and it would be harder to read if I had not make this
            //?     method.  Sometimes we call private methods "helpers".
            Console.WriteLine(@"This is a private method called ""ThisIsAPrivateMethod"".  It has no return value.");
        }

        public void ThisIsAPublicMethodThatCallsAPrivateMethod()
        {
            //? Using public methods, we can give access to private methods IF WE WANT.  Sometimes
            //?      we will use private methods this way when we have to decide what to allows another
            //?      piece of code to do. This can be a good practice, and you will see this when you
            //?      begin making larger programs.
            ThisIsAPrivateMethod();
        }


        #region Formatting
        static public void NewLine(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine();
            }
        }
        #endregion
    }



}
