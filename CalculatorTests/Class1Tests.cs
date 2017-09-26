using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorShared.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        private Calculator _calculator;

        [TestMethod()]
        public void PlusTest()
        {
          Calculator calculator = new Calculator();
            calculator.Plus(10, 10);
            Assert.AreEqual(20, calculator.Plus(10,10));
        }



        [TestMethod()]
        public void MinusTest()
        {
            Calculator calculator = new Calculator();
            calculator.Minus(20, 10);
            Assert.AreEqual(10, calculator.Minus(20,10));
        }

        [TestMethod()]
        public void GangeTest()
        {
            Calculator calculator = new Calculator();
            calculator.Gange(5, 5);
            Assert.AreEqual(25, calculator.Gange(5,5));
        }

        [TestMethod()]
        public void DividerTest()
        {
            Calculator calculator = new Calculator();
            calculator.Divider(10, 2);
            Assert.AreEqual(5, calculator.Divider(10,2));
        }
    }
}