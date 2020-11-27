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
        public void FizzBuzzTest()
        {
            FizzBuzzPrinter fizz = new FizzBuzzPrinter();
            string expected = fizz.Print(5);
            string result = "Buzz";
            Assert.AreEqual(expected, result);
        }
        [Test]
        //write all test cases which covers FizzBuzzPrinter Print and PrintNumbers logics
        public void FizzBuzzTest1()
        {
            FizzBuzzPrinter fizz = new FizzBuzzPrinter();
            string expected = fizz.Print(3);
            string result = "Fizz";
            Assert.AreEqual(expected, result);
        }
        [Test]
        //write all test cases which covers FizzBuzzPrinter Print and PrintNumbers logics
        public void FizzBuzzTest2()
        {
            FizzBuzzPrinter fizz = new FizzBuzzPrinter();
            string expected = fizz.Print(15);
            string result = "FizzBuzz";
            Assert.AreEqual(expected, result);
        }
        [Test]
        //write all test cases which covers FizzBuzzPrinter Print and PrintNumbers logics
        public void FizzBuzzTest3()
        {
            FizzBuzzPrinter fizz = new FizzBuzzPrinter();
            string[] expected = fizz.PrintNumbers(5);
            string[] result = { "1", "2", "Fizz", "4", "Buzz" };
            Assert.AreEqual(expected, result);
        }
        [Test]
        //write all test cases which covers FizzBuzzPrinter Print and PrintNumbers logics
        public void FizzBuzzTest4()
        {
            FizzBuzzPrinter fizz = new FizzBuzzPrinter();
            string[] expected = fizz.PrintNumbers(15);
            string[] result = { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            Assert.AreEqual(expected, result);
        }
    }
}
