using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankMatrixLayerSolution
{
    public class MatrixLayerRotation
    {
        public const int MinimumMatrixDimension = 2;
        public const int MaximumMatrixDimension = 300;
        public const int MaximumNumberOfRotations = 1000000000;
        public const int MaximumValueOfMatrixElement = 100000000;
        public const int MinimumValueOfMatrixElement = 1;
        public const int MinimumRotations = 1;
        public const int MaximumRotations = 1000000000;

        public static int[,] MatrixRotation(List<List<int>>? matrix, int r) 
        {
            ExceptionHandling.CheckIfInputMatrixIsNull(matrix);
            ExceptionHandling.CheckIfInputMatrixIsEmpty(matrix);
            ExceptionHandling.CheckIfAnyLineOfInputMatrixIsEmpty(matrix);
            InputMatrixData.CheckIfAllMatrixLinesAreSameLength(matrix);
            InputMatrixData.CheckMatrixDimensions(matrix, MaximumMatrixDimension, MinimumMatrixDimension);
            InputMatrixData.CheckIfTheMinimumOfMatrixDimensionsIsEven(matrix);
            Rotations.CheckIfRotationsIsWithinLimits(r, MinimumRotations, MaximumRotations);

            Console.WriteLine(StringToPrintMatrixFromListOfList.GetStringToPrintMatrix(matrix, MinimumValueOfMatrixElement, MaximumValueOfMatrixElement));

            int rows = InputMatrixData.DefineNumberOfRowsInInputMatrix(matrix);
            int cols = InputMatrixData.DefineNumberOfColumnsInInputMatrix(matrix);
            int[,] resultmatrix = new int[rows, cols];

            int numberOfRings = RingData.DefineNumberOfRings(rows, cols);
            for (int counter = 0; counter < numberOfRings; counter++)
            {
                int ringCount = RingData.DefineRingCount(rows, cols, counter);

                int moves;
                try
                { moves = RingData.DefineNumberOfMoves(r, ringCount); }
                catch (DivideByZeroException)
                { throw new DivideByZeroException("The number of rings to rotate must be minimum 1."); }

                List<int> ring;
                try
                { ring = RingManipulation.GetRingElements(matrix, counter); }
                catch (ArgumentOutOfRangeException)
                { throw; }

                List<int> rotatedRing = RingManipulation.RotateRingElements(ring, moves);
                ResultMatrix.UpdateResultMatrix(resultmatrix, counter, rotatedRing);
            }
            return resultmatrix;
        }
    }
}
