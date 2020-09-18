using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test01
    {
        [SetUp]
        public void SetUp()
        {
        }
       
        [Test]
        public void TestingIsFizzReplacingForMultiplesOf3()
        {
            FizzBuzz fizzbuzz=new FizzBuzz();
            string actual=fizzbuzz.Print(9);
            Assert.AreEqual(actual,"Fizz");
        }
        [Test]
        public void TestingIsBuzzReplacingForMultiplesOf5()
        {
            FizzBuzz fizzbuzz=new FizzBuzz();
            string actual=fizzbuzz.Print(10);
            Assert.AreEqual(actual,"Buzz");
        }
         [Test]
        public void TestingOtherInteger()
        {
            FizzBuzz fizzbuzz=new FizzBuzz();
            string actual=fizzbuzz.Print(4);
            Assert.AreEqual(actual,"4");
        }
       
        [Test]
        public void OutputCheckingUpto15()
        {
            FizzBuzz fizzbuzz=new FizzBuzz();
            string[] actual=fizzbuzz.Print2(15);
            string[] expected=new string[15]{"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","Fizz"};
            Assert.AreEqual(actual,expected);
        }
      }
}