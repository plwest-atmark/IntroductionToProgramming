using System;

namespace _15_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Basic Try/Catch

            // simple example of exception handling.
            try
            {
                // code that may throw an exception here
                int x = int.Parse(Console.ReadLine());
            }
            catch (System.Exception ex)
            {
                // handle the exception here
                Console.Write(ex.ToString());
            }

            #endregion

            #region Throwing Exceptions again (Bubbling up)

            // We can continue to throw exceptions in more complex code... this is called "bubbling up"
            try
            {
                try
                {
                    int x = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException ex)
                {
                    Console.Write(String.Format("This is the first time the exception was trown: {0}",
                                                        ex.ToString()));
                    //! do something here before "re-throwing"
                    throw;
                }
            }
            catch (Exception ex)
            {

                Console.Write(String.Format("This is the second time the exception was trown: {0}",
                                                    ex.ToString()));
            }

            #endregion

            #region Custom Exceptions

            // We can also throw our own exceptions in code if we want to.
            try
            {
                // code that may throw an exception here
                int age = int.Parse(Console.ReadLine());
                if (age < 18 || age > 150)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 18 and 150.", nameof(age));
                }
            }
            catch (System.Exception ex)
            {
                // handle the exception here
                Console.Write(ex.ToString());
            }

            #endregion

            #region Finally Block

            // Finally block (try...catch...finally)
            try
            {
                throw new Exception("Let's play catch!");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // This code will always run
                // even if your catch block re-throws
                Console.WriteLine("FINALLY!");
            }
            // Code here will run only if catch doesn't re-throw
            Console.WriteLine("Still ran.");

            #endregion

            #region Exception Filtering

            // Filter the exception with multiple catch blocks
            try
            {
                string thisIsNull = null;
                Console.WriteLine(thisIsNull.Length);  //? This will "throw" a NullReferenceException

                //throw new Exception("This is a fake Exception"); //? This will "throw" a regular Exception
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException Thrown:***************");
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)  //! The "base" System.Exception will ALWAYS stop the "catch chain", 
                                  //! so anything after this will not be available for use
            {
                Console.WriteLine("Exception Thrown::***************");
                Console.WriteLine(ex.ToString());
            }
            //catch(DivideByZeroException ex)  
            //{
            //? This will not compile, because it is after the "Exception"
            //}

            #endregion

        }
    }
}
