using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankMatrixLayerSolution
{
    public class StringToPrint2dArray
    {
        public static string GetStringToPrint2dArray(int[,] input)
        {
            string toPrint = $"\n\r";
            string temp;
            int counter = 1;
            foreach (int i in input)
            {
                int lineCount = input.GetLength(0);
                int cols = input.Length / lineCount;
                if (counter % cols == 0)
                {
                    temp = i.ToString();
                    toPrint += $"{temp}\n\r";
                    counter++;
                }
                else
                {
                    temp = i.ToString().PadRight(12);
                    toPrint += temp;
                    counter++;
                }
            }
            return toPrint;
        }
    }
}
