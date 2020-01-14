using System;


namespace _01_SimpleTypes
{


    #region Information about Simple or "Primative" Types
    /// <summary>
    /// We will discuss the simple types of variables in this program.
    /// 
    /// There are several that we will use regularly, some of these have been 
    ///     included in the reference materials.
    /// 
    /// However, do to the number of simple types, 
    ///     this will be where you will learn and use the simple type objects.
    ///     
    /// The "Boolean", called bool in C# is used to set a value of true or false.
    ///     This allows us to easily use it to make yes/no decisions and logical
    ///     statements.
    /// 
    /// The "integral" include:
    ///     
    ///     Type	    Size (in bits)	    Range
    ///     ------------------------------------------------------------------------------------
    ///     sbyte       8                   -128 to 127
    ///     byte        8                   0 to 255
    ///     short       16                  -32768 to 32767
    ///     ushort      16	                0 to 65535
    ///     int         32	                -2147483648 to 2147483647
    ///     uint        32	                0 to 4294967295
    ///     long        64	                -9223372036854775808 to 9223372036854775807
    ///     ulong       64	                0 to 18446744073709551615
    ///     char        16	                0 to 65535
    ///     float       32	                7 digits	1.5 x 10-45 to 3.4 x 1038
    ///     double      64	                15-16 digits	5.0 x 10-324 to 1.7 x 10308
    ///     decimal     128	                28-29 decimal places    1.0 x 10-28 to 7.9 x 1028
    ///     
    /// 
    /// The "string" is simple types that is like an array of 'char' 
    /// 
    /// You may be wondering how you could represent a backslash character in your code. 
    ///     We have to escape that too by typing two backslashes, as in ‘\\’.
    /// 
    /// 
    ///     Escape Sequence             Meaning
    ///     -----------------------------------------------------
    ///     \’                          Single Quote
    ///     \”                          Double Quote
    ///     \\                          Backslash
    ///     \0                          Null, not the same as the C# null value
    ///     \a                          Bell
    ///     \b                          Backspace
    ///     \f                          form Feed
    ///     \n                          Newline
    ///     \r                          Carriage Return
    ///     \t                          Horizontal Tab
    ///     \v                          Vertical Tab
    ///     
    /// Another useful feature of C# strings is the verbatim literal, 
    ///     which is a string with a @ symbol prefix, as in @”Some string”. 
    ///     Verbatim literals make escape sequences translate as normal characters 
    ///     to enhance readability.
    ///     
    /// </summary>
    //!     The char type is a Unicode character, as defined by the Unicode Standard
    //!     and this is the reason why it has a "range" and is considered an integral type.
    #endregion
    class Program
    {

        //    #region Example and Explaination

        static void Main(string[] args)
        {

            Notebook myNoteBook = new Notebook();

            myNoteBook.CreateMessage("My Message Page 1");
            myNoteBook.CreateMessage("My Message Page 2");
            myNoteBook.CreateMessage("My Message Page 3");
            myNoteBook.CreateMessage("My Message Page 4");
            myNoteBook.CreateMessage("My Message Page 5");
            myNoteBook.CreateMessage("My Message Page 6");


            myNoteBook.DeleteMessage(2);
            myNoteBook.DeleteMessage(2);

            myNoteBook.UpdateMessage(1, "My New Page 1");

            myNoteBook.ThrowAway();




































            //        if (!_pratice)
            //        {

            //            //? To declare any primative type (or simple typle) variable we always
            //            //? use the same format. We can also chose to set the value of the new variable,
            //            //? or do this at a later place in our program.
            //            //? 
            //            /*!         {type} {name} = {value}; */
            //            //!         {type} {name};



            //            // ------------------------ Boolean ------------------------
            //            bool myBoolValue = false; // This is an example with value being set when we create it.

            //        Console.WriteLine(String.Format("boolVariable value: {0}, {1}, {2}", myBoolValue, "blue", "green"));



            //        // make your own boolean

            //        // print to screen



            //        // ------------------------ signed numbers ------------------------
            //        // Remember the range and use of each of these variables.
            //        //! If you try to put a number that is too big or small into these, your program will crash
            //        //
            //        //! ALSO: int variables will not have decimal places. 
            //        //!           the decimal place will be removed, or your program will crash
            //        sbyte sbyteVariable = 5; 
            //        short shortVariable;        // This is an example with value being set when we create it.
            //        int intVariable = 60;       
            //        long longVariable;
            //        float floatVariable;
            //        double doubleVariable;
            //        decimal decimalVariable;

            //        Console.WriteLine(String.Format("sbyteVariable value: {0}", sbyteVariable));
            //        Console.WriteLine(String.Format("intVariable value: {0}", intVariable));

            //        // ------------------------ unsigned numbers ------------------------
            //        // This value of the next four variables can never be negative. 
            //        //! Your program will crash if this is attempted.
            //        byte byteVariable;
            //        ushort ushortVariable = 60;  
            //        uint uintVariable;
            //        ulong ulongVariable;


            //        // ------------------------ char ------------------------
            //        //! It is important to mention that we use the ' ' instead of " " with char variables
            //        char charVariable = 'b';
            //        Console.WriteLine(String.Format("charVariable value: {0}", charVariable));


            //        // ------------------------ string ------------------------
            //        string stringVariable = "Hello World!";
            //        Console.WriteLine(String.Format("stringVariable value: {0}", stringVariable));


            //        }
            //        else
            //        {
            //            PracticeMethod();
            //        }


            //    }


            //    #endregion

            //    #region Practice Method  - Try to create some of your own variables and print them to the Console.
            //    // When you want to try and practice, change the value of this to false.
            //    // Use the method
            //    private static bool _pratice = false;
            //    static private void PracticeMethod()
            //    {
            //        // This will be where your code goes.


        }
        //    #endregion
    }
}
