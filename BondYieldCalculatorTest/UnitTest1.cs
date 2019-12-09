using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BondYieldCalculator;

namespace BondYieldCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double tolerance = 0.0000001; // an accuracy of 10 -7 for all results.
            Assert.AreEqual(Calculator.CalcPrice(0.10, 5, 1000, 0.15), 832.3922451, tolerance);
            Assert.AreEqual(Calculator.CalcYield(0.10, 5, 1000, 832.4), 0.1499974, tolerance);

            Assert.AreEqual(Calculator.CalcPrice(0.15, 5, 1000, 0.15), 1000.0000000, tolerance);
            Assert.AreEqual(Calculator.CalcPrice(0.10, 5, 1000, 1000), 0.1000000, tolerance);

            Assert.AreEqual(Calculator.CalcPrice(0.10, 5, 1000, 0.08), 1079.8542007, tolerance);
            Assert.AreEqual(Calculator.CalcYield(0.10, 5, 1000, 1079.85), 0.080000999, tolerance);

            Assert.AreEqual(Calculator.CalcPrice(0.10, 30, 1000, 0.19), 528.8807463, tolerance);
            Assert.AreEqual(Calculator.CalcYield(0.10, 30, 1000, 528.8807463), 0.1900000, tolerance);
        }
    }
}
