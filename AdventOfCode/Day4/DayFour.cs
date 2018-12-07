using AdventOfCode.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode.Day4
{
    class DayFour
    {
        private List<GuardWatch> InputGuardWatches;

        public DayFour()
        {
            InputGuardWatches = InputHelper.LoadListFromFile("Day4/input.txt", ParseGuardWatch);
        }

        private GuardWatch ParseGuardWatch(string input)
        {
            Regex r = new Regex(@"\[(?<date>\d{4}-\d{2}-\d{2} \d{2}:\d{2})\] (?<activity>Guard #(?<id>\d+) begins shift|wakes up|falls asleep)");
            var matches = r.Match(input);

            GuardWatch gw = new GuardWatch
            {
                Activity = matches.Groups["activity"].Value == "wakes up" ? GuardWatch.Activities.WakeUp
                         : (matches.Groups["activity"].Value == "falls asleep" ? GuardWatch.Activities.FallAsleep : GuardWatch.Activities.SetGuard),
                Date = DateTime.Parse(matches.Groups["date"].Value),
            };
            if (gw.Activity == GuardWatch.Activities.SetGuard)
                gw.GuardId = int.Parse(matches.Groups["id"].Value);

            return gw;
        }

        public IEnumerable<GuardWatch> GetTop(int top)
        {
            return InputGuardWatches.OrderBy(gw => gw.Date).Take(top);
        }
    }
}
