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
        public void SplitStringTest1()
        {
            StringSplitter StringTest1=new StringSplitter();
            string[] result=StringTest1.SplitString("He is a very very good boy, isn't he?");
            string[] actual=new string[]{"10", "He", "is", "a", "very", "very", "good", "boy","isn", "t", "he"};
            Assert.AreEqual(result,actual);
        }
        [Test]
        public void SplitStringTest2()
        {
            StringSplitter StringTest1=new StringSplitter();
            string[] result=StringTest1.SplitString("He? is a; not baby, will. test?");
            string[] actual=new string[]{"7", "He", "is", "a", "not", "baby", "will", "test"};
            Assert.AreEqual(result,actual);
        }
        [Test]
        public void SplitStringTest3()
        {
            StringSplitter StringTest1=new StringSplitter();
            string[] result=StringTest1.SplitString("H?e is a 'very' ve<ry g;oo@@d boy, isn't he?");
            string[] actual=new string[]{"14", "H", "e", "is", "a", "very", "ve", "ry", "g", "oo", "d", "boy","isn", "t", "he"};
            Assert.AreEqual(result,actual);
        }
      }
}