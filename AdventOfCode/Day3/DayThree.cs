using AdventOfCode.Misc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode.Day3
{
    class DayThree
    {
        private readonly List<ElfClaim> InputClaims;

        public DayThree()
        {
            InputClaims = InputHelper.LoadListFromFile("Day3/input.txt", ParseElfClaim);
        }

        private ElfClaim ParseElfClaim(string claimInput)
        {
            Regex r = new Regex(@"#(?<id>\d+) @ (?<x>\d+),(?<y>\d+): (?<w>\d+)x(?<h>\d+)");
            var matches = r.Match(claimInput);

            return new ElfClaim
            {
                Id = int.Parse(matches.Groups["id"].Value),
                X = int.Parse(matches.Groups["x"].Value),
                Y = int.Parse(matches.Groups["y"].Value),
                Width = int.Parse(matches.Groups["w"].Value),
                Height = int.Parse(matches.Groups["h"].Value),
            };
        }

        public ElfClaim GetClaim(int pos)
        {
            return InputClaims[pos];
        }

        private int[,] ClaimFabric()
        {
            int[,] fabric = new int[1000, 1000];

            foreach (var claim in InputClaims)
            {
                for (int x = claim.X; x < claim.X + claim.Width; x++)
                {
                    for (int y = claim.Y; y < claim.Y + claim.Height; y++)
                    {
                        fabric[x, y]++;
                    }
                }
            }

            return fabric;
        }

        public int CountInchesOverlapping()
        {
            int[,] fabric = ClaimFabric();

            int count = 0;
            for (int x = 0; x < 1000; x++)
            {
                for (int y = 0; y < 1000; y++)
                {
                    if (fabric[x, y] > 1) count++;
                }
            }
            return count;
        }
        
        public int GetIntactClaimId()
        {
            int[,] fabric = ClaimFabric();

            foreach (var claim in InputClaims)
            {
                bool isIntact = true;
                for (int x = claim.X; x < claim.X + claim.Width; x++)
                {
                    for (int y = claim.Y; y < claim.Y + claim.Height; y++)
                    {
                        if (fabric[x, y] > 1) isIntact = false;
                    }
                }
                if (isIntact) return claim.Id;
            }
            return -1;
        }
    }
}
