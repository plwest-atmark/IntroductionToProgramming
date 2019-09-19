using System;
using System.Collections;
using System.Collections.Generic;

namespace _02_ArraysAndLists
{

    /// <summary>
    /// Arrays and Lists are what we call "collections".  Each have their benefits and disadvantages.
    /// 
    /// In this program you will learn the differences between the many types of "collections".
    /// 
    /// The following are C# collection types:
    /// 
    ///     Type of Collection                  Collection Purpose
    ///     ----------------------------------------------------------------------
    ///     Array                               Used when we know exactly how many items we have.
    ///                                         Also have better performance than other collections.
    ///                                         
    ///     List                                Used when we need to dynamically change the size of
    ///                                         a collection. This is the most commonly used collection.
    ///     
    ///     Dictionary                          Dictionaries are "key/value" pairs. They have 2 parts.
    ///                                         The "key" is used to access the "value". Keys MUST be
    ///                                         unique, so this makes it idea for things like "settings",
    ///                                         or anything that has an ID number that is unique.
    ///                                         
    ///     HashTable                           This is very similar to a Dictionary and is also a "key/value"
    ///                                         pair collection. However, unlike the Dictionary, the hashtable
    ///                                         can store anything and does not use the ICollection
    ///     
    ///     Queue                               A Queue is a collection this is called "first in, first out"
    ///                                         You can think of this like a line of people at a store.
    ///                                         The first person in line gets service first, and the last person
    ///                                         gets service last.  These can be usedful because we can ensure 
    ///                                         what the order of operations without having to worry about details.
    ///                                         As long as we put everything in the queue properly, we get the
    ///                                         correct results in the end.
    ///     
    ///     Stack                               A Stack is a collection that is called "first in, last out"
    ///                                         It is exactly like a "Stack" of books, you can only take the top
    ///                                         book off of the stack at a time. To get to the bottom, we need
    ///                                         to remove everything on top of it. This is used for things like
    ///                                         "undo", since you want to get the last thing first and "reverse"
    ///                                         the order of something.
    /// 
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            #region Arrays
            NewLine(2);
            Console.WriteLine("------------------------------------- Arrays -------------------------------------");
            NewLine(1);

            #region Creating Arrays

            // To create new arrays, we have to put the [] after the type to tell the application we want
            // an array of something instead of just one of them.

            //! In this example, we are not "instantiating" the array. This can be dangerous because if we try
            //!     to use this array without "instantiating" the array, our program will break.
            int[] anArrayOfIntegers;  // notice the wavy underline. If you "hover" your mouse over this, it will display why.
                                      // of course, we cannot use it since the application will not let us run the program if we did.

            //? This line is commented out, but if you uncomment and run the program you will see that the
            //?     program will not "compile".
            // int lengthOfMyArray =  anArrayOfIntegers.Length;



            //! In this exaple, we are both creating and "instantiating" the array.  This means we are giving
            //!     the array an initial value.  It will be an array that will hold 3 items.
            int[] someIntegers = new int[3];



            //! In this example, notice the same "style" of creating a simple integer array can be done with 
            //!     "complex" objects.
            //!     This is because everything in C# is an object, so everything works the same.
            SomeComplexObject[] anArrayOfComplexObjects = new SomeComplexObject[5];
            SomeComplexObject[] anotherArrayOfComplexObjects = new SomeComplexObject[] { new SomeComplexObject("My constructor injection") };


            //! In the next examples, we are both creating and "instantiating" the array. This time we are also
            //!     saying that I want {1, 2, 3, 4, 5} to by the values inside of this array.  Notice we do not
            //!     have to put "int[5]{1,2,3,4,5}".  This is because the IDE is smart enough to know what we want.
            int[] moreIntegers = new int[] { 1, 2, 3, 4, 5 }; // initializes the values of the array
            int[] otherIntegers = new[] { 1, 3, 5, 7, 9 }; // you can omit `int` and just specify []; type is inferred

            #endregion

            #region Accessing Array Information

            // ----------------  Accessing the information inside of an Array ------------------------------ 

            //  To access the value at a given index we have to use the same [] brackets at the end of the
            //      variable name.  To access the value at the 5th index, we would use "moreIntegers[4]"
            //      We use 4 for the 5th index because of the "off by one", since arrays first index is 0.
            //      Therefore the 5th index is 4.

