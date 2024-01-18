namespace HackerRankMatrixLayerSolution
{
    public class InputMatrixes
    {
        public readonly static List<List<int>>? s_NullInputMatrix = null;
        public readonly static List<List<int>> s_EmptyInputMatrix = new();

        public readonly static List<List<int>> s_ContainsEmptyLineMatrix = new()
        {
            new List<int> { 1, 2, 3, 4 },
            new List<int> {},
                new List<int> { 11, 4, 3, 6 },
            new List<int> { 10, 9, 8, 7 }
        };

        public readonly static List<List<int>> s_NotEnoughRows = new() { new List<int> { 1, 4, 6, 2 } };
        public readonly static List<List<int>> s_NotEnoughColumns = new()
        {   
            new List<int> { 1},
            new List<int> { 2}
        };

        public readonly static List<List<int>> s_Test1_Matrix = new()
        {
            new List<int> { 1, 2, 3, 4 },
            new List<int> { 12, 1, 2, 5 },
            new List<int> { 11, 4, 3, 6 },
            new List<int> { 10, 9, 8, 7 }
        };


        public readonly static List<List<int>> s_DifferentLengthLinesMatrix = new()
        {
            new List<int> { 1, 2, 3, 4 },
            new List<int> { 12, 1, 2 },
            new List<int> { 11, 4, 3, 6 },
            new List<int> { 10, 9, 8, 7 }
        };
        public readonly static List<List<int>> s_MinimumOfMatrixDimensionsRowsNotEven = new()
        {
            new List<int> { 1, 2, 3, 4, 5, 6 },
            new List<int> { 18, 101, 102, 103, 104, 7 },
            new List<int> { 17, 110, 201, 202, 105, 8 },
            new List<int> { 16, 109, 108, 107, 106, 9 },
            new List<int> { 15, 14, 13, 12, 11, 10 }
        };
        public readonly static List<List<int>> s_MinimumOfMatrixDimensionsColumnsNotEven = new()
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 18, 101, 102 },
            new List<int> { 17, 110, 201 },
            new List<int> { 16, 109, 108 },
            new List<int> { 15, 14, 13 }
        };

        public readonly static List<List<int>> s_TooLowElement = new()
        {
            new List<int> { 1, 0, 3, 4 },
            new List<int> { 12, 1, 2, 5 },
            new List<int> { 11, 4, 3, 6 },
            new List<int> { 10, 9, 8, 7 }
        };

        public static List<List<int>> CreateMatrixFilledWithTwos(int rows, int columns)
        {
            List<List<int>> inputMatrix = new();
            List<int> line = new();
            for (int i = 0; i < columns; i++)
                line.Add(2);
            for (int i = 0; i < rows; i++)
                inputMatrix.Add(line);
            return inputMatrix;
        }
    }
}
