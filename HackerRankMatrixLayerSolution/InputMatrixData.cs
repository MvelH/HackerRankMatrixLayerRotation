using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankMatrixLayerSolution
{
    public class InputMatrixData
    {
        public static int DefineNumberOfRowsInInputMatrix(List<List<int>> matrix)
        {
            ExceptionHandling.CheckIfInputMatrixIsNull(matrix);
            int rows = matrix.Count;
            return rows;
        }

        public static int DefineNumberOfColumnsInInputMatrix(List<List<int>> matrix)
        {
            ExceptionHandling.CheckIfInputMatrixIsNull(matrix);
            ExceptionHandling.CheckIfInputMatrixIsEmpty(matrix);
            int cols = matrix[0].Count;
            return cols;
        }

        public static void CheckMatrixDimensions(List<List<int>> matrix, int upperLimit, int lowerLimit)
        {
            int rows = DefineNumberOfRowsInInputMatrix(matrix);
            int cols = DefineNumberOfColumnsInInputMatrix(matrix);
            if (rows < lowerLimit || rows > upperLimit
                || cols < lowerLimit || cols > upperLimit)
            {
                throw new ArgumentOutOfRangeException(nameof(matrix), $"Any of the matrix dimensions should be minimum {lowerLimit} and maximum {upperLimit}.");
            }
        }

        public static void CheckIfAllMatrixLinesAreSameLength(List<List<int>> matrix)
        {
            int lineLength = matrix[0].Count;
            for (int i = 1; i < matrix.Count; i++)
            {
                if (matrix[i].Count != lineLength)
                {
                    throw new ArgumentOutOfRangeException(nameof(matrix), "The matrix should not have different length lines.");
                }
            }
        }

        public static void CheckIfTheMinimumOfMatrixDimensionsIsEven(List<List<int>> matrix)
        {
            int rows = DefineNumberOfRowsInInputMatrix(matrix);
            int cols = DefineNumberOfColumnsInInputMatrix(matrix);
            if (Math.Min(rows, cols) % 2 != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(matrix), "The minimum of matrix dimensions should be even.");
            }
        }
    }
}
