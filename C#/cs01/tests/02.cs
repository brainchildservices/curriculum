using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test02
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void AddInt2PositiveNumber()
        {
            Calculator calc = new Calculator();
            int myResult = calc.Add(3, 4);
            Assert.AreEqual(myResult, 7);
        }
        [Test]
        public void AddInt2NegativeNumber()
        {
            Calculator calc = new Calculator();
            int myResult = calc.Add(-3, -7);
            Assert.AreEqual(myResult, -10);
        }
        [Test]
        public void AddIntNegativePositiveNumber()
        {
            Calculator calc = new Calculator();
            int myResult = calc.Add(3, -7);
            Assert.AreEqual(myResult, -4);
        }
        [Test]
        public void AddTwoNames()
        {
            Calculator calc = new Calculator();
            string myResult = calc.Add("Syamil", " Sasi");
            Assert.AreEqual(myResult, "Syamil Sasi");
        }
        [Test]
        public void AddFloat2PositiveNumber()
        {
            Calculator calc = new Calculator();
            float myResult = calc.Add(3.5f, 4.5f);
            Assert.AreEqual(myResult, 8);
        }
        [Test]
        public void AddFloat2NegativeNumber()
        {
            Calculator calc = new Calculator();
            float myResult = calc.Add(-2.5f, -6.5f);
            Assert.AreEqual(myResult, -9);
        }
        [Test]
        public void AddFloatNegativePositiveNumber()
        {
            Calculator calc = new Calculator();
            float myResult = calc.Add(-2.5f, 6.5f);
            Assert.AreEqual(myResult, 4);
        }
        [Test]
        public void AddlongPositiveNumber()
        {
            Calculator calc = new Calculator();
            long myResult = calc.Add(23456789, 98765432);
            Assert.AreEqual(myResult, 122222221);
        }
        [Test]
        public void AddlongNegativeNumber()
        {
            Calculator calc = new Calculator();
            long myResult = calc.Add(-23456789, -98765432);
            Assert.AreEqual(myResult, -122222221);
        }
        [Test]
        public void AddlongPositiveNegativeNumber()
        {
            Calculator calc = new Calculator();
            long myResult = calc.Add(23456789, -98765432);
            Assert.AreEqual(myResult, -75308643);
        }
        [Test]
        public void SubtractInt2PositiveNumber()
        {
            Calculator calc = new Calculator();
            int myResult = calc.Subtract(9, 5);
            Assert.AreEqual(myResult, 4);
        }
        [Test]
        public void SubtractInt2NegativeNumber()
        {
            Calculator calc = new Calculator();
            int myResult = calc.Subtract(-3, -4);
            Assert.AreEqual(myResult, 1);
        }
        [Test]
        public void SubtractIntNegativePositiveNumber()
        {
            Calculator calc = new Calculator();
            int myResult = calc.Subtract(7, -3);
            Assert.AreEqual(myResult, 10);
        }
        [Test]
        public void SubtractFloat2PositiveNumber()
        {
            Calculator calc = new Calculator();
            float myResult = calc.Subtract(9.5f, 1.5f);
            Assert.AreEqual(myResult, 8);
        }
        [Test]
        public void SubtractFloat2NegativeNumber()
        {
            Calculator calc = new Calculator();
            float myResult = calc.Subtract(-2.5f, -6.5f);
            Assert.AreEqual(myResult, 4);
        }
        [Test]
        public void SubtractFloatNegativePositiveNumber()
        {
            Calculator calc = new Calculator();
            float myResult = calc.Subtract(6.5f, -6.5f);
            Assert.AreEqual(myResult, 13);
        }
        [Test]
        public void MultiplylongPositiveNumber()
        {
            Calculator calc = new Calculator();
            long myResult = calc.Multiply(93456789, 68765432);
            Assert.AreEqual(myResult, -1750792616);
        }
        [Test]
        public void MultiplylongNegativeNumber()
        {
            Calculator calc = new Calculator();
            long myResult = calc.Multiply(-23456789, -98765432);
            Assert.AreEqual(myResult, 1654553560);
        }
        [Test]
        public void MultiplylongPositiveNegativeNumber()
        {
            Calculator calc = new Calculator();
            long myResult = calc.Multiply(23456789, -98765432);
            Assert.AreEqual(myResult, -1654553560);
        }
    }
}