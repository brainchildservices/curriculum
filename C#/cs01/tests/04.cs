using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
 public class Test04
  {
        [SetUp]
        public void SetUp()
        {
        }
         
             [Test]
         public void IsBuzzIsPrintingForMultiplesOfFive()
        {
            FizzBuzz1 fizzbuzz=new FizzBuzz1();
            string real=fizzbuzz.Print(25);
            Assert.AreEqual(real,"Buzz");
        }
            [Test]
         public void IsFizzIsPrintingForMultiplesOfThree()
        {
            FizzBuzz1 fizzbuzz=new FizzBuzz1();
            string real=fizzbuzz.Print(12);
            Assert.AreEqual(real,"Fizz");
        }
           [Test]
         public void TestingFizzBuzzPrintingForCommonMultiplesOfthreeandfive()
        {
            FizzBuzz1 fizzbuzz=new FizzBuzz1();
            string real=fizzbuzz.Print(15);
            Assert.AreEqual(real,"FizzBuzz");
        }

           [Test]
         public void PrintingOutputUpTo15()
        {
            FizzBuzz2 fizzbuzz=new FizzBuzz2();
            string[] real=fizzbuzz.PrintOutput(15);
            string[] expecting=new string[15]{"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"};
            Assert.AreEqual(real,expecting);
        }
         [Test]
         public void PrintingUpTo30()
        {
            FizzBuzz2 fizzbuzz=new FizzBuzz2();
            string[] actual=fizzbuzz.PrintOutput(30);
            string[] expected=new string[30]{"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz","16","17","Fizz","19","Buzz","Fizz","22","23","Fizz","Buzz","26","Fizz","28","29","FizzBuzz"};
            Assert.AreEqual(actual,expected);
        }
        
        
  }
}