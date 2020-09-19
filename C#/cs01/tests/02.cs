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
        public void TestingAdditionOfIntType()
        {
            Calculator calculator=new Calculator();
            int output=calculator.Add(8,7);
            Assert.AreEqual(output,15);
        }
         [Test]
        public void TestingAdditionOfFloatType()
        {
            Calculator calculator=new Calculator();
            float output= calculator.Add(6.11f,8.23f);
            Assert.AreEqual(output,14.34f);
        }
        [Test]
        public void TestingAdditionOfLongType()
        {
            Calculator calculator=new Calculator();
            long output=calculator.Add(885445345459999999,666666666666555555);
            Assert.AreEqual(output,1552112012126555554);
        }
       [Test]
        public void TestingAdditionOfStringType()
        {
            Calculator calculator=new Calculator();
            string output= calculator.Add("Goo","gle");
            Assert.AreEqual(output,"Google");
        }
        [Test]
        public void TestingSubtractionOfIntType()
        {
            Calculator calculator=new Calculator();
            int output= calculator.Subtract(77,48);
            Assert.AreEqual(output,29);
        }
       [Test]
        public void TestingSubtractionOfFloatType()
        {
            Calculator calculator=new Calculator();
            float output= calculator.Subtract(9.75f,1.22f);
            Assert.AreEqual(output,8.52999973f);
        }
       [Test]
        public void TestingSubtractionOfLongType()
        {
            Calculator calculator=new Calculator();
            float output= calculator.Subtract(867868568434532441,635635236667777);
            Assert.AreEqual(output,867232933197864664);
        }
          [Test]
        public void TestingMultiplicationOfIntType()
        {
            Calculator calculator=new Calculator();
            float output= calculator.Multiply(9.75f,1.22f);
            Assert.AreEqual(output,8.52999973f);
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