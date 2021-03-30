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
        public void PrintTest1()
        {
            FizzBuzzPrinter obj = new FizzBuzzPrinter();
            string variable = obj.Print(4);
            Assert.AreEqual("4", variable);
        }
        [Test]
        //write all test cases which covers FizzBuzzPrinter Print and PrintNumbers logics
        public void PrintTest2()
        {
            FizzBuzzPrinter obj = new FizzBuzzPrinter();
            string variable = obj.Print(3);
            Assert.AreEqual("Fizz", variable);
        }
        [Test]
        //write all test cases which covers FizzBuzzPrinter Print and PrintNumbers logics
        public void PrintTest3()
        {
            FizzBuzzPrinter obj = new FizzBuzzPrinter();
            string variable = obj.Print(5);
            Assert.AreEqual("Buzz", variable);
        }
         [Test]
        //write all test cases which covers FizzBuzzPrinter Print and PrintNumbers logics
        public void PrintNumbersTest1()
        {
            FizzBuzzPrinter obj = new FizzBuzzPrinter();
            string[] variable = obj.PrintNumbers(3);
            string[] result = {"0","1","2","Fizz"};
            Assert.AreEqual(result,variable);
        }
        [Test]
        //write all test cases which covers FizzBuzzPrinter Print and PrintNumbers logics
        public void PrintNumbersTest2()
        {
            FizzBuzzPrinter obj = new FizzBuzzPrinter();
            string[] variable = obj.PrintNumbers(5);
            string[] result = {"0","1","2","Fizz","4","Buzz"};
            Assert.AreEqual(result,variable);
        }
          [Test]
        //write all test cases which covers FizzBuzzPrinter Print and PrintNumbers logics
        public void PrintNumbersTest3()
        {
            FizzBuzzPrinter obj = new FizzBuzzPrinter();
            string[] variable = obj.PrintNumbers(10);
            string[] result = {"0","1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz"};
            Assert.AreEqual(result,variable);
        }
    }
}