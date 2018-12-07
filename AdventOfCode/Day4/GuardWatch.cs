using System;

namespace AdventOfCode.Day4
{
    internal class GuardWatch
    {
        public Activities Activity { get; internal set; }
        public DateTime Date { get; internal set; }
        public int GuardId { get; internal set; }

        public enum Activities
        {
            WakeUp,
            FallAsleep,
            SetGuard
        }

        public override string ToString()
        {
            return $"[{Date.ToString("yyyy-MM-dd hh:mm")}] ({GuardId}) {Activity.ToString()}";
        }
    }
}