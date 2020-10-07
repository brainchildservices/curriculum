using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test15
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void IntListInsertNumbers()
        {
            IntList myList=new IntList();
            int myCount=myList.Count;
            Assert.AreEqual(myCount,0);
        }
        [Test]
        public void IntListInsertOneNumber()
        {
            IntList myList=new IntList();
            myList.Add(12);
            int myCount=myList.Count;
            Assert.AreEqual(myCount,1);
            int[] result=myList.array;
            int[] expected={12};
            Assert.AreEqual(result,expected);
        }
        [Test]
        public void IntListInsertThreeNumbers()
        {
            IntList myList=new IntList();
            myList.Add(12);
            myList.Add(24);
            int myCount=myList.Count;
            Assert.AreEqual(myCount,2);
            int[] result=myList.array;
            int[] expected={12,24};
            Assert.AreEqual(result,expected);
            int number=myList.Get(1);
            Assert.AreEqual(number,24);
        }
        [Test]
        public void IntListInsert6Numbers()
        {
            IntList myList=new IntList();
            myList.Add(12);
            myList.Add(24);
            myList.Add(36);
            myList.Add(48);
            myList.Add(60);
            myList.Add(72);
            int myCount=myList.Count;
            Assert.AreEqual(myCount,6);
            int[] result=myList.array;
            int[] expected={12,24,36,48,60,72};
            Assert.AreEqual(result,expected);
            int number=myList.Get(4);
            Assert.AreEqual(number,60);
        }
    }
}