using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class TestToPascal
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void ToPascalTest1()
        {
            string myString="a";
            Assert.AreEqual(myString.ToPascal(),"A");
        }
        [Test]
        public void ToPascalTest2()
        {
            string myString="aNeE";
            Assert.AreEqual(myString.ToPascal(),"Anee");
        }
        [Test]
        public void ToPascalTest3()
        {
            string myString="ANeeSh";
            Assert.AreEqual(myString.ToPascal(),"Aneesh");
        }
    }
}
