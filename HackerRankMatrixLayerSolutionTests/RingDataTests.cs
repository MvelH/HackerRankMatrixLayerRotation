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
    public class RingDataTests
    {
        [TestMethod()]
        [DataRow(4, 5, 2)]
        [DataRow(0, 0, 0)]
        [DataRow(5, 5, 2)]
        [DataRow(7, 3, 1)]
        public void DefineNumberOfRingsTest_FromDataRowTest(int x, int y, int expected)
        {
            int actual = RingData.DefineNumberOfRings(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(4, 5, 1, 6)]
        [DataRow(5, 5, 1, 8)]
        [DataRow(7, 3, 0, 16)]
        public void DefineRingCountTest_FromDataRowTest(int x, int y, int z, int expected)
        {
            int actual = RingData.DefineRingCount(x, y, z);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DefineNumberOfMovesTest_RingcountIsZero_ThrowDevideByZeroException()
        {
            try
            {
                RingData.DefineNumberOfMoves(44, 0);
            }
            catch (DivideByZeroException e)
            {
                StringAssert.Contains(e.Message, "ringCount should not be zero");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void DefineNumberOfMovesTest_RingcountIsNotZero_NotThrowDevideByZeroException()
        {
            bool exceptionThrown = false;
            try
            {
                RingData.DefineNumberOfMoves(44, 3);
            }
            catch (DivideByZeroException)
            {
                exceptionThrown = true;
            }
            Assert.AreNotEqual(exceptionThrown, true);
        }

        [TestMethod()]
        [DataRow(2, 8, 2)]
        [DataRow(15, 8, 7)]
        [DataRow(12, 12, 0)]
        public void DefineNumberOfMovesTest_FromDataRowTest(int x, int y, int expected)
        {
            int actual = RingData.DefineNumberOfMoves(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}