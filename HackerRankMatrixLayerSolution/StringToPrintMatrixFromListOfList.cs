using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankMatrixLayerSolution
{
    public class StringToPrintMatrixFromListOfList
    {
        public static string GetStringToPrintMatrix(List<List<int>> matrix, int lowerLimit, int upperLimit)
        {

            string toPrint = $"\n\r";
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count - 1; j++)
                {
                    int actual = matrix[i][j];
                    if (CheckIfMatrixElementsAreWithinLimits(actual, lowerLimit, upperLimit))
                        toPrint += actual.ToString().PadRight(12);
                }
                int lastInRaw = matrix[i][^1];
                if (CheckIfMatrixElementsAreWithinLimits(lastInRaw, lowerLimit, upperLimit))
                    toPrint += $"{lastInRaw}\n\r";
            }
            return toPrint;
        }



        public static bool CheckIfMatrixElementsAreWithinLimits(int actual, int lowerLimit, int upperLimit)
        {
            if (actual < lowerLimit)
                throw new ArgumentOutOfRangeException(nameof(actual), $"Any Element of the matrix should be minimum {lowerLimit}");
            else if (actual > upperLimit)
                throw new ArgumentOutOfRangeException(nameof(actual), $"Any Element of the matrix should be maximum {upperLimit}");
            else
                return true;
        }
    }
}
