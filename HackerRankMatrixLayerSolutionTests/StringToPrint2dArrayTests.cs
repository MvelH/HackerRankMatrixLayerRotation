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
    public class StringToPrint2dArrayTests
    {
        [TestMethod()]
        public void GetStringToPrint2dArrayTest_2dArrayIsNotNullOrEmpty_GivesCorrectResult()
        {
            int[,] input2dArray = DataForTesting.s_TwoDArrayMx1;
            string expected = DataForTesting.s_ToPrintMx1;
            string actual = StringToPrint2dArray.GetStringToPrint2dArray(input2dArray);
            Assert.AreEqual(expected, actual);
        }
    }
}