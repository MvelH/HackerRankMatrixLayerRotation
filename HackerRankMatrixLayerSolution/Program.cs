using HackerRankMatrixLayerSolution;

Console.WriteLine("ROTATING MATRIXES");
Console.WriteLine("test1 matrix:");

var matrix =InputMatrixes.s_Test1_Matrix;
var numberOfRotations = 7;
if (matrix.GetType() != typeof(List<List<int>>))
{
    throw new ArgumentException("The input matrix type shold be a List<List<int>>");
}
else
{
    try
    {
        StringToPrintMatrixFromListOfList.GetStringToPrintMatrix(matrix, MatrixLayerRotation.MinimumValueOfMatrixElement, MatrixLayerRotation.MaximumValueOfMatrixElement);
    }
    catch (ArgumentOutOfRangeException ex)
    { 
        Console.WriteLine(ex.Message); 
    }
   
    try
    {
        int[,] result1 = MatrixLayerRotation.MatrixRotation(matrix, numberOfRotations);

        Console.WriteLine($"test1 matrix after {numberOfRotations} rotations:");
        Console.WriteLine(StringToPrint2dArray.GetStringToPrint2dArray(result1));
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine("=========================================================");
Console.WriteLine();

Console.WriteLine("EXCEPTION HANDLING EXAMPLES");
Console.WriteLine("null input matrix:");
try
{ int[,] resultNull = MatrixLayerRotation.MatrixRotation(InputMatrixes.s_NullInputMatrix, 7); }
catch (Exception ex)
{ Console.WriteLine(ex.Message); };
Console.WriteLine("=========================================================");
Console.WriteLine();

Console.WriteLine("empty input matrix:");
try
{ int[,] resultEmpty = MatrixLayerRotation.MatrixRotation(InputMatrixes.s_EmptyInputMatrix, 7); }
catch (Exception ex)
{ Console.WriteLine(ex.Message); };
Console.WriteLine("=========================================================");
Console.WriteLine();

Console.WriteLine("contains empty line input matrix:");
try
{ int[,] resultContainsEmptyLine = MatrixLayerRotation.MatrixRotation(InputMatrixes.s_ContainsEmptyLineMatrix, 7); }
catch (Exception ex)
{ Console.WriteLine(ex.Message); };
Console.WriteLine("=========================================================");
Console.WriteLine();

Console.WriteLine("too small input matrix with not enough rows:");
try
{ int[,] resultTooSmallMatrix = MatrixLayerRotation.MatrixRotation(InputMatrixes.s_NotEnoughRows, 7); }
catch (Exception ex)
{ Console.WriteLine(ex.Message); }
Console.WriteLine("=========================================================");
Console.WriteLine();

Console.WriteLine("too small input matrix with not enough columns:");
try
{ int[,] resultTooSmallMatrix = MatrixLayerRotation.MatrixRotation(InputMatrixes.s_NotEnoughColumns, 7); }
catch (Exception ex)
{ Console.WriteLine(ex.Message); }
Console.WriteLine("=========================================================");
Console.WriteLine();

Console.WriteLine("input matrix with not even minimum of matrix dimensions");
try
{ int[,] resultTooSmallMatrix = MatrixLayerRotation.MatrixRotation(InputMatrixes.s_MinimumOfMatrixDimensionsRowsNotEven, 7); }
catch (Exception ex)
{ Console.WriteLine(ex.Message); }
Console.WriteLine("=========================================================");
Console.WriteLine();

Console.WriteLine("original matrix named tooLowElement");
try
{
    int[,] rotatedTooLowElement = MatrixLayerRotation.MatrixRotation(InputMatrixes.s_TooLowElement, 2);
    Console.WriteLine(StringToPrint2dArray.GetStringToPrint2dArray(rotatedTooLowElement));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("=========================================================");
Console.WriteLine();
