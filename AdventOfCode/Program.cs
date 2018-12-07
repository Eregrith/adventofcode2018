using AdventOfCode.Day1;
using AdventOfCode.Day2;
using AdventOfCode.Day3;
using AdventOfCode.Day4;
using System;
using System.Linq;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //DayOne();
            //DayTwo();
            //DayThree();
            DayFour();

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

        private static void DayThree()
        {
            var dayThree = new DayThree();
            Console.WriteLine("========= DAY THREE ========");
            var inchesOverlapping = dayThree.CountInchesOverlapping();
            Console.WriteLine($"Inches overlapped : {inchesOverlapping}");

            var intactClaimId = dayThree.GetIntactClaimId();
            Console.WriteLine($"Intact claim id : {intactClaimId}");
        }

        private static void DayFour()
        {
            var dayFour = new DayFour();
            Console.WriteLine("========= DAY THREE ========");

            dayFour.GetTop(10).ToList().ForEach(gw => Console.WriteLine(gw));
        }
    }
}
