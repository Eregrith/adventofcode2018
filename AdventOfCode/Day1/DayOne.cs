using AdventOfCode.Misc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode.Day1
{
    public class DayOne
    {
        private readonly List<int> InputList;

        public DayOne()
        {
            InputList = InputHelper.LoadListFromFile("Day1/input.txt", int.Parse);
        }

        public int GetFirstRereachedFrequency()
        {
            int freq = 0;
            int i = 0;
            List<int> reachedFrequencies = new List<int>();
            do
            {
                freq += InputList[i++ % InputList.Count];
                reachedFrequencies.Add(freq);
            } while (reachedFrequencies.Count(f => f == freq) != 2);
            return freq;
        }

        public int GetTotal()
        {
            return InputList.Sum();
        }
    }
}
