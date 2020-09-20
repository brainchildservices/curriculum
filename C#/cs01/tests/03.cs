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
        public void BubbleSortArrayLength4()
        {
            BubbleSorting bubblesort= new BubbleSorting();
            int[] arraytobesorted=new int[]{7,3,88,2};
            int[] sortedArray=bubblesort.Sort(arraytobesorted);
            int[] expectedArray=new int[]{2,3,7,88};
            Assert.AreEqual(expectedArray,sortedArray);
        }
        [Test]
        public void BubbleSortArrayLength7()
        {
           BubbleSorting bubblesort= new BubbleSorting();
            int[] arraytobesorted=new int[]{6,3,5,1,2,4,7};
            int[] sortedArray=bubblesort.Sort(arraytobesorted);
            int[] expectedArray=new int[]{1,2,3,4,5,6,7};
            Assert.AreEqual(expectedArray,sortedArray);
        }
      }
}