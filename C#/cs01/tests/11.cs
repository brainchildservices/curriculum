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
            Sreerag sreerag2 = new Sreerag("Sreerag", "P", "S");
            Sreerag sreerag = new Sreerag();
            sreerag.FirstName = "Sreerag";
            sreerag.MiddleName = "P";
            sreerag.LastName = "S";
            string expecting = "Sreerag P S";
            Assert.AreEqual(sreerag.FullName, expecting);
        }
        [Test]
        public void CheckingWithoutMiddleNaming()
        {
            Sreerag sreerag2 = new Sreerag("Sreerag", null, "Ps");
            Sreerag sreerag = new Sreerag();
            sreerag.FirstName = "Sreerag";
            sreerag.LastName = "Ps";
            string expecting = "Sreerag Ps";
            Assert.AreEqual(sreerag.FullName, expecting);
        }
        [Test]
        public void CheckingWithoutMiddleNaming2()
        {
            Sreerag sreerag2 = new Sreerag("Elon", null, "Musk");
            Sreerag sreerag = new Sreerag();
            sreerag.FirstName = "Elon";
            sreerag.LastName = "Musk";
            string expecting = "Elon Musk";
            Assert.AreEqual(sreerag.FullName, expecting);
        }
    }
}