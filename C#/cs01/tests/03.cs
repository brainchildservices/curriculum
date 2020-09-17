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
            BubbleSort testSort= new BubbleSort();
            int[] myArray=new int[]{7,3,88,2};
            int[] testSorted=testSort.Sort(myArray);
            int[] result=new int[]{2,3,7,88};
            Assert.AreEqual(result,testSorted);
        }
        [Test]
        public void BubbleSortArrayLength7()
        {
            BubbleSort test= new BubbleSort();
            int[] myArray=new int[]{6,3,5,1,2,4,7};
            int[] tested=test.Sort(myArray);
            int[] result=new int[]{1,2,3,4,5,6,7};
            Assert.AreEqual(result,tested);
        }
      }
}