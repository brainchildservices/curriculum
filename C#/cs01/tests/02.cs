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
        public void AddIntTest()
        {
            Calculator Calc = new Calculator();
            int expected;
            int result = 11;
            expected = Calc.Add(5, 6);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AddDblTest()
        {
            Calculator Calc = new Calculator();
            double expected;
            double result = 11.22D;
            expected = Calc.Add(5.11D, 6.11D);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AddStrTest()
        {
            Calculator Calc = new Calculator();
            string expected;
            string result = "Vishnu Unnikrishnan";
            expected = Calc.Add("Vishnu ", "Unnikrishnan");
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AddFltTest()
        {
            Calculator Calc = new Calculator();
            float expected;
            float result = 10.0000000F;
            expected = Calc.Add(5.9000000F, 4.1000000F);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AddLongTest()
        {
            Calculator Calc = new Calculator();
            long expected;
            long result = 100000000L;
            expected = Calc.Add(59000000L, 41000000L);
            Assert.AreEqual(expected, result);
        }

        //Substraction 
        [Test]
        public void SubIntTest()
        {
            Calculator Calc = new Calculator();
            int expected;
            int result = -1;
            expected = Calc.Sub(5, 6);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void SubDblTest()
        {
            Calculator Calc = new Calculator();
            double expected;
            double result = -1.00d;
            expected = Calc.Sub(5.11D, 6.11D);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void SubFltTest()
        {
            Calculator Calc = new Calculator();
            float expected;
            float result = 1.80000019F;
            expected = Calc.Sub(5.9000000F, 4.1000000F);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void SubLongTest()
        {
            Calculator Calc = new Calculator();
            long expected;
            long result = 18000000L;
            expected = Calc.Sub(59000000L, 41000000L);
            Assert.AreEqual(expected, result);
        }
        // Multiplication 
        [Test]
        public void MulIntTest()
        {
            Calculator Calc = new Calculator();
            int expected;
            int result = 30;
            expected = Calc.Mul(5, 6);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void MulDblTest()
        {
            Calculator Calc = new Calculator();
            double expected;
            double result = 31.222100000000005d;
            expected = Calc.Mul(5.11D, 6.11D);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void MulFltTest()
        {
            Calculator Calc = new Calculator();
            float expected;
            float result = 24.1900005f;
            expected = Calc.Mul(5.9000000F, 4.1000000F);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void MulLongTest()
        {
            Calculator Calc = new Calculator();
            long expected;
            long result = 2419000000000000;
            expected = Calc.Mul(59000000L, 41000000L);
            Assert.AreEqual(expected, result);
        }
    }
}
