using AdventOfCode.Day1;
using AdventOfCode.Day2;
using System;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //DayOne();
            DayTwo();

            Console.ReadLine();
        }

        private static void DayOne()
        {
            var dayOne = new DayOne();
            Console.WriteLine("========= DAY ONE ========");

            int total = dayOne.GetTotal();
            Console.WriteLine($"Total is : {total}");

            int frequency = dayOne.GetFirstRereachedFrequency();
            Console.WriteLine($"First re-reached frequency is : {frequency}");
        }

        private static void DayTwo()
        {
            var dayTwo = new DayTwo();
            Console.WriteLine("========= DAY TWO ========");

            int checksum = dayTwo.GetChecksum();
            Console.WriteLine($"Checksum is : {checksum}");

            Tuple<string, string> similarIDs= dayTwo.GetTwoSimilarIDs();
            Console.WriteLine($"Similar IDs are : {similarIDs.Item1} and {similarIDs.Item2}");
        }
    }
}
