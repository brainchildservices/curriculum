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
        public void AddIntSameNumbers()
        {
            Calculator calc=new Calculator();
            int result=calc.Add(2,2);
            Assert.AreEqual(result,4);
        }
        [Test]
        public void AddIntDifferentNumbers()
        {
            Calculator calc=new Calculator();
            int result=calc.Add(6,2);
            Assert.AreEqual(result,8);
        }
        [Test]
        public void AddFloatSameNumbers()
        {
            Calculator calc=new Calculator();
            float result=calc.Add(1.8f,1.8f);
            Assert.AreEqual(result,3.6f);
        }
        [Test]
        public void AddFloatDifferentNumbers()
        {
            Calculator calc=new Calculator();
            float result=calc.Add(1.05f,1.02f);
            Assert.AreEqual(result,2.07f);
        }
        [Test]
        public void AddLongDifferentNumbers()
        {
            Calculator calc=new Calculator();
            long result=calc.Add(4223372036854775807,3223372036854775807);
            Assert.AreEqual(result,7446744073709551614);
        }
        [Test]
        public void AddLongSameNumbers()
        {
            Calculator calc=new Calculator();
            long result=calc.Add(4223372036854775807,4223372036854775807);
            Assert.AreEqual(result,8446744073709551614);
        }
        [Test]
        public void AddStringSameWords()
        {
            Calculator calc=new Calculator();
            string result=calc.Add("Hello ","Hello");
            Assert.AreEqual(result,"Hello Hello");
        }
        [Test]
        public void AddStringDifferentWords()
        {
            Calculator calc=new Calculator();
            string result=calc.Add("Hello ","World");
            Assert.AreEqual(result,"Hello World");
        }
        [Test]
        public void SubtractIntSameNumbers()
        {
            Calculator calc=new Calculator();
            int result=calc.Subtract(1,1);
            Assert.AreEqual(result,0);
        }
        [Test]
        public void SubtractIntDifferentNumbers()
        {
            Calculator calc=new Calculator();
            int result=calc.Subtract(1,2);
            Assert.AreEqual(result,-1);
        }
        [Test]
        public void SubtractFloatSameNumbers()
        {
            Calculator calc=new Calculator();
            float result=calc.Subtract(3.52f,3.52f);
            Assert.AreEqual(result,0);
        }
        [Test]
        public void SubtractFloatDifferentNumbers()
        {
            Calculator calc=new Calculator();
            float result=calc.Subtract(8.67f,7.05f);
            Assert.AreEqual(result,1.61999989f);
        }
        [Test]
        public void SubtractLongDifferentNumbers()
        {
            Calculator calc=new Calculator();
            long result=calc.Subtract(99999999,454545);
            Assert.AreEqual(result,99545454);
        }
        [Test]
        public void SubtractLongSameNumbers()
        {
            Calculator calc=new Calculator();
            long result=calc.Subtract(99999999,99999999);
            Assert.AreEqual(result,0);
        }
        [Test]
        public void MultiplyIntSameNumbers()
        {
            Calculator calc=new Calculator();
            int result=calc.Multiply(3,3);
            Assert.AreEqual(result,9);
        }
        [Test]
        public void MultiplyIntDifferentNumbers()
        {
            Calculator calc=new Calculator();
            int result=calc.Multiply(6,2);
            Assert.AreEqual(result,12);
        }
        [Test]
        public void MultiplyFloatSameNumbers()
        {
            Calculator calc=new Calculator();
            float result=calc.Multiply(1.22f,1.22f);
            Assert.AreEqual(result,1.4884001f);
        }
        [Test]
        public void MultiplyFloatDifferentNumbers()
        {
            Calculator calc=new Calculator();
            float result=calc.Multiply(1.05f,2.05f);
            Assert.AreEqual(result,2.1525f);
        }
        [Test]
        public void MultiplyLongDifferentNumbers()
        {
            Calculator calc=new Calculator();
            long result=calc.Multiply(4223372036854,3223372036854);
            Assert.AreEqual(result,5112613466446677092);
        }
        [Test]
        public void MultiplyLongSameNumbers()
        {
            Calculator calc=new Calculator();
            long result=calc.Multiply(4223372036854775807,4223372036854775807);
            Assert.AreEqual(result,948477850995392513);
        }
      }
}