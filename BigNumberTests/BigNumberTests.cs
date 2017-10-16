using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumber.Tests
{
    [TestClass()]
    public class BigNumberTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            BigNumber number = new BigNumber("123456");

            string actual = number.ToString();

            Assert.AreEqual("123456", actual);
        }

        [TestMethod()]
        public void AddTest()
        {
            BigNumber a = new BigNumber("123456");
            BigNumber b = new BigNumber("654312");

            BigNumber actual = a.Add(b);

            Assert.AreEqual("777768", actual.ToString());
        }

        [TestMethod()]
        public void AddTest2()
        {
            BigNumber a = new BigNumber("123");
            BigNumber b = new BigNumber("12");

            BigNumber actual = a.Add(b);

            Assert.AreEqual("135", actual.ToString());
        }

        [TestMethod()]
        public void AddTest3()
        {
            BigNumber a = new BigNumber("12");
            BigNumber b = new BigNumber("123");

            BigNumber actual = a.Add(b);

            Assert.AreEqual("135", actual.ToString());
        }

        [TestMethod()]
        public void AddTest4()
        {
            BigNumber a = new BigNumber("99");
            BigNumber b = new BigNumber("1");

            BigNumber actual = a.Add(b);

            Assert.AreEqual("100", actual.ToString());
        }

        [TestMethod()]
        public void AddTest5()
        {
            BigNumber a = new BigNumber("199");
            BigNumber b = new BigNumber("1");

            BigNumber actual = a.Add(b);

            Assert.AreEqual("200", actual.ToString());
        }
    }
}