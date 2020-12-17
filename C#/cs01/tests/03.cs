using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
using Moq;
namespace Brainchild.Curriculum

{
    [TestFixture]
    public class Test03
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void Test01()
        {
            BubbleSort bsort = new BubbleSort();
            int[] check = new int[] { 10, 8, 3, 6, 1 };
            int[] result = new int[5];
            int[] expected = new int[] { 1, 3, 6, 8, 10 };
            result = bsort.Sort(check);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Test02()
        {
            BubbleSort bsort = new BubbleSort();
            int[] check = new int[] { 10, 8, 3, 5, 10 };
            int[] result = new int[5];
            int[] expected = new int[] { 3, 5, 8, 10, 10 };
            result = bsort.Sort(check);
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void Tests03()
        {
            BubbleSort bsort = new BubbleSort();
            int[] check = new int[] { -10, 8, 3, -6, 1 };
            int[] result = new int[5];
            int[] expected = new int[] { -10, -6, 1, 3, 8 };
            result = bsort.Sort(check);
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void Test04()
        {
            var bubblesortMock = new Mock<IBubbleSort>();
            int[] expected = new int[] { 1, 3, 6, 8, 10 };
            int[] check = new int[] { 10, 8, 3, 6, 1 };
            bubblesortMock.Setup(b => b.Sort(check)).Returns(expected);

            int[] result = new int[5];

            result = bubblesortMock.Object.Sort(check);
            Assert.AreEqual(result, expected);
        }

    }
}