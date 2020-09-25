using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test11
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void NameTestingNoMiddleName()
        {
            Aneesh myName = new Aneesh();
            myName.FirstName = "Aneesh";
            myName.LastName = "S";
            string actual = "Aneesh S";
            Assert.AreEqual(myName.FullName, actual);
        }
        [Test]
        public void NameTestingWithMiddleName()
        {
            Aneesh myName = new Aneesh();
            myName.FirstName = "Aneesh";
            myName.MiddleName = "Karthika";
            myName.LastName = "S";
            string actual = "Aneesh Karthika S";
            Assert.AreEqual(myName.FullName, actual);
        }
        [Test]
        public void NameTestingUsingConstructor()
        {
            Aneesh myName = new Aneesh("Aneesh", "Karthika", "S");
            string actual = "Aneesh Karthika S";
            Assert.AreEqual(myName.FullName, actual);
        }
        [Test]
        public void NameTestingUsingConstructor1()
        {
            Aneesh myName = new Aneesh("Aneesh", null, "S");
            string actual = "Aneesh S";
            Assert.AreEqual(myName.FullName, actual);
        }
    }
}
