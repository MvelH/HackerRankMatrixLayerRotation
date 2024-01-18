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
    public class ResultMatrixTests
    {
        [TestMethod()]
        public void UpdateMatrixTest_CounterZero_GivesCorrectResult()
        {
            int[,] inputMatrix = new int[2, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            List<int> inputRotatedRing = new() { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[,] expected = new int[2, 4] { { 1, 2, 3, 4 }, { 8, 7, 6, 5 } };
            int[,] actual = ResultMatrix.UpdateResultMatrix(inputMatrix, 0, inputRotatedRing);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void UpdateMatrixTest_CounterNotZero_GivesCorrectResult()
        {
            int[,] inputMatrix = new int[4, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            List<int> inputRotatedRing = new() { 1, 2, 3, 4 };
            int[,] expected = new int[4, 4] { { 0, 0, 0, 0 }, { 0, 1, 2, 0 }, { 0, 4, 3, 0 }, { 0, 0, 0, 0 } };
            int[,] actual = ResultMatrix.UpdateResultMatrix(inputMatrix, 1, inputRotatedRing);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}