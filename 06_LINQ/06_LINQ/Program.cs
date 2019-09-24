using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_LINQ
{
    class Program
    {
        #region LINQ LIST SETUP
        // SETUP our PEOPLE LIST
        private static List<Person> people = new List<Person>
        {
            new Person("Eric", "Fleming", "Dev", 24),
            new Person("Steve", "Smith", "Manager", 40),
            new Person("Brendan", "Enrick", "Dev", 30),
            new Person("Jane", "Doe", "Dev", 35),
            new Person("Samantha", "Jones", "Dev", 24)
        };
        private static List<Person> emptyList = new List<Person>();
        #endregion


        static void Main(string[] args)
        {

            #region LINQ Operations
            #region Count, Any, All, Where, Skip, Take, Select
            Header("LINQ Operations", addMargin: false);
            Header("Count, Any, All, Where, Skip, Take, Select");
            Header(".Count");
            //// ---------------- Count ----------------
            int numberOfPeopleInList = people.Count(); //Will return 5
            int peopleOverTwentyFive = people.Count(x => x.Age > 25); //Will return 3
            PrintPeopleList();

            Console.WriteLine("people.Count() : " + numberOfPeopleInList);
            Console.WriteLine("people.Count(x => x.Age > 25) : " + peopleOverTwentyFive);
            Header(".Any");


            // ---------------- Any ----------------
            bool thereArePeople = people.Any(); //This will return true
            bool thereAreNoPeople = emptyList.Any(); //This will return false

            PrintPeopleList();
            Console.WriteLine("people.Any() : " + thereArePeople);
            Console.WriteLine("emptyList.Any() : " + thereAreNoPeople);

            Header(".All");
            // ---------------- All ----------------
            bool allDevs = people.All(x => x.Occupation == "Dev"); //Will return false
            bool everyoneAtLeastTwentyFour = people.All(x => x.Age >= 24); //Will return true

            PrintPeopleList();
            Console.WriteLine(@"people.All(x => x.Occupation == ""Dev"") : " + allDevs);
            Console.WriteLine("people.All(x => x.Age >= 24) : " + everyoneAtLeastTwentyFour);

            Header(".Where");
            //// ---------------- Where ----------------
            var peopleOverTheAgeOf30 = people.Where(x => x.Age > 30);
            PrintPeopleList();
            Console.WriteLine("Who is over 30? people.Where(x => x.Age > 30):");
            foreach (var person in peopleOverTheAgeOf30)
            {
                Console.WriteLine(person.FirstName);
            }

            Header(".Skip");
            //// ---------------- Skip ----------------
            IEnumerable<Person> afterTwo = people.Skip(2);
            PrintPeopleList();
            Console.WriteLine("Skip the first 2 in the list. people.Skip(2)");
            foreach (var person in afterTwo)
            {
                Console.WriteLine(person.FirstName);
            }

            Header(".Take");
            //// ---------------- Take ----------------
            IEnumerable<Person> takeTwo = people.Take(2);
            PrintPeopleList();
            Console.WriteLine("Take only the first 2 from the list. people.Take(2)");
            foreach (var person in takeTwo)
            {
                Console.WriteLine(person.FirstName);
            }

            Header(".Select (Simple)");
            //// ---------------- Select (Simple) ----------------
            IEnumerable<string> allFirstNames = people.Select(x => x.FirstName);
            PrintPeopleList();
            Console.WriteLine("Get all the first names of the people in the list.");
            Console.WriteLine("   people.Select(x => x.FirstName)");
            foreach (var firstName in allFirstNames)
            {
                Console.WriteLine(firstName);
            }

            Header(".Select (A bit more complex)");
            //// ---------------- Select (A bit more complex) ----------------
            IEnumerable<FullName> allFullNames = people.Select(x => new FullName { First = x.FirstName, Last = x.LastName });
            PrintPeopleList();
            Console.WriteLine("Get all the first and last names and use them to create a new list of <FullName>");
            Console.WriteLine("Print the full list of FullNames");
            foreach (var fullName in allFullNames)
            {
                Console.WriteLine($"{fullName.Last}, {fullName.First}");
            }

            Footer();
            #endregion

            #region Finding One Item in Collections

            #region firstOrDefault
            Header("Finding One Item in Collections", addMargin: false);
            Header("firstOrDefault");

            var firstThirtyYearOld1 = people.FirstOrDefault(x => x.Age == 30);
            var firstThirtyYearOld2 = people.Where(x => x.Age == 30).FirstOrDefault();
            PrintPeopleList();
            Console.WriteLine("people.FirstOrDefault(x => x.Age == 30): " + firstThirtyYearOld1.FirstName); //Will output "Brendan"
            Console.WriteLine("people.Where(x => x.Age == 30).FirstOrDefault(): " + firstThirtyYearOld2.FirstName); //Will also output "Brendan"

            #endregion

            #region lastOrDefault
            Header("lastOrDefault");

            string lastOrDefault = people.LastOrDefault().FirstName;
            string lastThirtyYearOld = people.LastOrDefault(x => x.Age == 30).FirstName;
            PrintPeopleList();
            Console.WriteLine("people.LastOrDefault().FirstName: " + lastOrDefault); //Will output "Brendan"
            Console.WriteLine("people.LastOrDefault(x => x.Age == 30).FirstName: " + lastThirtyYearOld);

            #endregion

            #region singleOrDefault
            Header("singleOrDefault");

            string single = people.SingleOrDefault(x => x.FirstName == "Eric").FirstName;
            PrintPeopleList();
            Console.WriteLine(@"people.SingleOrDefault(x => x.FirstName == ""Eric"").FirstName: " + single);
            // Uncomment the next line to see it throw an exception
            // Person singleDev = people.SingleOrDefault(x => x.Occupation == "Dev");

            Footer();
            #region

            #region Null Values
            Header("Null Values");

            //// Null Values and what to look out for with LINQ
            Person willBeNull = emptyList.FirstOrDefault(); // None - default of null used
            Person willAlsoBeNull = people.FirstOrDefault(x => x.FirstName == "John"); // No John -default of null used
            PrintPeopleList();
            Console.Write("emptyList.FirstOrDefault(): ");
            Console.WriteLine(willBeNull == null); // true
            Console.Write(@"people.FirstOrDefault(x => x.FirstName == ""John""): ");
            Console.WriteLine(willAlsoBeNull == null); //true

            Footer();
            #endregion

            #endregion

            #endregion

            #endregion

            #region Conversion of Lists
            Header("Conversion of Lists");

            // ToList
            List<Person> listOfDevs = people.Where(x => x.Occupation == "Dev").ToList(); //This will return a List<Person>

            // ToArray
            Person[] arrayOfDevs = people.Where(x => x.Occupation == "Dev").ToArray(); //This will return a Person[] array

            Footer();
            #endregion

            #endregion
        }

        private static void PrintPeopleList()
        {
            Console.WriteLine("***************************************************************************");
            foreach (Person person in people)
            {
                Console.WriteLine(String.Format("First Name: {0,-10} Last Name: {1,-10} Occupation: {2,-10} Age: {3}",
                    person.FirstName, person.LastName, person.Occupation, person.Age));

            }
            Console.WriteLine("***************************************************************************");
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