            //? Whether we decide to use an array or not is mainly determined on two factors.  
            //?         1.) Do we know the same we need.
            //?         2.) Do we have an easy way to get to the index of an item that we want.

            //? We can use a for loop to easily access the members of an array in a given order.  Usually from the start
            //?     to end, or the end to start. This has a built in counter and is the main way we "go through arrays".
            Console.WriteLine("Using a for loop to go through an array:");
            for (int i = 0; i < moreIntegers.Length - 1; i++)
            {
                //! Please note the -1 on the "someIntegers.Length - 1". This is because of the "off by one problem".
                Console.WriteLine(String.Format("   The value at index {0} = {1}", i, moreIntegers[i]));
            }

            //? This time we can will go through our "complex" object and get some "inside value" of that
            //?     object.
            for (int i = 0; i < anotherArrayOfComplexObjects.Length - 1; i++)
            {
                //! Please note the -1 on the "someIntegers.Length - 1". This is because of the "off by one problem".
                Console.WriteLine(String.Format("   The value at index {0} = {1}", i, anotherArrayOfComplexObjects[i].SomeComplexObjectProperty));
            }
            NewLine(2);


            //? Please note that using a foreach with arrays does not give us access to the "index" of the
            //?     value of i.  This means if we need to know the index for a given item, we also have to include
            //?     another variable to be used as a counter.
            Console.WriteLine("Using a foreach loop to go through an array:");
            int counter = 0;
            foreach (int i in otherIntegers)
            {
                Console.WriteLine(String.Format("   The value at index {0} = {1}", counter, i));
                counter++;  //! This is how we do increment.  It is the same as "counter = counter +1", but alot easier to type.
            }
            NewLine(2);


            #endregion

            #region Multi-Dimensional Arrays


            //! Example 1: Create a "two-dimensional" array.  
            //!     You can think of this like an Excel spreadsheet. 
            //!     It will have both rows and columns.
            int[,] eggCarton = new int[2, 6]; // a typical egg carton can be thought of as a 2x6 array
            eggCarton[0, 0] = 1;  // We can access one of the "corners" with [0,0]
            eggCarton[1, 5] = 12; // We can access the other "corner" with [1,5]
            Console.WriteLine(String.Format(@"One corner of a [2,6] sized array ""eggCarton[0, 0]"" = {0}", eggCarton[0, 0])); // One corner
            Console.WriteLine(String.Format(@"The other corner of a [2,6] sized array ""eggCarton[1, 5]"" = {0}", eggCarton[1, 5])); // One corner
            NewLine(1);

            //! Example 2: Creating a "two-dimensional" array.  
            //!     However, this time we are also "instantiating" the array with values.  
            //!     As you can see, the first "row" is {1,2,3} and the second "row" is {4,5,6}.
            int[,] someTable = { { 1, 2, 3 },
                                 { 4, 5, 6 } }; // you can fill a multi-dimensional array on assignment as well
            Console.WriteLine(String.Format(@"One corner of ""someTable[0, 0]"" = {0}", someTable[0, 0])); // One corner
            Console.WriteLine(String.Format(@"The other corner of ""someTable[1, 2]"" = {0}", someTable[1, 2])); // One corner
            NewLine(2);


            //! Example 3: Creating a "three-dimensional" array.
            //!     This is harder to understand because computer screens are 2 dimensional,
            //!     but this can be considered like an excel "workbook", we the first 2
            //!     numbers are each spreadsheet size and the third page is how many pages there are.
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            // The same array with dimensions specified.
            int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

            // Accessing array elements.
            System.Console.WriteLine(String.Format(@"3D Array position ""array3Da[1, 0, 1]"" = {0}", array3Da[1, 0, 1]));
            System.Console.WriteLine(String.Format(@"3D Array position ""array3D[1, 1, 2]"" = {0}", array3D[1, 1, 2]));
            System.Console.WriteLine(String.Format(@"3D Array position ""array3Da[1, 1, 2]"" = {0}", array3Da[1, 1, 2]));
            NewLine(1);

            // Getting the total count of elements or the length of a given dimension.
            // Note that it's just easier to get the "Length" of an array, but if we need
            // the individual "row" size, the Length will not work.
            var allLength = array3D.Length;
            var total = 1;
            for (int i = 0; i < array3D.Rank; i++)
            {
                total *= array3D.GetLength(i);
            }
            Console.WriteLine(String.Format(@"The total lenth of the array using "".Length"" = {0}", allLength));
            Console.WriteLine(String.Format(@"The total lenth of the array using ""array3D.Rank"" and "".GetLength(i)"" = {0}", allLength));
            NewLine(2);

