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
        //write all test cases which covers FizzBuzzPrinter Print and PrintNumbers logics
        public void TestNumberOtherThan3or5Divisible()
        {
            FizzBuzzPrinter printer=new FizzBuzzPrinter();
            string result=printer.Print(2);
            Assert.AreEqual(result,"2");
        }
        [Test]
        public void TestNumberDivisibleBy3()
        {
            FizzBuzzPrinter printer=new FizzBuzzPrinter();
            string result=printer.Print(6);
            Assert.AreEqual(result,"Fizz");
        }
        [Test]
        public void TestNumberDivisibleBy5()
        {
            FizzBuzzPrinter printer=new FizzBuzzPrinter();
            string result=printer.Print(10);
            Assert.AreEqual(result,"Buzz");
        }
        [Test]
        public void TestNumberDivisibleBy3and5()
        {
            FizzBuzzPrinter printer=new FizzBuzzPrinter();
            string result=printer.Print(15);
            Assert.AreEqual(result,"Fizz Buzz");
        }
        [Test]
        public void TestPrintFizzBuzzTo3()
        {
            FizzBuzzPrinter printer=new FizzBuzzPrinter();
            string[] result=printer.PrintNumbers(3);
            string[] myString=new string[3]{"1","2","Fizz"};
            Assert.AreEqual(result,myString);
        }
        [Test]
        public void TestPrintFizzBuzzTo15()
        {
            FizzBuzzPrinter printer=new FizzBuzzPrinter();
            string[] result=printer.PrintNumbers(15);
            string[] myString=new string[15]{"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","Fizz Buzz"};
            Assert.AreEqual(result,myString);
        }
    }
}
