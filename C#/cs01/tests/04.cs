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
        public void Test01()
        {
            FizzBuzzV2 fizzbuzz = new FizzBuzzV2();
            string expected = fizzbuzz.Print(10);
            string result = "FizzBuzz";
            Assert.AreEqual(expected, result);
        }
    }
}
