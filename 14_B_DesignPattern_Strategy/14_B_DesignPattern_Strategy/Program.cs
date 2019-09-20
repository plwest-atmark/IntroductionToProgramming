using _14_B_DesignPattern_Strategy.Strategy_Design_Pattern;
using System;

namespace _14_B_DesignPattern_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two contexts following different strategies
            StrategySortedList studentRecords = new StrategySortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

        }
    }
}
