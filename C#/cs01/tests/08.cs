using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test08
    {
        [SetUp]
        public void SetUp()
        {
        }
         [Test]
         public void TestingArray()
        {
            FizzBuzzPrinter2 Tester=new FizzBuzzPrinter2();
            string[] actual=Tester.PrintNumbers2(15);
            string[] expected=new string[15]{"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"};
            Assert.AreEqual(actual,expected);
        }
      }
}