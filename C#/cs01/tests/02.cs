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
            long output= calculator.Subtract(867868568434532441,635635236667777);
            Assert.AreEqual(output,867232933197864664);
        }
          [Test]
        public void TestingMultiplicationOfIntType()
        {
            Calculator calculator=new Calculator();
            int output= calculator.Multiply(12,5);
            Assert.AreEqual(output,60);
        }
       
         [Test]
        public void TestingMultiplicationOfFloatType()
        {
            Calculator calculator=new Calculator();
            float output= calculator.Multiply(82.78f,3.95f);
            Assert.AreEqual(output,326.981f);
        }
        [Test]
        public void TestingMultiplicationOfLongType()
        {
            Calculator calculator=new Calculator();
            long output= calculator.Multiply(65498498,8744449444);
            Assert.AreEqual(output,572748304418935112);

        }
       
      }
}