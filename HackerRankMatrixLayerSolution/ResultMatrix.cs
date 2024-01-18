using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankMatrixLayerSolution
{
    public class ResultMatrix
    {
        public static int[,] UpdateResultMatrix(int[,] mx, int counter, List<int> rotatedRing)
        {
            int rows = mx.GetLength(0);
            int cols = mx.Length / rows;
            for (int i = counter; i < cols - counter; i++)
            {
                mx[counter, i] = rotatedRing[0];
                rotatedRing.RemoveAt(0);
            }
            if (rows > 2)
            {
                for (int i = counter + 1; i < rows - counter - 1; i++)
                {
                    mx[i, cols - counter - 1] = rotatedRing[0];
                    rotatedRing.RemoveAt(0);
                }
            }
            for (int i = cols - 1 - counter; i >= counter; i--)
            {
                mx[rows - counter - 1, i] = rotatedRing[0];
                rotatedRing.RemoveAt(0);
            }
            if (rows > 2)
            {
                for (int i = rows - counter - 2; i > counter; i--)
                {
                    mx[i, counter] = rotatedRing[0];
                    rotatedRing.RemoveAt(0);
                }
            }
            return mx;
        }
    }
}
