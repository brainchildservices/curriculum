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
        public void CheckingFullNaming()
        {
            Sreerag nameclass = new Sreerag();
            nameclass.FirstName ="Sreerag";
            nameclass.MiddleName = "P";
            nameclass.LastName = "S";
            string expecting = "Sreerag P S";
            Assert.AreEqual(nameclass.FullName,expecting);
        }
        [Test]
        public void CheckingWithoutMiddleNaming()
        {
            Sreerag nameclass = new Sreerag();
            nameclass.FirstName = "Sreerag";
            nameclass.LastName = "Ps";
            string expecting = "Sreerag Ps";
            Assert.AreEqual(nameclass.FullName,expecting);
        }
        [Test]
        public void CheckingWithoutMiddleNaming2()
        {
            Sreerag nameclass = new Sreerag();
            nameclass.FirstName = "Elon";
            nameclass.LastName = "Musk";
            string expecting = "Elon Musk";
            Assert.AreEqual(nameclass.FullName,expecting);
        }
      }
}