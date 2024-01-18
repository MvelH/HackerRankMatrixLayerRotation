using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRankMatrixLayerSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRankMatrixLayerSolutionTests;

namespace HackerRankMatrixLayerSolution.Tests
{
    [TestClass()]
    public class MatrixLayerRotationTests
    {
        [TestMethod()]
        public void MatrixRotationTest_InputMatrixIsNull_ThrowsNullReferenceException()
        {
            List<List<int>>? inputMatrix = InputMatrixes.s_NullInputMatrix;

            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 8);
            }
            catch (NullReferenceException e)
            {
                StringAssert.Contains(e.Message, "The matrix should not be null.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void MatrixRotationTest_InputMatrixIsNotNull_NotThrowsNullReferenceException()
        {
            List<List<int>>? inputMatrix = InputMatrixes.s_Test1_Matrix;
            bool exceptionThrown = false;

            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 8);
            }
            catch (NullReferenceException)
            {
                exceptionThrown = true;
            }
            Assert.AreNotEqual(exceptionThrown, true);
        }

        [TestMethod()]
        public void MatrixRotationTest_InputMatrixIsEmpty_ThrowsArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_EmptyInputMatrix;
            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "The matrix should not be empty.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void MatrixRotationTest_InputMatrixHasEmptyLine_ThrowsArgumentOutOfRangeExeption()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_ContainsEmptyLineMatrix;

            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 8);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Matrix should not contain empty line.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void MatrixRotationTest_InputMatrixHasDifferentLengthLines_ThrowArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_DifferentLengthLinesMatrix;

            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "The matrix should not have different length lines.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void MatrixRotationTest_MatrixRowsAreLessThanTheDefinedMinimum__ThrowsArgumentOutOfRangeExeption()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_NotEnoughRows;
            int lowerLimit = MatrixLayerRotation.MinimumMatrixDimension;
            int upperLimit = MatrixLayerRotation.MaximumMatrixDimension;
            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, $"Any of the matrix dimensions should be minimum {lowerLimit} and maximum {upperLimit}.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void MatrixRotationTest_MatrixColumnsAreLessThanTheDefinedMinimum__ThrowsArgumentOutOfRangeExeption()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_NotEnoughColumns;
            int lowerLimit = MatrixLayerRotation.MinimumMatrixDimension;
            int upperLimit = MatrixLayerRotation.MaximumMatrixDimension;
            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, $"Any of the matrix dimensions should be minimum {lowerLimit} and maximum {upperLimit}.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void MatrixRotationTest_MatrixHasMoreRowsThanTheDefinedMaximum__ThrowsArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = InputMatrixes.CreateMatrixFilledWithTwos(2, MatrixLayerRotation.MaximumMatrixDimension + 1);
            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Any of the matrix dimensions should be minimum 2 and maximum 300.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void MatrixRotationTest_MatrixHasMoreColumnsThanTheDefinedMaximum__ThrowsArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = InputMatrixes.CreateMatrixFilledWithTwos(MatrixLayerRotation.MaximumMatrixDimension + 1, 2);
            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Any of the matrix dimensions should be minimum 2 and maximum 300.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void MatrixRotationTest_MinimumOfMatrixDimensionsRowsNotEven_ThrowsArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_MinimumOfMatrixDimensionsRowsNotEven;
            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 8);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "The minimum of matrix dimensions should be even.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void MatrixRotationTest_MinimumOfMatrixDimensionsColumnsNotEven_ThrowsArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_MinimumOfMatrixDimensionsColumnsNotEven;
            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 8);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "The minimum of matrix dimensions should be even.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void MatrixRotationTest_IfNumberOfRrotationsIsBiggerThanTheDefinedMaximum__ThrowsArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            int upperLimit = MatrixLayerRotation.MaximumRotations;
            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, upperLimit + 1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, $"The number of rotations should not be more than {upperLimit}.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void MatrixRotationTest_IfNumberOfRrotationsIsLessThanTheDefinedMinimum__ThrowsArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            int lowerLimit = MatrixLayerRotation.MinimumRotations;
            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, lowerLimit - 1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, $"The number of rotations should not be less than {lowerLimit}.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void MatrixRotationTest_IfAnyElementOfInputMatrixIsBiggerThanTheDefinedMaximum__ThrowsArgumantOutOfrangeException()
        {
            int upperLimit = MatrixLayerRotation.MaximumValueOfMatrixElement;
            List<List<int>> inputMatrix = new()
            {
                new List<int> { 1, 2 },
                new List<int> { 3, upperLimit + 1}
            };
            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, $"Any Element of the matrix should be maximum {upperLimit}");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void MatrixRotationTest_IfAnyElementOfInputMatrixIsLessThanTheDefinedMinimum__ThrowsArgumantOutOfrangeException()
        {
            int lowerLimit = MatrixLayerRotation.MinimumValueOfMatrixElement;
            List<List<int>> inputMatrix = new()
            {
                new List<int> { 1, 2 },
                new List<int> { 3, lowerLimit - 1}
            };
            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, $"Any Element of the matrix should be minimum {lowerLimit}");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void MatrixRotationTest_InputMatrixMeetsExpectations_NotThrowsArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            bool exceptionThrown = false;
            try
            {
                MatrixLayerRotation.MatrixRotation(inputMatrix, 2);
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionThrown = true;
            }
            Assert.AreNotEqual(exceptionThrown, true);
        }

        public void MatrixRotationTest_InputMatrixMeetsExpectations_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            int[,] actual =MatrixLayerRotation.MatrixRotation(inputMatrix, 9);
            int[,] expected = DataForTesting.s_ResultOfTest1_Matrix_9_Rotatios;

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}