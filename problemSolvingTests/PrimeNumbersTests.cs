using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemsSolving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.Tests
{
    [TestClass()]
    public class PrimeNumbersTests
    {
        [TestMethod()]
        public void GetPrimeNumbersTest()
        {
            PrimeNumbers primeNumbers = new PrimeNumbers();
            var result = primeNumbers.GetPrimeNumbers(5);
            Assert.AreEqual(2,result);
        }
        [TestMethod()]
        public void GetPrimeNumbersTest1()
        {
            PrimeNumbers primeNumbers = new PrimeNumbers();
            var result = primeNumbers.GetPrimeNumbers(6);
            Assert.AreEqual(2, result);
        }
    }
}