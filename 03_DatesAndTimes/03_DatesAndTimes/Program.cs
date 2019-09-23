using System;
using System.Globalization;

namespace _03_DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Dates and Times
            #region
            NewLine(2);
            Console.WriteLine("------------------------------------- Dates and Times -------------------------------------");
            #endregion

            #region The DateTime Type
            #region
            Console.WriteLine(@"----------------------------------- The ""DateTime"" Type -----------------------------------");
            NewLine(1);
            #endregion

            //! Example 1: How to create a DateTime variable type.
            //!     These are the different ways we retrieve dates from the system and calculate
            //!     associated dates and times.
            var currentTime = DateTime.Now; // current time
            var today = DateTime.Today; // current date - time is midnight
            var someDate = new DateTime(2016, 7, 1); // 1 July 2016, midnight
            var someMoment = new DateTime(2016, 7, 1, 8, 0, 0); // 1 July 2016, 08:00.00
            var tomorrow = DateTime.Today.AddDays(1); // Adds days from a specific date
            var yesterday = DateTime.Today.AddDays(-1); // You can also use a negative to subtract days
            var januaryForth = DateTime.Parse("1/1/2020").AddDays(3); // Three days from the first of the year
            var someDay = DateTime.Parse("7/1/2016");

            Console.WriteLine($"DateTime.Now >>>> {nameof(currentTime)}: {currentTime}");  
            Console.WriteLine($"DateTime.Today >>>> {nameof(today)}: {today}");            
            Console.WriteLine($"new DateTime(2016, 7, 1) >>>> {nameof(someDate)}: {someDate}");
            Console.WriteLine($"new DateTime(2016, 7, 1, 8, 0, 0) >>>> {nameof(someMoment)}: {someMoment}");
            Console.WriteLine($"DateTime.Today.AddDays(1) >>>> {nameof(tomorrow)}: {tomorrow}");
            Console.WriteLine($"DateTime.Today.AddDays(-1) >>>> {nameof(yesterday)}: {yesterday}");
            Console.WriteLine($@"DateTime.Parse(""1 / 1 / 2020"").AddDays(3) >>>> {nameof(januaryForth)}: {januaryForth}");
            Console.WriteLine($@"DateTime.Parse(""7 / 1 / 2016"") >>>> {nameof(someDay)}: {someDay}");

            #endregion

            #region Formatting Dates and Times
            #region 
            NewLine(2);
            Console.WriteLine("------------------------------- Formatting Dates and Times --------------------------------");
            Console.WriteLine("------------------------------------------ Part 1 -----------------------------------------");
            NewLine(1);
            #endregion


            //! Example 1:  Using the .ToString({format}), will let you format dates
            //!             easily and in the same line as other string.
            DateTime thisDate1 = new DateTime(2011, 6, 10);  // June 10th 2011
            Console.WriteLine("Formatting witth .ToString({format}) >>>> Today is " + thisDate1.ToString("MMMM dd, yyyy") + ".");

            DateTimeOffset thisDate2 = new DateTimeOffset(2011, 6, 10, 15, 24, 16,
                                                          TimeSpan.Zero);
            Console.WriteLine("Formatting with curly brackets >>>> The current date and time: {0:MM/dd/yy H:mm:ss zzz}",
                               thisDate2);

            #region 
            NewLine(1);
            Console.WriteLine("------------------------------- Formatting Dates and Times --------------------------------");
            Console.WriteLine("------------------------------------------ Part 2 -----------------------------------------");
            NewLine(1);
            #endregion

            //! Example 2: Given different "dates" as string variables, we can TRY to parse them into
            //!            DateTime variable types. However, this does not always work if the string
            //!            is not actually a date.  We will look at what can and cannot be parsed

            //! Note: There are different DateTypesStyles that allow you to formate different strings
            //!       in different ways. This is useful because not every country writes their
            //!       dates in the same format.
            string[] dateValues = {"30-12-2011",
                                   "12-30-2011",
                                   "30-12-11",
                                   "12-30-11" };

            string pattern = "MM-dd-yy";
            DateTime parsedDate;

            foreach (var dateValue in dateValues)
            {
                // For each of the dates in our string, we will use the "MM-dd-yy" pattern to check
                //      if the date we are trying to parse is in the same format.  So, MM-dd-yy would
                //      mean that there must be a number between 1-12, then a day for that month
                //      and is either 1-28 or 1-31 depending on the month, then a 4 digit number that is
                //      within the range of dates for a computer.
                if (DateTime.TryParseExact(dateValue, pattern, null,
                                          DateTimeStyles.None, out parsedDate))
                    Console.WriteLine("Converted '{0}' to {1:d}.",
                                      dateValue, parsedDate);
                else
                    Console.WriteLine("Unable to convert '{0}' to a date and time.",
                                      dateValue);
            }

            //? ---------------------------additional reference-------------------------- -
            //? for more information on how dates can be parsed, please visit the following link
            //? https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx

            #endregion

            #region Getting to Parts of Dates and Times
            #region 
            NewLine(2);
            Console.WriteLine("-------------------------- Getting to Parts of Dates and Times ----------------------------");
            NewLine(1);
            #endregion

            //! Example 1: Given a specific date, we can extract the different parts of it easily.
            var someTime = new DateTime(2016, 7, 1, 11, 10, 9); //? 1 July 2016 11:10:09 AM
            int year = someTime.Year; // 2016
            int month = someTime.Month; // 7
            int day = someTime.Day; // 1
            int hour = someTime.Hour; // 11
            int minute = someTime.Minute; // 10
            int second = someTime.Second; // 9

            Console.WriteLine($"someTime >>>> {nameof(someTime)}: {someTime}");
            Console.WriteLine($"someTime.Year >>>> {nameof(year)}: {year}");
            Console.WriteLine($"someTime.Month >>>> {nameof(month)}: {month}");
            Console.WriteLine($"someTime.Day >>>> {nameof(day)}: {day}");
            Console.WriteLine($"someTime.Hour >>>> {nameof(hour)}: {hour}");
            Console.WriteLine($"someTime.Minute >>>> {nameof(minute)}: {minute}");
            Console.WriteLine($"someTime.Second >>>> {nameof(second)}: {second}");

            #endregion

            #region Calculating Durations Between DateTimes
            #region 
            NewLine(2);
            Console.WriteLine("------------------------ Calculating Durations Between DateTimes --------------------------");
            NewLine(1);
            #endregion

            //! Example 1: Calculating the difference between dates is quite simple and we
            //!            can easily just use addition and subtraction, but both variables
            //!            need to be of the DateTime type.
            DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
            TimeSpan duration = nextYear - DateTime.Today;
            Console.WriteLine($"There are {duration.TotalDays} days left in the year");

            #endregion

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
