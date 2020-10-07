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
        public void CheckingIntegerListAddmethod()
        {
            IntList list = new IntList();
            list.Add(100);
            int[] real = list.internalArr;
            int[] expected = { 100 };
            Assert.AreEqual(real, expected);

        }
        [Test]
        public void CheckingIntegerListCountmethod()
        {
            IntList list = new IntList();
            list.Add(100);
            list.Add(10);
            list.Add(88);
            Assert.AreEqual(list.Count, 3);
        }

        [Test]
        public void CheckingIntegerListGetmethod()
        {
            IntList list = new IntList();
            list.Add(100);
            list.Add(10);
            list.Add(88);
            Assert.AreEqual(list.Get(2), 88);
        }

        [Test]
        public void CheckingIntegerListAllmethods()
        {
            IntList list = new IntList();
            list.Add(1);
            list.Add(7);
            list.Add(170);
            list.Add(100);
            list.Add(10);
            list.Add(88);
            Assert.AreEqual(list.Count, 6);
            Assert.AreEqual(list.Get(4), 10);
            int[] real = list.internalArr;
            int[] expected = { 1, 7, 170, 100, 10, 88 };
            Assert.AreEqual(real, expected);
        }

    }
}
