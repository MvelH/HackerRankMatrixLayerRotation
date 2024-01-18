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
    public class StringToPrintMatrixFromListOfListTests
    {
        [TestMethod()]
        public void GetStringToPrintMatrixTest_MatrixIsNotNullOrEmpty_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            int lowerLimit = MatrixLayerRotation.MinimumValueOfMatrixElement;
            int upperlimit = MatrixLayerRotation.MaximumValueOfMatrixElement;
            string expected = DataForTesting.s_ToPrintMx1;
            string actual = StringToPrintMatrixFromListOfList.GetStringToPrintMatrix(inputMatrix, lowerLimit, upperlimit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(100000000, 1, 100000000, true)]
        [DataRow(1, 1, 100000000, true)]
        [DataRow(728, 1, 100000000, true)]
        public void CheckIfMatrixElementsAreWithinLimitsTest_ElementsAreWithinLimits_FromDataRawTest_GivesCorrectResult(int x, int y, int z, bool expected)
        {
            bool actual = StringToPrintMatrixFromListOfList.CheckIfMatrixElementsAreWithinLimits(x, y, z);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfMatrixElementsAreWithinLimitsTest_ElementValueIsBelowLowerLimit_ThrowArgumentOutOfRangeException()
        {
            int lowerLimit = MatrixLayerRotation.MinimumValueOfMatrixElement;
            int upperLimit = MatrixLayerRotation.MaximumValueOfMatrixElement;
            int element = lowerLimit - 1;
            try
            { bool actual = StringToPrintMatrixFromListOfList.CheckIfMatrixElementsAreWithinLimits(element, lowerLimit, upperLimit); }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, $"Any Element of the matrix should be minimum {lowerLimit}");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void CheckIfMatrixElementsAreWithinLimitsTest_ElementValueIsAboveUpperLimit_ThrowArgumentOutOfRangeException()
        {
            int lowerLimit = MatrixLayerRotation.MinimumValueOfMatrixElement;
            int upperLimit = MatrixLayerRotation.MaximumValueOfMatrixElement;
            int element = upperLimit + 1;
            try
            { bool actual = StringToPrintMatrixFromListOfList.CheckIfMatrixElementsAreWithinLimits(element, lowerLimit, upperLimit); }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, $"Any Element of the matrix should be maximum {upperLimit}");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }


        [TestMethod]
        public void CheckIfMatrixElementsAreWithinLimitsTest_ElementValueIsWithinLimits_NotThrowArgumentOutOfRangeException()
        {
            int lowerLimit = MatrixLayerRotation.MinimumValueOfMatrixElement;
            int upperLimit = MatrixLayerRotation.MaximumValueOfMatrixElement;
            int element = upperLimit - ((upperLimit - lowerLimit)/2);
            bool exceptionThrown = false;
            try
            { bool actual = StringToPrintMatrixFromListOfList.CheckIfMatrixElementsAreWithinLimits(element, lowerLimit, upperLimit); }
            catch (ArgumentOutOfRangeException)
            {
                exceptionThrown = true;
            }
            Assert.AreNotEqual(exceptionThrown, true);
        }
    }
}