            // Arrays are good with performance, but more difficult to use. The next section will introduce Lists. Lists have many
            //      features that Arrays do not have.
            #endregion

            #endregion

            #region Lists
            NewLine(2);
            Console.WriteLine("------------------------------------- Lists -------------------------------------");
            NewLine(1);

            // --------------- Creating Lists ---------------
            //  Step 1: Include System.Collection.Generics namespace in your program with the help of using keyword.
            //      using System.Collection.Generics;

            //  Step 2: Create a list using List<T> class as shown below:
            //      List list_name = new List();

            //  Step 3: If you want to add elements in your list, then List<T> class provides two different methods and the methods are:
            //      Add(T) : This method is used to add an object to the end of the List<T>.
            //      AddRange(IEnumerable<T>): This method is used to add the elements of the specified collection to the end of the List<T>.

            //! Example 1: Create a List of "integers" and "Add" an integer to the list.
            List<int> someInts = new List<int>(); // declares an empty list
            someInts.Add(2);  // the list now has one item in it: {2}

            //! Example 2: Create a List of "integers" and "instantiate" the List with values
            List<int> moreInts = new List<int>() { 2, 3, 4 }; // you can initialize a list when you create it

            //! Example 3: Create an Array of strings, Create a List of "strings" using the Array to "instantiate" the List.
            string[] colors = "red,blue,yellow,green".Split(','); // an array of 4 strings
            List<string> colorList = new List<string>(colors); // initialize the list from an array

            Console.WriteLine("We can access a List's values in the same manner as an Array.");
            Console.WriteLine($"Example 1: someInts[0] = {someInts[0]}");
            Console.WriteLine($"Example 2: moreInts[0] = {moreInts[0]}");
            Console.WriteLine($"Example 3: colorList[0] =  {colorList[0]}");
            NewLine(1);

            //? Just like Arrays we can use both the for and foreach loop to go through them. However, lists are easier
            //?     to do this with because we do not NEED the index.  And, because it's a list, we have a method to "get"
            //?     the index if we need to know what it is.

            Console.WriteLine("Using a for loop to go through an List:");
            Console.WriteLine("This is written exactly like the Array example.");
            for (int i = 0; i < colorList.Count - 1; i++)  //! Notice that we use "Count" with Lists and "Length" with Arrays.
            {
                Console.WriteLine(String.Format("   The value at index {0} = {1}", i, colorList[i]));
            }
            NewLine(1);
            Console.WriteLine("Using a foreach loop to go through an List:");
            Console.WriteLine("This is written without a counter.  The List has methods to help us get information.");
            foreach (string color in colorList)
            {
                Console.WriteLine(String.Format("   The value at index {0} = {1}", colorList.IndexOf(color), color));  //! Notice we use the "IndexOf" method to get
            }                                                                                                          //!  the index. We do not NEED a counter.

            //? There are many methods that Lists provide. The following is a list of the commonly used methods:

            //?     .Add({value});
            //?     .AddRange({array});
            //?     .Remove({value});
            //?     .RemoveAt({index});
            //?     .RemoveRange({indexStart}, {howManyToRemove});
            //?     .Contains({value};


            //! Please review more on the we about lists. They are some of the most commonly used "collections" in C#.

            #endregion

            #region Dictionary
            NewLine(2);
            Console.WriteLine("------------------------------------- Dictionary -------------------------------------");
            NewLine(1);

            //! Example 1: Creating a dictionary
            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(1, "Paul");
            users.Add(2, "John");
            users.Add(3, "Mary");

            Dictionary<int, string> moreUsers = new Dictionary<int, string> { { 1, "Paul" }, { 2, "John" }, { 3, "Mary" } };
            Dictionary<string, string> evenMoreUsers = new Dictionary<string, string> { { "one", "Paul" }, { "two", "John" }, { "three", "Mary" } };

            //? Dictionaries are very similar to lists, however, they are not "indexed" like a List. You can choose how you want them indexed.
            //?     You can even use complex objects as the key, as long as they are all different.  If you attempt to add a new
            //?     item with a key that already exits, your program will crash.  It's important to check if a key exists with 
            //?     .ContainsKey({value}); before adding new things to a dictionary unless you are POSITIVE it is new and not already there.

