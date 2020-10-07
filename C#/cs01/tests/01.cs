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
        public void Test()
        {
            FizzBuzzPrinter givNumber = new FizzBuzzPrinter();
            string result = givNumber.Print(1);
            Assert.AreEqual(result, "1");
        }
        [Test]
        public void TestFizz()
        {
            FizzBuzzPrinter givFizz = new FizzBuzzPrinter();
            string result = givFizz.Print(3);
            Assert.AreEqual(result, "Fizz");
        }
        [Test]
        public void TestBuzz()
        {
            FizzBuzzPrinter givBuzz = new FizzBuzzPrinter();
            string result = givBuzz.Print(5);
            Assert.AreEqual(result, "Buzz");
        }
        [Test]
        public void TestArrayBuzz()
        {
            FizzBuzzPrinter givBuzzLine = new FizzBuzzPrinter();
            string[] result = givBuzzLine.PrintNumbers(5);
            string[] expected = { "1", "2", "Fizz", "4", "Buzz" };
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void TestArrayFizz()
        {
            FizzBuzzPrinter givBuzzLine = new FizzBuzzPrinter();
            string[] result = givBuzzLine.PrintNumbers(10);
            string[] expected = { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" };
            Assert.AreEqual(result, expected);
        }
    }
}