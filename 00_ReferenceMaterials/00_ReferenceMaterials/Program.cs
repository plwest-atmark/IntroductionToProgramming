using _00_ReferenceMaterials.Inheritence;
using System;
using System.Collections.Generic;

/// <summary>
/// HIKARI
/// </summary>
namespace _00_ReferenceMaterials
{

    /// <summary>
    /// Each "region" below is an example of how to use basic funcationlity in C#.  The powerpoint "Reference.pptx" is provided
    /// for reference with more detailed explaination of each of the regions below.
    /// 
    /// To use each region, highlight evertything within the region, and uncomment (<ctrl> + K + U)  When finished with a section
    ///     remember to comment that section again with <ctrl> + K + C.  If you find that things are not working, please use the
    ///     CTRL + Z (undo) command to return to the initial state of this solution file.
    /// </summary>
    class Program
    {

        #region Fields

        int versionNumber = 123; // defines a field

        #endregion

        static void Main(string[] args)
        {

            #region Variables

            #region Strings

            #region String Declaration

            //var whatToSayAsVar = "Hello World as var";
            //string whatToSayAsAString = "Hello World as String";
            //string myName = "Paul";

            //Console.WriteLine("Hello World!");
            //Console.WriteLine(whatToSayAsVar);
            //Console.WriteLine(whatToSayAsAString);
            //Console.WriteLine($"Hello {myName}!");

            #endregion

            #region String Length


            //string empty1 = "";
            //string empty2 = String.Empty;


            //Console.WriteLine(empty1.Length);
            //Console.WriteLine(empty2.Length);

            #endregion

            #region Null VS Empty Strings

            //string emptyString = String.Empty;
            //string nullString = null;

            //Console.WriteLine(emptyString); // prints nothing
            //Console.WriteLine(nullString); // prints nothing

            //// this line will print 0
            //Console.WriteLine($"1st string is {emptyString.Length} characters long.");

            //// this line will throw an exception (uncomment it to confirm)
            //Console.WriteLine($"2nd string is {nullString.Length} characters long.");


            #endregion

            #region String Operations

            #region Addition of Strings

            //string firstString = "asdf";
            //string secondString = "34566356";
            //string bothTogether = firstString + secondString; // "asdf34566356"

            //Console.WriteLine(bothTogether);

            #endregion

            #region ToUpper and ToLower

            //string mixedCase = "This is all mixED up";
            //string toUpperCase = mixedCase.ToUpper(); // TEST STRING
            //string mixedCase2 = mixedCase.ToLower(); // test string
            //string toLowerCase = "This is also ALL MixeD Up".ToLower(); // another test

            //Console.WriteLine(mixedCase);
            //Console.WriteLine(toUpperCase);
            //Console.WriteLine(mixedCase2);
            //Console.WriteLine(toLowerCase);

            #endregion

            #region String.Trim()

            //string stringWithSpaces = " Paul "; // note the spaces at the beginning and end.
            //string trimTheBeginning = stringWithSpaces.TrimStart(); // "Paul "
            //string trimTheEnd = stringWithSpaces.TrimEnd(); // " Paul"
            //string trimBothEnds = stringWithSpaces.Trim(); // "Paul"
            //string trimWithSubstring = stringWithSpaces.Trim().Substring(0, 3); // "Pau"

            //Console.WriteLine($"_{stringWithSpaces}_");
            //Console.WriteLine($"_{trimTheBeginning}_");
            //Console.WriteLine($"_{trimTheEnd}_");
            //Console.WriteLine($"_{trimBothEnds}_");
            //Console.WriteLine($"_{trimWithSubstring}_");

            #endregion

            #region String.Format() and String.Replace

            //string myName = "Paul";
            //string withAddition = "Hello " + myName + "!"; // Hello Paul!
            //string withFormat = String.Format("Hello {0}!", myName); // Hello Paul!
            //string replaceTemp = "Hello **NAME**!";
            //string withreplace = replaceTemp.Replace("**NAME**", myName); // Hello Paul!

            //Console.WriteLine(myName);
            //Console.WriteLine(withAddition);
            //Console.WriteLine(withFormat);
            //Console.WriteLine(replaceTemp);
            //Console.WriteLine(withreplace);

            #endregion

            #endregion

            #endregion

            #region Dates and Times

            #region The DateTime Type

            //var currentTime = DateTime.Now; // current time
            //var today = DateTime.Today; // current date - time is midnight
            //var someDate = new DateTime(2016, 7, 1); // 1 July 2016, midnight
            //var someMoment = new DateTime(2016, 7, 1, 8, 0, 0); // 1 July 2016, 08:00.00
            //var tomorrow = DateTime.Today.AddDays(1);
            //var yesterday = DateTime.Today.AddDays(-1);
            //var someDay = DateTime.Parse("7/1/2016");

            //Console.WriteLine($"{nameof(currentTime)}: {currentTime}");
            //Console.WriteLine($"{nameof(today)}: {today}");
            //Console.WriteLine($"{nameof(someDate)}: {someDate}");
            //Console.WriteLine($"{nameof(someMoment)}: {someMoment}");
            //Console.WriteLine($"{nameof(tomorrow)}: {tomorrow}");
            //Console.WriteLine($"{nameof(yesterday)}: {yesterday}");
            //Console.WriteLine($"{nameof(someDay)}: {someDay}");

            #endregion

            #region Formatting Dates and Times

            // --------------------------- part 1 ---------------------------

            //DateTime thisDate1 = new DateTime(2011, 6, 10);
            //Console.WriteLine("Today is " + thisDate1.ToString("MMMM dd, yyyy") + ".");

            //DateTimeOffset thisDate2 = new DateTimeOffset(2011, 6, 10, 15, 24, 16,
            //                                              TimeSpan.Zero);
            //Console.WriteLine("The current date and time: {0:MM/dd/yy H:mm:ss zzz}",
            //                   thisDate2);


            // The example displays the following output:
            //    Today is June 10, 2011.
            //    The current date and time: 06/10/11 15:24:16 +00:00

            // --------------------------- part 2 ---------------------------

            //string[] dateValues = { "30-12-2011", "12-30-2011",
            //                  "30-12-11", "12-30-11" };
            //string pattern = "MM-dd-yy";
            //DateTime parsedDate;

            //foreach (var dateValue in dateValues)
            //{
            //    if (DateTime.TryParseExact(dateValue, pattern, null,
            //                              DateTimeStyles.None, out parsedDate))
            //        Console.WriteLine("Converted '{0}' to {1:d}.",
            //                          dateValue, parsedDate);
            //    else
            //        Console.WriteLine("Unable to convert '{0}' to a date and time.",
            //                          dateValue);
            //}

            // --------------------------- additional reference ---------------------------
            // for more information on how dates can be parsed, please visit the following link
            // https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx

            #endregion

            #region Getting to Parts of Dates and Times

            //var someTime = new DateTime(2016, 7, 1, 11, 10, 9); // 1 July 2016 11:10:09 AM
            //int year = someTime.Year; // 2016
            //int month = someTime.Month; // 7
            //int day = someTime.Day; // 1
            //int hour = someTime.Hour; // 11
            //int minute = someTime.Minute; // 10
            //int second = someTime.Second; // 9

            //Console.WriteLine($"{nameof(someTime)}: {someTime}");
            //Console.WriteLine($"{nameof(year)}: {year}");
            //Console.WriteLine($"{nameof(month)}: {month}");
            //Console.WriteLine($"{nameof(day)}: {day}");
            //Console.WriteLine($"{nameof(hour)}: {hour}");
            //Console.WriteLine($"{nameof(minute)}: {minute}");
            //Console.WriteLine($"{nameof(second)}: {second}");

            #endregion

            #region Calculating Durations Between DateTimes

            //DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
            //TimeSpan duration = nextYear - DateTime.Today;
            //Console.WriteLine($"There are {duration.TotalDays} days left in the year");

            #endregion

            #endregion

            #endregion

            #region Making Decisions in Your Program

            #region If This Then That

            //bool someCondition = false;

            //var sum = 10;
            //if (someCondition)
            //{
            //    sum = sum + 5;
            //    sum = sum * 2;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Or Else!

            //Console.WriteLine("What is the capital of Ohio?");
            //var answer = "Columbus"; // please note that we use the .ToLower to ensure user input is processed
            //if (answer.ToLower() == "columbus")
            //{
            //    Console.WriteLine("Correct!");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, that's not the right answer.");
            //}

            #endregion

            #region Switch Statements

            //uint guessedNumber = 1; // try different numbers to see resulting behavior
            //switch (guessedNumber)
            //{
            //    case 0:
            //        Console.WriteLine("Sorry, 0 is not a valid guess.");
            //        break;
            //    case 1:
            //    case 2:
            //    case 3:
            //        Console.WriteLine("You guessed low.");
            //        break;
            //    case 4:
            //        Console.WriteLine("You guessed the right number!");
            //        break;
            //    default:
            //        Console.WriteLine("You guessed high.");
            //        break;
            //}

            #endregion

            #endregion

            #region Logical Expressions

            //       ==  // equal
            //       !=  // not equal
            //       >   // greater than
            //       <   // less than
            //       >=  // greater than or equal
            //       <=  // less than or equal

            #region Comparison Operators

            //int x = 15;
            //int y = 10;
            //Console.WriteLine(x < 10);
            //Console.WriteLine(y >= 0);

            #endregion

            #region Conditional Logical 

            ////    &&  // logical AND
            ////    ||  // logical OR
            ////    !   // logical NOT (often read as 'bang')
            ////    ^   // logical XOR (exclusive OR)

            ////    true && true    // true
            ////    true && false   // false
            ////    false && false  // false

            ////    true || true    // true
            ////    true || false   // true
            ////    false || false  // false

            ////    true ^ true     // false
            ////    true ^ false    // true
            ////    false ^ false   // false

            ////    !true           // false
            ////    !false          // true

            //Console.WriteLine(true && true);    // true
            //Console.WriteLine(true && false);   // false
            //Console.WriteLine(false && false);  // false

            //Console.WriteLine(true || true);    // true
            //Console.WriteLine(true || false);   // true
            //Console.WriteLine(false || false);  // false

            //Console.WriteLine(true ^ true);     // false
            //Console.WriteLine(true ^ false);    // true
            //Console.WriteLine(false ^ false);   // false

            //Console.WriteLine(!true);           // false
            //Console.WriteLine(!false);          // true

            //int a = 5;
            //int b = 10;
            //if ((a < b) && (b < 20))
            //{
            //    Console.WriteLine("The entire condition is true, just like MATH!");
            //}

            #endregion

            #region Flags

            //int x = 10;
            //bool isPositive = x > 0;
            //if (isPositive)
            //{
            //    Console.WriteLine("The FLAG is set to true!");
            //}

            #endregion

            #endregion

            #region Looping Based on a Logical Expression

            #region Expression-Based Loops

            //int numberToGuess = new Random().Next(1, 101); // a number from 1 to 100
            //int currentGuess = 0; // start with an incorrect guess
            //while (currentGuess != numberToGuess)
            //{
            //    Console.WriteLine("Guess the number (1 to 100): ");
            //    currentGuess = int.Parse(Console.ReadLine());
            //    if (currentGuess < numberToGuess)
            //    {
            //        Console.WriteLine("You guessed too low! Try again!");
            //    }
            //    if (currentGuess > numberToGuess)
            //    {
            //        Console.WriteLine("You guessed too high! Try again!");
            //    }
            //}
            //Console.WriteLine("You got it! Good job!");

            #endregion

            #region Using break to exit a loop (infinite loops)

            //int numberToGuess = new Random().Next(1, 101); // a number from 1 to 100
            //while (true) // this sets up an infinite loop, since true will always evaluate to true
            //{
            //    Console.WriteLine("Guess the number (1 to 100): ");
            //    int currentGuess = int.Parse(Console.ReadLine());
            //    if (currentGuess == numberToGuess) break;
            //    if (currentGuess < numberToGuess)
            //    {
            //        Console.WriteLine("You guessed too low! Try again!");
            //    }
            //    if (currentGuess > numberToGuess)
            //    {
            //        Console.WriteLine("You guessed too high! Try again!");
            //    }

            //    // break
            //}
            //Console.WriteLine("You got it! Good job!");

            #endregion

            #endregion

            #region Looping a Known Number of Times

            #region For Loops

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Starting From Different Values

            //int startingNumber = 5; // change to whatever value you want to start from
            //int endingNumber = 10; // change to whatever number you want to be the last displayed

            //for (int i = startingNumber; i <= endingNumber; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Counting Up By Different Increments

            //Console.WriteLine("Odd Numbers from 1-49:");
            //for (int i = 1; i < 50; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Counting Down By Different Increments

            //Console.WriteLine("Countdown started...");
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("LIFTOFF!");

            #endregion

            #region Nested Loops

            //Console.WriteLine("Multiplication Table:");
            //Console.WriteLine("     1  2  3  4  5  6  7  8  9");
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.Write($" {i} ");
            //    for (int j = 1; j < 10; j++)
            //    {
            //        string product = (i * j).ToString();
            //        Console.Write(product.PadLeft(3));
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #endregion

            #region Working with Arrays and Collections

            #region Creating Arrays

            // int[] someIntegers = new int[3]; // holds 3 elements, with indexes of 0, 1, and 2.
            //                                 // uninitialized elements of a declared array 
            //                                 // hold the default value for the type (in this case 0).
            //Console.WriteLine(someIntegers[0]);
            //Console.WriteLine(someIntegers[1]);
            //Console.WriteLine(someIntegers[2]);

            //int[] moreIntegers = new int[] { 1, 2, 3, 4, 5 }; // initializes the values of the array
            //Console.WriteLine(moreIntegers[0]);
            //Console.WriteLine(moreIntegers[1]);
            //Console.WriteLine(moreIntegers[2]);
            //// write out more if you like

            //int[] otherIntegers = new[] { 1, 3, 5, 7, 9 }; // you can omit `int` and just specify []; type is inferred
            //Console.WriteLine(otherIntegers[0]);
            //Console.WriteLine(otherIntegers[1]);
            //Console.WriteLine(otherIntegers[2]);
            //// write out more if you like

            #endregion

            #region Multi-Dimensional Array

            //// ----------- example 1
            //int[,] eggCarton = new int[2, 6]; // a typical egg carton can be thought of as a 2x6 array
            //eggCarton[0, 0] = 1;
            //eggCarton[1, 5] = 12;
            //Console.WriteLine(eggCarton[0, 0]); // one "corner" of the array
            //Console.WriteLine(eggCarton[1, 5]); // the opposite "corner"

            //int[,] someTable = { { 1, 2, 3 }, { 4, 5, 6 } }; // you can fill a multi-dimensional array on assignment as well
            //Console.WriteLine(someTable[0, 0]); // one "corner" of the array
            //Console.WriteLine(someTable[1, 2]); // the opposite "corner"


            //// ----------- example 2
            ///// Two-dimensional array.
            //int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            //// The same array with dimensions specified.
            //int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            //// A similar array with string elements.
            //string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
            //                            { "five", "six" } };

            //// Three-dimensional array.
            //int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
            //                     { { 7, 8, 9 }, { 10, 11, 12 } } };
            //// The same array with dimensions specified.
            //int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
            //                           { { 7, 8, 9 }, { 10, 11, 12 } } };

            //// Accessing array elements.
            //System.Console.WriteLine(array2D[0, 0]);
            //System.Console.WriteLine(array2D[0, 1]);
            //System.Console.WriteLine(array2D[1, 0]);
            //System.Console.WriteLine(array2D[1, 1]);
            //System.Console.WriteLine(array2D[3, 0]);
            //System.Console.WriteLine(array2Db[1, 0]);
            //System.Console.WriteLine(array3Da[1, 0, 1]);
            //System.Console.WriteLine(array3D[1, 1, 2]);

            //// Getting the total count of elements or the length of a given dimension.
            //var allLength = array3D.Length;
            //var total = 1;
            //for (int i = 0; i < array3D.Rank; i++)
            //{
            //    total *= array3D.GetLength(i);
            //}
            //System.Console.WriteLine("{0} equals {1}", allLength, total);

            #endregion

            #region Working with Arrays

            //int[] someIntegers = { 1, 2, 3 };

            //int x = 1 + someIntegers[0]; // x = 2
            //Console.WriteLine(x);

            //int y = 2 * someIntegers[2]; // y = 6
            //Console.WriteLine(y);

            //someIntegers[2] = y; // someIntegers now contains { 1, 2, 6 }
            //Console.WriteLine(someIntegers[0]);
            //Console.WriteLine(someIntegers[1]);
            //Console.WriteLine(someIntegers[2]);

            //// following lines produces an exception (Out of bounds Exception)
            ////someIntegers[3] = 3; // EXCEPTION

            #endregion

            #region Arrays and Strings

            //// -------- .Split('char');
            //string input = "red,blue,yellow,green";
            //string[] colors = input.Split(','); // note single quotes, which are used to define literal character (``char``) values

            //Console.WriteLine(colors[0]);
            //Console.WriteLine(colors[1]);


            //// -------- .Join('char');
            //input = "red,blue,yellow,green";
            //colors = input.Split(','); // note single quotes, which are used to define literal character (``char``) values

            //string output = String.Join(" | ", colors);
            //Console.WriteLine(output);

            #endregion

            #region Lists

            #region Creating Lists

            //List<int> someInts = new List<int>(); // declares an empty list
            //someInts.Add(2);  // the list now has one item in it: {2}
            //Console.WriteLine($"someInts[0]: {someInts[0]}");

            //List<int> moreInts = new List<int>() { 2, 3, 4 }; // you can initialize a list when you create it
            //Console.WriteLine($"moreInts[0]: {moreInts[0]}");

            //string[] colors = "red,blue,yellow,green".Split(','); // an array of 4 strings
            //List<string> colorList = new List<string>(colors); // initialize the list from an array
            //Console.WriteLine($"colorList[0]: {colorList[0]}");

            #endregion

            #region Working with Lists

            //List<string> colors = new List<string>() { "black", "white", "gray" };
            //colors.Remove("black");
            //colors.Insert(0, "orange"); // orange is the new black
            //Console.WriteLine($"colors[0] {colors[0]}");

            //colors.RemoveAll(c => c.Contains("t")); // removes all elements matching condition (containing a "t")
            //                                        // colors currently: orange, gray
            //Console.WriteLine($"colors[1] {colors[1]}");

            //colors.RemoveAt(0); // removes the first element (orange)
            //Console.WriteLine($"colors[0] {colors[0]}");

            //int numColors = colors.Count; // Count currently is 1
            //Console.WriteLine($"numColors: {numColors}");

            //colors.Clear(); // colors is now an empty list
            //Console.WriteLine($"colors.Count: {colors.Count}");

            #endregion

            #region Working with Lists (ForEach)

            //var colors = new List<string>() { "blue", "green", "yellow" };
            //colors.ForEach(Console.WriteLine); // equivalent to ForEach(c => Console.WriteLine(c)) 

            #endregion

            #region Working With Lists (Join)

            //var colors = new List<string>() { "blue", "green", "yellow" };
            //Console.WriteLine(String.Join(",", colors));

            #endregion

            #endregion

            #region Looping Through Members of a Collection

            #region Using the foreach Loop

            //var myList = new List<string>() { "one", "two", "three" };
            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Other Options (for)

            //// List<T>
            //var myList = new List<int>() { 43, 55, 100 };
            //for (int i = 0; i < myList.Count; i++)
            //{
            //    // access current element of the list with index of i
            //    Console.WriteLine(myList[i]);
            //}

            //// array
            //int[] numbers = new[] { 2, 3, 5, 7 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    // access current element of the array with index of i
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Other Options (while)

            //var myList = new List<int>() { 10, 20, 30 };
            //int index = 0;
            //while (index < myList.Count)
            //{
            //    Console.WriteLine(myList[index]);
            //    index++;
            //}

            #endregion

            #endregion

            #endregion

            #region Methods and Execution

            #region Declaring and Calling Methods

            //DisplayHeader();
            //DisplayMenu();

            #endregion

            #region Declaring and Calling Methods with return types (Includes Overloaded Methods)

            //string greeting = CreateGreeting("Paul");
            //Console.WriteLine(greeting);

            #endregion

            #region Lambda Expressions

            //------------- example 1 -------------
            //Func<int, int> addOne = x => x + 1; // this is the lambda expression
            //Console.WriteLine(addOne(4));

            //------------- example 2 -------------
            //const int four = 4;
            //Func<int, int> addOne = x => x + 1;
            //Func<int, int, int> calcArea = (x, y) => x * y; // two parameters
            //Func<int> twentyFive = () => calcArea(addOne(four), addOne(four)); // no parameters
            //Console.WriteLine(twentyFive());

            #endregion

            #region Extension Methods

            //int ten = 5.PlusFive();
            //Console.WriteLine(ten);

            #endregion

            #endregion

            #region Introducing LINQ

            #region LINQ LIST SETUP
            // SETUP our PEOPLE LIST
            var people = new List<Person>();
            people.Add(new Person("Eric", "Fleming", "Dev", 24));
            people.Add(new Person("Steve", "Smith", "Manager", 40));
            people.Add(new Person("Brendan", "Enrick", "Dev", 30));
            people.Add(new Person("Jane", "Doe", "Dev", 35));
            people.Add(new Person("Samantha", "Jones", "Dev", 24));
            var emptyList = new List<Person>();
            #endregion

            #region LINQ Operations

            #region Count, Any, All, Where, Skip, Take, Select

            //// ---------------- Count ----------------
            //int numberOfPeopleInList = people.Count(); //Will return 5
            //int peopleOverTwentyFive = people.Count(x => x.Age > 25); //Will return 3

            //// ---------------- Any ----------------
            //bool thereArePeople = people.Any(); //This will return true
            //bool thereAreNoPeople = emptyList.Any(); //This will return false

            //// ---------------- All ----------------
            //bool allDevs = people.All(x => x.Occupation == "Dev"); //Will return false
            //bool everyoneAtLeastTwentyFour = people.All(x => x.Age >= 24); //Will return true

            //// ---------------- Where ----------------
            ////There will be two Persons in this variable: the "Steve" Person and the "Jane" Person
            //var peopleOverTheAgeOf30 = people.Where(x => x.Age > 30);
            //foreach (var person in peopleOverTheAgeOf30)
            //{
            //    Console.WriteLine(person.FirstName);
            //}

            //// ---------------- Skip ----------------
            ////Will ignore Eric and Steve in the list of people
            //IEnumerable<Person> afterTwo = people.Skip(2);
            //foreach (var person in afterTwo)
            //{
            //    Console.WriteLine(person.FirstName);
            //}

            //// ---------------- Take ----------------
            ////Will only return Eric and Steve from the list of people
            //IEnumerable<Person> takeTwo = people.Take(2);
            //foreach (var person in takeTwo)
            //{
            //    Console.WriteLine(person.FirstName);
            //}

            //// ---------------- Select (Simple) ----------------
            //// Creates a new list of just "First Names"
            //IEnumerable<string> allFirstNames = people.Select(x => x.FirstName);
            //foreach (var firstName in allFirstNames)
            //{
            //    Console.WriteLine(firstName);
            //}

            //// ---------------- Select (A bit more complex) ----------------
            //// Creates a new list of a DIFFERENT object based on what is "Queried"
            //IEnumerable<FullName> allFullNames = people.Select(x => new FullName { First = x.FirstName, Last = x.LastName });
            //foreach (var fullName in allFullNames)
            //{
            //    Console.WriteLine($"{fullName.Last}, {fullName.First}");
            //}

            #endregion

            #region Finding One Item in Collections

            #region firstOrDefault

            //// Get only the first or "default" from a list retrieved from LINQ
            //var firstThirtyYearOld1 = people.FirstOrDefault(x => x.Age == 30);
            //var firstThirtyYearOld2 = people.Where(x => x.Age == 30).FirstOrDefault();
            //Console.WriteLine(firstThirtyYearOld1.FirstName); //Will output "Brendan"
            //Console.WriteLine(firstThirtyYearOld2.FirstName); //Will also output "Brendan"

            #endregion

            #region lastOrDefault

            //Person lastOrDefault = people.LastOrDefault();
            //Console.WriteLine(lastOrDefault.FirstName);
            //Person lastThirtyYearOld = people.LastOrDefault(x => x.Age == 30);
            //Console.WriteLine(lastThirtyYearOld.FirstName);

            #endregion

            #region singleOrDefault

            //Person single = people.SingleOrDefault(x => x.FirstName == "Eric");
            //Console.WriteLine(single.FirstName);
            //// Uncomment the next line to see it throw an exception
            //// Person singleDev = people.SingleOrDefault(x => x.Occupation == "Dev");

            #region

            #region Null Values

            //// Null Values and what to look out for with LINQ
            //Person willBeNull = emptyList.FirstOrDefault(); // None - default of null used
            //Person willAlsoBeNull = people.FirstOrDefault(x => x.FirstName == "John"); // No John -default of null used

            //Console.WriteLine(willBeNull == null); // true
            //Console.WriteLine(willAlsoBeNull == null); //true

            #endregion

            #endregion

            #endregion

            #endregion

            #region Conversion of Lists

            //// ToList
            //List<Person> listOfDevs = people.Where(x => x.Occupation == "Dev").ToList(); //This will return a List<Person>

            //// ToArray
            //Person[] arrayOfDevs = people.Where(x => x.Occupation == "Dev").ToArray(); //This will return a Person[] array


            #endregion

            #endregion

            #endregion

            #region Exceptions (try & catch)

            #region Basic Try/Catch

            //// simple example of exception handling.
            //try
            //{
            //    // code that may throw an exception here
            //    int x = int.Parse(Console.ReadLine());
            //}
            //catch (System.Exception ex)
            //{
            //    // handle the exception here
            //    Console.Write(ex.ToString());
            //}

            #endregion

            #region Throwing Exceptions again (Bubbling up)

            //// We can continue to throw exceptions in more complex code... this is called "bubbling up"
            //try
            //{
            //    try
            //    {
            //        int x = int.Parse(Console.ReadLine());
            //    }
            //    catch (System.FormatException ex)
            //    {
            //        Console.Write(String.Format("This is the first time the exception was trown: {0}",
            //                                            ex.ToString()));
            //        // do something here before re-throwing
            //        throw;
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.Write(String.Format("This is the second time the exception was trown: {0}",
            //                                        ex.ToString()));
            //}

            #endregion

            #region Custom Exceptions

            //// We can also throw our own exceptions in code if we want to.
            //try
            //{
            //    // code that may throw an exception here
            //    int age = int.Parse(Console.ReadLine());
            //    if (age < 18 || age > 150)
            //    {
            //        throw new ArgumentOutOfRangeException("Age must be between 18 and 150.", nameof(age));
            //    }
            //}
            //catch (System.Exception ex)
            //{
            //    // handle the exception here
            //    Console.Write(ex.ToString());
            //}

            #endregion

            #region Finally Block

            //// Finally block (try...catch...finally)
            //try
            //{
            //    throw new Exception("Let's play catch!");
            //}
            //catch (System.Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    // This code will always run
            //    // even if your catch block re-throws
            //    Console.WriteLine("FINALLY!");
            //}
            //// Code here will run only if catch doesn't re-throw
            //Console.WriteLine("Still ran.");

            #endregion

            #region Exception Filtering

            //// Filter the exception with multiple catch blocks
            //try
            //{
            //    string thisIsNull = null;
            //    Console.WriteLine(thisIsNull.Length);

            //    //throw new Exception("This is a fake Exception");
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("NullReferenceException Thrown:***************");
            //    Console.WriteLine(ex.ToString());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception Thrown::***************");
            //    Console.WriteLine(ex.ToString());
            //}

            #endregion

            #endregion

            #region Classes in C#

            //// the following line will not compile - comment out to fix
            //int versionNumber = 333; // defines a field
            //Console.WriteLine($"Current version: {versionNumber}");

            //// instead, you must create an instance of Program
            //var myProgram = new Program();
            //Console.WriteLine($"Current version: {myProgram.versionNumber}");

            //Console.WriteLine(myProgram.ToString());
            //// or
            //// WriteLine will automatically call ToString for you internally
            //Console.WriteLine(myProgram);

            #region Polymorphism

            //var rectangle = new Rectangle();
            //rectangle.Height = 5;
            //rectangle.Width = 6;
            //DisplayShape(rectangle);

            //var triangle = new Triangle();
            //triangle.Side1 = 3;
            //triangle.Side2 = 4;
            //triangle.Side3 = 5;
            //DisplayShape(triangle);

            #endregion

            #endregion

            #region Variable Scope

            //for (int i = 0; i < 10; i++)
            //{
            //    string message = $"I ran this loop {i} times already.";
            //    Console.WriteLine(message);
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    string message = $"I ran this loop {i} times already.";
            //    Console.WriteLine(message);
            //}

            #region Access Modifiers

            // Objects that implement "private" access modifier are accessible only inside a class or a structure.
            //      As a result, we can’t access them outside the class they are created.

            // Objects that implement "public" access modifier are accessible from everywhere in our project.
            //      Therefore, there are no accessibility restrictions.

            // The "protected" keyword implies that the object is accessible inside the class and in all classes that derive 
            //      from that class. Remember the Shapes Example.

            // The "internal" keyword specifies that the object is accessible only inside its own assembly
            //      but not in other assemblies

            // The "protected internal" access modifier is a combination of protected and internal. 
            //      As a result, we can access the protected internal member only in the same assembly or 
            //      in a derived class in other assemblies(projects).

            // The "private protected" access modifier is a combination of the private and protected keywords.
            //      We can access members inside the containing class or in a class that derives from a containing 
            //      class, but only in the same assembly(project). 
            //      Therefore, if we try to access it from another assembly, we will get an error.

            #endregion

            #region Encapsulation

            // Encapsulation will be explained on the board.

            #endregion

            #endregion

            #region Design Patterns

            #region Adapter Pattern

            //// Non-adapted chemical compound
            //Compound unknown = new Compound("Unknown");
            //unknown.Display();

            //// Adapted chemical compounds
            //Compound water = new RichCompound("Water");
            //water.Display();

            //Compound benzene = new RichCompound("Benzene");
            //benzene.Display();

            //Compound ethanol = new RichCompound("Ethanol");
            //ethanol.Display();

            //// Wait for user
            //Console.ReadKey();

            #endregion

            #region Factory Pattern

            //// Note: constructors call Factory Method
            //Document[] documents = new Document[2];

            //documents[0] = new Resume();
            //documents[1] = new Report();

            //// Display document pages
            //foreach (Document document in documents)
            //{
            //    Console.WriteLine("\n" + document.GetType().Name + "--");
            //    foreach (Page page in document.Pages)
            //    {
            //        Console.WriteLine(" " + page.GetType().Name);
            //    }
            //}

            //// Wait for user
            //Console.ReadKey();

            #endregion

            #region Singleton Pattern

            //LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            //LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            //LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            //LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            //// Same instance?
            //if (b1 == b2 && b2 == b3 && b3 == b4)
            //{
            //    Console.WriteLine("Same instance\n");
            //}

            //// Load balance 15 server requests
            //LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            //for (int i = 0; i < 15; i++)
            //{
            //    string server = balancer.Server;
            //    Console.WriteLine("Dispatch Request to: " + server);
            //}

            //// Wait for user
            //Console.ReadKey();

            #endregion

            #region Strategy Pattern

            //// Two contexts following different strategies
            //StrategtSortedList studentRecords = new StrategtSortedList();

            //studentRecords.Add("Samual");
            //studentRecords.Add("Jimmy");
            //studentRecords.Add("Sandra");
            //studentRecords.Add("Vivek");
            //studentRecords.Add("Anna");

            //studentRecords.SetSortStrategy(new QuickSort());
            //studentRecords.Sort();

            //studentRecords.SetSortStrategy(new ShellSort());
            //studentRecords.Sort();

            //studentRecords.SetSortStrategy(new MergeSort());
            //studentRecords.Sort();

            //// Wait for user
            //Console.ReadKey();

            #endregion

            #endregion

        }

        #region Declaring and Calling Methods (external methods)

        static void DisplayHeader()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("**** Please Select An Option *******************");
            Console.WriteLine("------------------------------------------------");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - View the Menu");
            Console.WriteLine("2 - Exit the Program");
        }

        #endregion

        #region Declaring and Calling Methods with return types

        static string CreateGreeting()
        {
            // call version with more parameters, passing a default value
            return CreateGreeting("You");
        }
        static string CreateGreeting(string name)
        {
            return $"Hi {name}!";
        }

        #endregion

        #region DisplayShape method for use with the Shape Class (Polymorphism)

        public static void DisplayShape(Shape shape)
        {
            Console.WriteLine($"Shape Perimeter: {shape.Perimeter()}");
        }

        #endregion
    }

    #region Extension Methods

    public static class ExtensionMethods
    {
        public static int PlusFive(this int input)
        {
            return input + 5;
        }
    }

    #endregion
}
