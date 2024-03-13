using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckAvailabily;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemsSolving;

namespace CheckAvailabily.Tests
{
    [TestClass()]
    public class UnitTest
    {
        [TestMethod()]
        public void GetTheStringLengthTest()
        {
            FindTheStringLength findTheStringLength = new FindTheStringLength();
            string input = "";
            var result=findTheStringLength.GetTheStringLength(input);

            Assert.AreEqual(0, result);
        }
        [TestMethod()]
        public void GetTheStringLengthTest2()
        {
            FindTheStringLength findTheStringLength = new FindTheStringLength();
            string input = "A";
            var result = findTheStringLength.GetTheStringLength(input);

            Assert.AreEqual(1, result);
        }
        [TestMethod()]
        public void GetTheStringLengthTest3()
        {
            FindTheStringLength findTheStringLength = new FindTheStringLength();
            string input = "Hello Ramya";
            var result = findTheStringLength.GetTheStringLength(input);

            Assert.AreEqual(11, result);
        }
    }
}