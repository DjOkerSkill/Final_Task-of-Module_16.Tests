using NUnit.Framework;
using System;

namespace Final_Task_of_Module_16.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
       [Test]
        public void GetSumTwoValue() 
        {
            int a = 3; int b = 4;
            Calculator calculator = new Calculator();

            int expected = 7;
            int actual = calculator.Additional(a,b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSubTwoValue()
        {
            int a = 20; int b = 10;
            Calculator calculator = new Calculator();

            int expected = 10;
            int actual = calculator.Subtraction(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetMultiTwoValue()
        {
            int a = 6; int b = 5;
            Calculator calculator = new Calculator();

            int expected = 30;
            int actual = calculator.Miltiplication(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetDivisionTwoValue()
        {
            int a = 25; int b = 5;
            Calculator calculator = new Calculator();

            int expected = 5;
            int actual = calculator.Division(a, b);
            
            Assert.True(expected == actual);
        }

        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}