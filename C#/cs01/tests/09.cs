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
         public void CheckingSplitting()
        {
            SplittingString splittingstring=new SplittingString();
            string[] real=splittingstring.Splitter("He is a very very good boy, isn't he?");
            string[] expecting=new string[]{ "He", "is", "a", "very", "very", "good", "boy","isn", "t", "he"};
            Assert.AreEqual(real,expecting);
        }
      }
}