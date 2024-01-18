using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankMatrixLayerSolution
{
    public class RingManipulation
    {
        public static List<int> GetRingElements(List<List<int>> matrix, int counter)
        {
            int rows = matrix.Count;
            int cols = matrix[0].Count;
            List<int> ring = new();
            GetTopLineRingElements(matrix, counter, cols, ring);
            GetRightSideRingElements(matrix, counter, rows, cols, ring);
            GetBottomLineRingElements(matrix, counter, rows, cols, ring);
            GetLeftSideRingElements(matrix, counter, rows, ring);
            return ring;
        }

        public static List<int> RotateRingElements(List<int> ring, int moves)
        {
            List<int> start = ring.GetRange(moves, ring.Count - moves);
            List<int> end = ring.GetRange(0, moves);
            List<int> rotatedRing = start.Concat(end).ToList();
            return rotatedRing;
        }

        public static List<int> GetTopLineRingElements(List<List<int>> matrix, int counter, int cols, List<int> ring)
        {
            for (int i = counter; i < cols - counter; i++)
                ring.Add(matrix[counter][i]);
            return ring;
        }

        public static List<int> GetRightSideRingElements(List<List<int>> matrix, int counter, int rows, int cols, List<int> ring)
        {
            for (int i = counter + 1; i < rows - counter - 1; i++)
                ring.Add(matrix[i][cols - counter - 1]);
            return ring;
        }

        public static List<int> GetBottomLineRingElements(List<List<int>> matrix, int counter, int rows, int cols, List<int> ring)
        {
            for (int i = cols - 1 - counter; i >= counter; i--)
                ring.Add(matrix[rows - counter - 1][i]);
            return ring;
        }

        public static List<int> GetLeftSideRingElements(List<List<int>> matrix, int counter, int rows, List<int> ring)
        {
            for (int i = rows - counter - 2; i > counter; i--)
                ring.Add(matrix[i][counter]);
            return ring;
        }
    }
}
