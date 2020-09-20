using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
using System.Text;
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
        public void testingcharactercasereversal()
        {
            StringCharacterCaseReversal stringcasereverse = new StringCharacterCaseReversal;
             StringBuilder str = new StringBuilder("Ge");
            stringcasereverse.convertToOppositeCase(str);
            Assert.AreEqual(str,"gE");
        }
      }
}