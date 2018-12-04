using AdventOfCode.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Day2
{
    class DayTwo
    {
        private readonly List<string> InputList;

        public DayTwo()
        {
            InputList = InputHelper.LoadListFromFile("Day2/input.txt", InputHelper.NoOp);
        }

        public int GetChecksum()
        {
            int a = InputList.Count(StringHasTwoExactlyTwoSameLetters);
            int b = InputList.Count(StringHasTwoExactlyThreeSameLetters);
            return a*b;
        }

        private bool StringHasTwoExactlyTwoSameLetters(string value)
        {
            return value.ToCharArray().AsEnumerable().Any(letter => value.Count(l => l == letter) == 2);
        }
        private bool StringHasTwoExactlyThreeSameLetters(string value)
        {
            return value.ToCharArray().AsEnumerable().Any(letter => value.Count(l => l == letter) == 3);
        }


        public Tuple<string,string> GetTwoSimilarIDs()
        {
            var orderedInput = InputList.OrderBy(x => x);
            for (int i = 0; i < InputList.Count - 1; i++)
            {
                var a = orderedInput.ElementAt(i);
                var b = orderedInput.ElementAt(i + 1);

                if (NumberOfDifferentLetters(a, b) == 1) return new Tuple<string, string>(a, b);
            }
            return null;
        }

        private int NumberOfDifferentLetters(string a, string b)
        {
            int differences = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (b[i] != a[i]) differences++;
            }
            return differences;
        }
    }
}
