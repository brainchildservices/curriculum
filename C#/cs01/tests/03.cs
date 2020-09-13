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
        public void BubbleSortArrayLength5()
        {
            BubbleSort bbSort= new BubbleSort();
            int[] myArray=new int[]{1,25,85,9,2};
            int[] bbSorted=bbSort.Sort(myArray);
            int[] result=new int[]{1,2,9,25,85};
            Assert.AreEqual(result,bbSorted);
        }
        [Test]
        public void BubbleSortArrayLength10()
        {
            BubbleSort bbSort= new BubbleSort();
            int[] myArray=new int[]{11,88,100,25,7,85,9,2,89,1};
            int[] bbSorted=bbSort.Sort(myArray);
            int[] result=new int[]{1,2,7,9,11,25,85,88,89,100};
            Assert.AreEqual(result,bbSorted);
        }
      }
}