            //? We get items from a dictionary the same as we do with lists. However, using a for loop with a dictionary can be difficult.
            //?     as you need the key to get the value directly.  Unless you're dictionary is setup to be like a list (if it is, just use a list)
            //?     we would rather use the foreach loop for dictionaries.  For the above dictionaries, a for loop would not let us get
            //?     the values from evenMoreUsers because the keys are strings.



            NewLine(1);
            foreach (KeyValuePair<int, string> keyValue in users)
            {
                Console.WriteLine(string.Format(@"The key/value pair is:  key = {0}, value = {1}", keyValue.Key, keyValue.Value));
            }
            NewLine(1);
            foreach (KeyValuePair<int, string> keyValue in moreUsers)
            {
                Console.WriteLine(string.Format(@"The key/value pair is:  key = {0}, value = {1}", keyValue.Key, keyValue.Value));
            }
            NewLine(1);
            foreach (KeyValuePair<string, string> keyValue in evenMoreUsers)
            {
                Console.WriteLine(string.Format(@"The key/value pair is:  key = {0}, value = {1}", keyValue.Key, keyValue.Value));
            }

            #endregion

            #region HashTable
            NewLine(2);
            Console.WriteLine("------------------------------------- Hash Tables -------------------------------------");
            NewLine(1);


            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "Joydip");
            hashTable.Add("two", "James");
            hashTable.Add(new SomeComplexObject("My Injected Property"), "Steve");


            Console.WriteLine("The key / value pairs are:--");
            Console.WriteLine("This is similar to the dictionary, except we do not have access to many methods a dictionary has.");
            Console.WriteLine("This makes Hashtables faster than Dictionaries.  It also does not matter what kind of item we put into a Hashtable");
            NewLine(1);
            foreach(object key in hashTable.Keys)
            {
                Console.WriteLine("Key: " + key.ToString() + "          Value: " + hashTable[key].ToString());
            }


            #endregion

            #region Queue
            NewLine(2);
            Console.WriteLine("------------------------------------- Queue -------------------------------------");
            NewLine(1);


            //? When we add a new item to a Queue, we use the Enqueue method with the item that we want to add.
            //?     Like getting in line at the store.

            Queue qt = new Queue();
            qt.Enqueue(1); Console.WriteLine("Enqueued 1 to the Queue");
            qt.Enqueue(2); Console.WriteLine("Enqueued 2 to the Queue");
            qt.Enqueue(3); Console.WriteLine("Enqueued 3 to the Queue");
            int queueCount = qt.Count;// get the count.. we cannot use this in the loop because it will change.
            Console.WriteLine("The number of elements in the Queue: " + queueCount);
            NewLine(1);


            //? When we remove an item from a Queue, we use the Dequeue command.  
            //?     Like getting to the front of the like at the store and being served.
            for (int i = 0; i < queueCount; i++)
            {
                Console.WriteLine(String.Format("Dequeue item {0} from the Queue.", qt.Dequeue()));
                Console.WriteLine("The number of elements in the Queue: " + qt.Count);
            }

            #endregion

            #region Stack
            NewLine(2);
            Console.WriteLine("------------------------------------- Stack -------------------------------------");
            NewLine(1);

            //? When we add a new item to a Stack, we use the Push method with the item that we want to add.
            //?     Like pushing down on a stack of items.

            Stack st = new Stack();
            st.Push(1); Console.WriteLine("Pushed 1 to the Stack");
            st.Push(2); Console.WriteLine("Pushed 2 to the Stack");
            st.Push(3); Console.WriteLine("Pushed 3 to the Stack");
            int stackCount = st.Count; // get the count.. we cannot use this in the loop because it will change.
            Console.WriteLine("The number of elements in the Stack: " + stackCount);
            NewLine(1);


            //? When we remove an item from a Stack, we use the Pop command.  
            //?     Like popping the top of a bottle.
            for (int i = 0; i < stackCount; i++)
            {
                Console.WriteLine(String.Format("Popped item {0} from the Stack.", st.Pop()));
                Console.WriteLine("The number of elements in the Stack: " + st.Count);
            }

            #endregion
        }
        #region For Formatting
        private static void NewLine(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine();
            }
        }
        #endregion
    }
}
