using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankMatrixLayerSolution.Tests
{
    [TestClass()]
    public class ExceptionHandlingTests
    {
        [TestMethod()]
        public void CheckIfInputMatrixIsNullTest_InputMatrixIsNull_ThrowsNullReferenceExeption()
        {
            List<List<int>>? inputMatrix = InputMatrixes.s_NullInputMatrix;

            try
            {
                ExceptionHandling.CheckIfInputMatrixIsNull(inputMatrix);
            }
            catch (NullReferenceException e)
            {
                StringAssert.Contains(e.Message, "The matrix should not be null.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void CheckIfInputMatrixIsNullTest_InputMatrixIsNotNull_NotThrowsNullReferenceExeption()
        {
            List<List<int>>? inputMatrix = InputMatrixes.s_EmptyInputMatrix;
            bool exceptionThrown=false;

            try
            {
                ExceptionHandling.CheckIfInputMatrixIsNull(inputMatrix);
            }
            catch (NullReferenceException)
            {
                exceptionThrown = true;
            }
            Assert.AreNotEqual(exceptionThrown, true);
        }

        [TestMethod()]
        public void CheckIfInputMatrixIsEmptyTest_InputMatrixIsEmpty_ThrowsIndOutOfRangeExeption()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_EmptyInputMatrix;

            try
            {
                ExceptionHandling.CheckIfInputMatrixIsEmpty(inputMatrix);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "The matrix should not be empty.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void CheckIfInputMatrixIsEmptyTest_InputMatrixIsNotEmpty_NotThrowsIndOutOfRangeExeption()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_ContainsEmptyLineMatrix;
            bool exceptionThrown = false;

            try
            {
                ExceptionHandling.CheckIfInputMatrixIsEmpty(inputMatrix);
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionThrown=true;              
            }
            Assert.AreNotEqual(exceptionThrown, true);
        }

        [TestMethod()]
        public void CheckIfAnyLineOfInputMatrixIsEmptyTest_InputMatrixHasEmptyLine_ThrowsIndOutOfRangeExeption()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_ContainsEmptyLineMatrix;

            try
            {
                ExceptionHandling.CheckIfAnyLineOfInputMatrixIsEmpty(inputMatrix);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Matrix should not contain empty line.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void CheckIfAnyLineOfInputMatrixIsEmptyTest_InputMatrixHasNoEmptyLine_NotThrowsIndOutOfRangeExeption()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            bool exceptionThrown = false;
            try
            {
                ExceptionHandling.CheckIfAnyLineOfInputMatrixIsEmpty(inputMatrix);
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionThrown=true;
            }
            Assert.AreNotEqual(exceptionThrown, true);
        }
    }
}