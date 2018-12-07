namespace AdventOfCode.Day3
{
    internal class ElfClaim
    {
        public int Id { get; internal set; }
        public int X { get; internal set; }
        public int Y { get; internal set; }
        public int Width { get; internal set; }
        public int Height { get; internal set; }

        public override string ToString()
        {
            return $"#{Id} @ {X},{Y}: {Width}x{Height}";
        }
    }
}