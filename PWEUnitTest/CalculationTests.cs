using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PWEWebIpiTest.Utilities;

namespace PWEUnitTest
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void TestMultiplicationTwoPositiveNumbers()
        {
            CalculationHelper helper = new CalculationHelper();
            int result = helper.Multiply(3, 4);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void TestMultiplicationOnsIsZero()
        {
            CalculationHelper helper = new CalculationHelper();
            int result = helper.Multiply(0, 5);
            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void TestMultiplicationOneIsNegative()
        {
            CalculationHelper helper = new CalculationHelper();
            int result = helper.Multiply(-1, 5);
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void TestDevisionByZero()
        {
            CalculationHelper helper = new CalculationHelper();
            double result = helper.Devision(5, 0);
            Assert.AreEqual(0, result);
        }
    }
}
