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
    public class RingManipulationTests
    {
        [TestMethod()]
        public void GetRingElementsTest_CounterIsZeroFirstTestMatrix_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            List<int> ringMx1Counter0 = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<int> actual = RingManipulation.GetRingElements(inputMatrix, 0);
            CollectionAssert.AreEqual(ringMx1Counter0, actual);
        }
        [TestMethod()]
        public void GetRingElementsTest_CounterNotZeroFirstTestMatrix_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            List<int> ringMx1Counter1 = new() { 1, 2, 3, 4 };
            List<int> actual = RingManipulation.GetRingElements(inputMatrix, 1);
            CollectionAssert.AreEqual(ringMx1Counter1, actual);
        }

        [TestMethod()]
        public void GetRingElementsTest_CounterIsZeroSecondTestMatrix_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_MinimumOfMatrixDimensionsRowsNotEven;
            List<int> ringMx2Counter0 = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            List<int> actual = RingManipulation.GetRingElements(inputMatrix, 0);
            CollectionAssert.AreEqual(ringMx2Counter0, actual);
        }

        [TestMethod()]
        public void GetRingElementsTest_CounterIsNotZeroSecondTestMatrix_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_MinimumOfMatrixDimensionsRowsNotEven;
            List<int> ringMx2Counter1 = new() { 101, 102, 103, 104, 105, 106, 107, 108, 109, 110 };
            List<int> actual = RingManipulation.GetRingElements(inputMatrix, 1);
            CollectionAssert.AreEqual(ringMx2Counter1, actual);
        }

        [TestMethod]
        public void GetTopLineRingElementsTest_CounterIsZero_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            List<int> elementsTopLineMx1Counter0 = new() { 1, 2, 3, 4 };
            List<int> output = new() { };
            List<int> actual = RingManipulation.GetTopLineRingElements(inputMatrix, 0, 4, output);
            CollectionAssert.AreEqual(elementsTopLineMx1Counter0, actual);
        }

        [TestMethod]
        public void GetTopLineRingElementsTest_CounterrIsNotZero_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            List<int> elementsTopLineMx1Counter1 = new() { 1, 2 };
            List<int> output = new() { };
            List<int> actual = RingManipulation.GetTopLineRingElements(inputMatrix, 1, 4, output);
            CollectionAssert.AreEqual(elementsTopLineMx1Counter1, actual);
        }

        [TestMethod]
        public void GetRightSideRingElementsTest_CounterIsZero__GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            List<int> elementsRightSideMx1Counter0 = new() { 5, 6 };
            List<int> output = new() { };
            List<int> actual = RingManipulation.GetRightSideRingElements(inputMatrix, 0, 4, 4, output);
            CollectionAssert.AreEqual(elementsRightSideMx1Counter0, actual);
        }


        [TestMethod]
        public void GetRightSideRingElementsTest_CounterIsNotZero_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            List<int> elementsRightSideMx1Counter1 = new() { 5, 6 };
            List<int> output = new() { };
            List<int> actual = RingManipulation.GetRightSideRingElements(inputMatrix, 0, 4, 4, output);
            CollectionAssert.AreEqual(elementsRightSideMx1Counter1, actual);
        }

        [TestMethod]
        public void GetBottomLineRingElementsTest_CounterIsZero_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            List<int> elementsBottomLineMx1Counter0 = new() { 7, 8, 9, 10 };
            List<int> output = new() { };
            List<int> actual = RingManipulation.GetBottomLineRingElements(inputMatrix, 0, 4, 4, output);
            CollectionAssert.AreEqual(elementsBottomLineMx1Counter0, actual);
        }

        [TestMethod]
        public void GetBottomLineRingElementsTest_CounterIsNotZero_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            List<int> elementsBottomLineMx1Counter1 = new() { 3, 4 };
            List<int> output = new() { };
            List<int> actual = RingManipulation.GetBottomLineRingElements(inputMatrix, 1, 4, 4, output);
            CollectionAssert.AreEqual(elementsBottomLineMx1Counter1, actual);
        }

        [TestMethod]
        public void GetLeftSideRingElementsTest_CounterIsZero_GivesCorrectResult()
        {
            List<List<int>> inputMatrix = InputMatrixes.s_Test1_Matrix;
            List<int> elementsLeftSideMx1Counter0 = new() { 11, 12 };
            List<int> output = new() { };
            List<int> actual = RingManipulation.GetLeftSideRingElements(inputMatrix, 0, 4, output);
            CollectionAssert.AreEqual(elementsLeftSideMx1Counter0, actual);
        }

        [TestMethod()]
        public void RotateRingElementsTest_MovesNotZero_GivesCorrectResult()
        {
            List<int> inputRing = DataForTesting.s_RingMx2Counter1;
            List<int> expected = DataForTesting.s_RotatedRingMx2Counter1moves7;
            List<int> actual = RingManipulation.RotateRingElements(inputRing, 7);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RotateRingElementsTest_MovesZero_GivesCorrectResult()
        {
            List<int> inputRing = DataForTesting.s_RingMx2Counter1;
            List<int> expected = DataForTesting.s_RotatedRingMx2Counter1movesZero;
            List<int> actual = RingManipulation.RotateRingElements(inputRing, 0);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}