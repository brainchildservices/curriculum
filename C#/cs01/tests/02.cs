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
            int result=calc.Add(1,1);
            Assert.AreEqual(result,2);
        }
        [Test]
        public void AddIntDifferentNumbers()
        {
            Calculator calc=new Calculator();
            int result=calc.Add(1,2);
            Assert.AreEqual(result,3);
        }
        [Test]
        public void AddFloatSameNumbers()
        {
            Calculator calc=new Calculator();
            float result=calc.Add(1.22f,1.22f);
            Assert.AreEqual(result,2.44f);
        }
        [Test]
        public void AddFloatDifferentNumbers()
        {
            Calculator calc=new Calculator();
            float result=calc.Add(1.05f,1.05f);
            Assert.AreEqual(result,2.10f);
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
            string result=calc.Add("Hello ","Hello!");
            Assert.AreEqual(result,"Hello Hello!");
        }
        [Test]
        public void AddStringDifferentWords()
        {
            Calculator calc=new Calculator();
            string result=calc.Add("Can we ","do it?");
            Assert.AreEqual(result,"Can we do it?");
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
            float result=calc.Subtract(1.22f,1.22f);
            Assert.AreEqual(result,0);
        }
        [Test]
        public void SubtractFloatDifferentNumbers()
        {
            Calculator calc=new Calculator();
            float result=calc.Subtract(2.05f,1.05f);
            Assert.AreEqual(result,1);
        }
        [Test]
        public void SubtractLongDifferentNumbers()
        {
            Calculator calc=new Calculator();
            long result=calc.Subtract(4223372036854775807,3223372036854775807);
            Assert.AreEqual(result,1000000000000000000);
        }
        [Test]
        public void SubtractLongSameNumbers()
        {
            Calculator calc=new Calculator();
            long result=calc.Subtract(4223372036854775807,4223372036854775807);
            Assert.AreEqual(result,0);
        }
        [Test]
        public void MultiplyIntSameNumbers()
        {
            Calculator calc=new Calculator();
            int result=calc.Multiply(2,2);
            Assert.AreEqual(result,4);
        }
        [Test]
        public void MultiplyIntDifferentNumbers()
        {
            Calculator calc=new Calculator();
            int result=calc.Multiply(1,2);
            Assert.AreEqual(result,2);
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
            long result=calc.Multiply(3147483647,1147483641);
            Assert.AreEqual(result,3611685995247518727);
        }
        [Test]
        public void MultiplyLongSameNumbers()
        {
            Calculator calc=new Calculator();
            long result=calc.Multiply(3007483641,3007483641);
            Assert.AreEqual(result,9044957850882616881);
        }
      }
}
