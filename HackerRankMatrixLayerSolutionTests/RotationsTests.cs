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
    public class RotationsTests
    {
        [TestMethod()]
        public void CheckIRotationsIsWithinLimits_IfRrotationsIsBiggerThanTheDefinedMaximum__ThrowsArgumentOutOfRangeException()
        {
            int lowerLimit = MatrixLayerRotation.MinimumRotations;
            int upperLimit = MatrixLayerRotation.MaximumRotations;
            int element = upperLimit + 1;
            try
            {
                Rotations.CheckIfRotationsIsWithinLimits(element, lowerLimit, upperLimit);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, $"The number of rotations should not be more than {upperLimit}.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod()]
        public void CheckIRotationsIsWithinLimits_IfRrotationsIsLessThanTheDefinedMinimum__ThrowsArgumentOutOfRangeException()
        {
            int lowerLimit = MatrixLayerRotation.MinimumRotations;
            int upperLimit = MatrixLayerRotation.MaximumRotations;
            int element = lowerLimit - 1;
            try
            {
                Rotations.CheckIfRotationsIsWithinLimits(element, lowerLimit, upperLimit);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, $"The number of rotations should not be less than {lowerLimit}.");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }


        [TestMethod()]
        public void CheckIRotationsIsWithinLimits_RrotationsIsWithinLimits__NotThrowsArgumentOutOfRangeException()
        {
            int lowerLimit = MatrixLayerRotation.MinimumRotations;
            int upperLimit = MatrixLayerRotation.MaximumRotations;
            int element = upperLimit -((upperLimit -lowerLimit)/2);
            bool exceptionThrown = false;
            try
            {
                Rotations.CheckIfRotationsIsWithinLimits(element, lowerLimit, upperLimit);
            }
            catch (ArgumentOutOfRangeException)
            {
               exceptionThrown = true;
            }
            Assert.AreNotEqual(exceptionThrown, true);
        }
    }
}