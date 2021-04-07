using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
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
        public void BubbleSortTest01()
        {
            BubbleSort sortIntArray = new BubbleSort();
            int[] unSortedArr = new int[]{3,2,9,6};
            int[] sortArr = new int[]{2,3,6,9};
            int[] resultArr = sortIntArray.Sort(unSortedArr);
            Assert.AreEqual(sortArr,resultArr);
        }
        [Test]
        public void BubbleSortTest02()
        {
            BubbleSort sortIntArray = new BubbleSort();
            int[] unSortedArr = new int[]{2,3,9,6};
            int[] sortArr = new int[]{2,3,6,9};
            int[] resultArr = sortIntArray.Sort(unSortedArr);
            Assert.AreEqual(sortArr,resultArr);
        }
        [Test]
        public void BubbleSortTest03()
        {
            BubbleSort sortIntArray = new BubbleSort();
            int[] unSortedArr = new int[]{3,2,6,9};
            int[] sortArr = new int[]{2,3,6,9};
            int[] resultArr = sortIntArray.Sort(unSortedArr);
            Assert.AreEqual(sortArr,resultArr);
        }
        [Test]
        public void BubbleSortTest04()
        {
            BubbleSort sortIntArray = new BubbleSort();
            int[] unSortedArr = new int[]{2,3,9,6};
            int[] sortArr = new int[]{2,3,6,9};
            int[] resultArr = sortIntArray.Sort(unSortedArr);
            Assert.AreEqual(sortArr,resultArr);
        }
        [Test]
        public void BubbleSortTest05()
        {
            BubbleSort sortIntArray = new BubbleSort();
            int[] unSortedArr = new int[]{9,3,2,6};
            int[] sortArr = new int[]{2,3,6,9};
            int[] resultArr = sortIntArray.Sort(unSortedArr);
            Assert.AreEqual(sortArr,resultArr);
        }
        [Test]
        public void BubbleSortTest06()
        {
            BubbleSort sortIntArray = new BubbleSort();
            int[] unSortedArr = new int[]{3,2,9};
            int[] sortArr = new int[]{2,3,9};
            int[] resultArr = sortIntArray.Sort(unSortedArr);
            Assert.AreEqual(sortArr,resultArr);
        }
        [Test]
        public void BubbleSortTest07()
        {
            BubbleSort sortIntArray = new BubbleSort();
            int[] unSortedArr = new int[]{3,2,9,6,5,1};
            int[] sortArr = new int[]{1,2,3,5,6,9};
            int[] resultArr = sortIntArray.Sort(unSortedArr);
            Assert.AreEqual(sortArr,resultArr);
        }
        [Test]
        public void BubbleSortTest08()
        {
            BubbleSort sortIntArray = new BubbleSort();
            int[] unSortedArr = new int[]{1,3,2,5,9,6};
            int[] sortArr = new int[]{1,2,3,5,6,9};
            int[] resultArr = sortIntArray.Sort(unSortedArr);
            Assert.AreEqual(sortArr,resultArr);
        }
        [Test]
        public void BubbleSortTest09()
        {
            BubbleSort sortIntArray = new BubbleSort();
            int[] unSortedArr = new int[]{3,2,9,6,3,4};
            int[] sortArr = new int[]{2,3,3,4,6,9};
            int[] resultArr = sortIntArray.Sort(unSortedArr);
            Assert.AreEqual(sortArr,resultArr);
        }
        [Test]
        public void BubbleSortTest10()
        {
            BubbleSort sortIntArray = new BubbleSort();
            int[] unSortedArr = new int[]{3,1,2,9,6};
            int[] sortArr = new int[]{1,2,3,6,9};
            int[] resultArr = sortIntArray.Sort(unSortedArr);
            Assert.AreEqual(sortArr,resultArr);
        }
    }
}
