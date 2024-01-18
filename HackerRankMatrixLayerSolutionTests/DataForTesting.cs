namespace HackerRankMatrixLayerSolutionTests
{
    internal class DataForTesting
    {
        public readonly static int[,] s_TwoDArrayMx1 = new int[4, 4] { { 1, 2, 3, 4 }, { 12, 1, 2, 5 }, { 11, 4, 3, 6 }, { 10, 9, 8, 7 } };
        public readonly static int[,] s_ResultOfTest1_Matrix_9_Rotatios = new int[4, 4] { { 4, 5, 6, 7 }, { 3, 2, 3, 8 }, { 2, 4, 1, 9 }, { 10, 11, 12, 1 } };

        public readonly static List<int> s_RingMx2Counter1 = new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109, 110 };
        public readonly static List<int> s_RotatedRingMx2Counter1moves7 = new() { 108, 109, 110, 101, 102, 103, 104, 105, 106, 107 };
        public readonly static List<int> s_RotatedRingMx2Counter1movesZero = new() { 101, 102, 103, 104, 105, 106, 107, 108, 109, 110 };


        private readonly static string s_line0 = $"\n\r";
        private readonly static string s_line1mx1 = $"1           2           3           4\n\r";
        private readonly static string s_line2mx1 = $"12          1           2           5\n\r";
        private readonly static string s_line3mx1 = $"11          4           3           6\n\r";
        private readonly static string s_line4mx1 = $"10          9           8           7\n\r";
        public readonly static string s_ToPrintMx1 = s_line0 + s_line1mx1 + s_line2mx1 + s_line3mx1 + s_line4mx1;

    }
}
