using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRankMatrixLayerSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankMatrixLayerSolution.Tests
{
    [TestClass()]
    public class InputMatrixDataTests
    {
        [TestMethod]
        public void CheckIfAllMatrixLinesAreSameLength_InputMatrixHasDifferentLengthLines_ThrowArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_DifferentLengthLinesMatrix;

            try
            {
                InputMatrixData.CheckIfAllMatrixLinesAreSameLength(inputMatrix);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "The matrix should not have different length lines.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void CheckIfAllMatrixLinesAreSameLength_InputMatrixHasAllSameLengthLines_NotThrowArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            bool exceptionThrown = false;

            try
            {
                InputMatrixData.CheckIfAllMatrixLinesAreSameLength(inputMatrix);
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionThrown = true;
            }
            Assert.AreNotEqual(exceptionThrown, true);
        }

        [TestMethod()]
        public void DefineNumberOfRowsInInputMatrixTest_InputMatrixIsNull_ThrowNullReferenceException()
        {
            List<List<int>>? inputMatrix = InputMatrixes.s_NullInputMatrix;

            try
            {
                InputMatrixData.DefineNumberOfRowsInInputMatrix(inputMatrix);
            }
            catch (NullReferenceException e)
            {
                StringAssert.Contains(e.Message, "The matrix should not be null.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void DefineNumberOfRowsInInputMatrixTest_InputMatrixIsEmpty_GivesCorrectReault()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_EmptyInputMatrix;
            int expected = 0;
            int actual = InputMatrixData.DefineNumberOfRowsInInputMatrix(inputMatrix);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DefineNumberOfRowsInInputMatrixTest_InputMatrixIsNotNullOrEmpty_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            int expected = 4;
            int actual = InputMatrixData.DefineNumberOfRowsInInputMatrix(inputMatrix);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DefineNumberOfColumnsInInputMatrixTest_InputMatrixIsNull_ThrowNullReferenceException()
        {
            List<List<int>>? inputMatrix = InputMatrixes.s_NullInputMatrix;

            try
            {
                InputMatrixData.DefineNumberOfColumnsInInputMatrix(inputMatrix);
            }
            catch (NullReferenceException e)
            {
                StringAssert.Contains(e.Message, "The matrix should not be null.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void DefineNumberOfColumnsInInputMatrixTest_InputMatrixIsEmpty_ThrowArgumentIsOutOfRangeException()
        {
            List<List<int>>? inputMatrix = InputMatrixes.s_EmptyInputMatrix;

            try
            {
                InputMatrixData.DefineNumberOfColumnsInInputMatrix(inputMatrix);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "The matrix should not be empty.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void DefineNumberOfColumnsInInputMatrixTest_InputMatrixIsNotNullOrEmpty_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            int expected = 4;
            int actual = InputMatrixData.DefineNumberOfColumnsInInputMatrix(inputMatrix);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckMatrixDimensionsTest_InputMatrixIsNull_ThrowNullReferenceException()
        {
            List<List<int>>? inputMatrix = InputMatrixes.s_NullInputMatrix;
            int upperLimit = MatrixLayerRotation.MaximumMatrixDimension;
            int lowerLimit = MatrixLayerRotation.MinimumMatrixDimension;
            try
            {
                InputMatrixData.CheckMatrixDimensions(inputMatrix, upperLimit, lowerLimit);
            }
            catch (NullReferenceException e)
            {
                StringAssert.Contains(e.Message, "The matrix should not be null.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void CheckMatrixDimensions_AnyOfMatrixDimensionsIsLessThanTheDefinedMinimum__ThrowsArgumentOutOfRangeExeption()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_NotEnoughRows;
            int upperLimit = MatrixLayerRotation.MaximumMatrixDimension;
            int lowerLimit = MatrixLayerRotation.MinimumMatrixDimension;
            try
            {
                InputMatrixData.CheckMatrixDimensions(inputMatrix, upperLimit, lowerLimit);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, $"Any of the matrix dimensions should be minimum {MatrixLayerRotation.MinimumMatrixDimension} and maximum {MatrixLayerRotation.MaximumMatrixDimension}.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }


        [TestMethod()]
        public void CheckMatrixDimensionsTest_AnyOfMatrixDimensionsIsBiggerThanTheDefinedMaximum__ThrowsArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = new();
            List<int> line = new();
            for (int i = 0; i < MatrixLayerRotation.MaximumMatrixDimension + 1; i++)
                line.Add(2);
            for (int i = 0; i < 2; i++)
                inputMatrix.Add(line);
            int upperLimit = MatrixLayerRotation.MaximumMatrixDimension;
            int lowerLimit = MatrixLayerRotation.MinimumMatrixDimension;

            try
            {
                InputMatrixData.CheckMatrixDimensions(inputMatrix, upperLimit, lowerLimit);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, $"Any of the matrix dimensions should be minimum {lowerLimit} and maximum {upperLimit}.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void CheckMatrixDimensions_BothMatrixDimensionsAreWithinLimits__NotThrowsArgumentOutOfRangeExeption()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            int upperLimit = MatrixLayerRotation.MaximumMatrixDimension;
            int lowerLimit = MatrixLayerRotation.MinimumMatrixDimension;
            bool exceptionThrown = false;
            try
            {
                InputMatrixData.CheckMatrixDimensions(inputMatrix, upperLimit, lowerLimit);
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionThrown = true;
            }
            Assert.AreNotEqual(exceptionThrown, true);
        }

        [TestMethod()]
        public void CheckIfTheMinimumOfMatrixDimensionsIsEvenTest_InputMatrixIsNull_ThrowNullReferenceException()
        {
            List<List<int>>? inputMatrix = InputMatrixes.s_NullInputMatrix;

            try
            {
                InputMatrixData.CheckIfTheMinimumOfMatrixDimensionsIsEven(inputMatrix);
            }
            catch (NullReferenceException e)
            {
                StringAssert.Contains(e.Message, "The matrix should not be null.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void CheckIfTheMinimumOfMatrixDimensionsIsEvenTest_MinimumOfMatrixDimensionsNotEven_ThrowsArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_MinimumOfMatrixDimensionsRowsNotEven;
            try
            {
                InputMatrixData.CheckIfTheMinimumOfMatrixDimensionsIsEven(inputMatrix);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "The minimum of matrix dimensions should be even.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void CheckIfTheMinimumOfMatrixDimensionsIsEvenTest_MinimumOfMatrixDimensionsEven_NotThrowsArgumentOutOfRangeException()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            bool exceptionThrown=false;
            try
            {
                InputMatrixData.CheckIfTheMinimumOfMatrixDimensionsIsEven(inputMatrix);
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionThrown=true;
            }
            Assert.AreNotEqual(exceptionThrown, true);
        }

    }
}