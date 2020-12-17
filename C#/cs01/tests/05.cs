using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test05
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void Test01()
        {
            Conversion str = new Conversion();
            string result = str.convertopposite("Vishnu Unnikrishnan");
            string expected = "vISHNU uNNIKRISHNAN";
            Assert.AreEqual(expected, result);
        }
    }
}