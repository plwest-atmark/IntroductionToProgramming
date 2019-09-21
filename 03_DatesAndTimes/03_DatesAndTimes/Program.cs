using System;

namespace _03_DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {

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

        }
    }
}
