using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test09
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void TestPascalCase()
        {
            string myName="syaMiL";
            string result=myName.ToPascalCase();
            Assert.AreEqual(result,"Syamil");
        }
        [Test]
        public void TestPascalSecond()
        {
            string myName="paSCalCamel";
            string result=myName.ToPascalCase();
            Assert.AreEqual(result,"Pascalcamel");
        }
      }
}