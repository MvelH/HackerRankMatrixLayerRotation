using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankMatrixLayerSolution
{
    public class Rotations
    {
        public static void CheckIfRotationsIsWithinLimits(int r, int lowerLimit, int upperLimit)
        {
            if (r < lowerLimit)
                throw new ArgumentOutOfRangeException(nameof(r), $"The number of rotations should not be less than {lowerLimit}.");
            else if (r > upperLimit)
                throw new ArgumentOutOfRangeException(nameof(r), $"The number of rotations should not be more than {upperLimit}.");
        }

    }
}
