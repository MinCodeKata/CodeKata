using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKataPractice;

namespace StringCalculate_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestEmptyString()
        {
            var sc = new StringCalculate();
            Assert.AreEqual(0, sc.Add(string.Empty));
        }

        [TestMethod]
        public void TestSingleNumber()
        {
            var sc = new StringCalculate();
            Assert.AreEqual(5, sc.Add("5"));
            Assert.AreEqual(0, sc.Add("0"));
        }

        [TestMethod]
        public void TestCommaDelimitNumber()
        {
            var sc = new StringCalculate();
            Assert.AreEqual(11, sc.Add("5,6"));
        }

        [TestMethod]
        public void TestSingleCharDelimitNumber()
        {
            var sc = new StringCalculate();
            Assert.AreEqual(11, sc.Add("5#6"));
        }

        [TestMethod]
        public void TestDoubleCharDelimitNumber()
        {
            var sc = new StringCalculate();
            Assert.AreEqual(5, sc.Add("5#£"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNegativeNumber()
        {
            var sc = new StringCalculate();
            int i = sc.Add("-5");
        }

        [TestMethod]
        public void TestMaxiNumber()
        {
            var sc = new StringCalculate();
            Assert.AreEqual(0, sc.Add("1001"));
        }

        [TestMethod]
        public void TestMaxiTotalNumber()
        {
            var sc = new StringCalculate();
            Assert.AreEqual(0, sc.Add("500,501"));
        }
    }
}
