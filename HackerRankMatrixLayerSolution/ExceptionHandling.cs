namespace HackerRankMatrixLayerSolution
{
    public class ExceptionHandling
    {
        public static void CheckIfInputMatrixIsNull(List<List<int>> matrix)
        {

            if (matrix == null)
            {
                throw new NullReferenceException("The matrix should not be null.");
            }
        }

        public static void CheckIfInputMatrixIsEmpty(List<List<int>> matrix)
        {
            if (matrix.Count == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(matrix), "The matrix should not be empty.");
            }
        }
        public static void CheckIfAnyLineOfInputMatrixIsEmpty(List<List<int>> matrix)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                if (matrix[i].Count == 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(matrix), "Matrix should not contain empty line.");
                }
            }
        }
    }
}
