using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemsSolving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.Tests
{
    [TestClass]
    public class FactorialNumberTests
    {
        [TestMethod]
        public void GetFactorialNumberTest()
        {
            FactorialNumber factorialNumber = new FactorialNumber();
            var result = factorialNumber.GetFactorialNumber(4);
            Assert.AreEqual(24, result);
        }
        [TestMethod]
        public void GetFactorialNumberTest1()
        {
            FactorialNumber factorialNumber = new FactorialNumber();
            var result = factorialNumber.GetFactorialNumber(-1);
            //Assert.AreEqual(24, result);
        }
        [TestMethod]
        public void GetFactorialNumberTest2()
        {
            FactorialNumber factorialNumber = new FactorialNumber();
            var result = factorialNumber.GetFactorialNumber(10);
            Assert.AreEqual(3628800, result);
        }
    }
}