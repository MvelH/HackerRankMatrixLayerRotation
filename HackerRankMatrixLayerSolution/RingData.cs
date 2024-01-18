using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankMatrixLayerSolution
{
    public class RingData
    {
        public static int DefineNumberOfRings(int rows, int cols)
        {
            int numberOfRings = rows < cols ? rows / 2 : cols / 2;
            return numberOfRings;
        }

        public static int DefineRingCount(int rows, int cols, int counter)
        {
            int ringCount = 2 * (cols - (2 * counter)) + 2 * (rows - (2 * counter) - 2);
            return ringCount;
        }

        public static int DefineNumberOfMoves(int r, int ringCount)
        {
            if (ringCount == 0)
            { throw new DivideByZeroException("ringCount should not be zero"); }
            else
            {
                int moves = r % ringCount;
                return moves;
            }
        }
    }
}
