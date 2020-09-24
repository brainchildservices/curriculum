using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test06
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void arrayOfMultiplesTest1()
        {
            ArrayOfMultiples firstArray=new ArrayOfMultiples();
            int[] result= firstArray.arrayMultiples(7,5);
            int[] actual={7, 14, 21, 28, 35};
            Assert.AreEqual(result,actual);
        }
        [Test]
        public void arrayOfMultiplesTest2()
        {
            ArrayOfMultiples secondArray=new ArrayOfMultiples();
            int[] result= secondArray.arrayMultiples(12, 10);
            int[] actual={12, 24, 36, 48, 60, 72, 84, 96, 108, 120};
            Assert.AreEqual(result,actual);
        }
        [Test]
        public void arrayOfMultiplesTest3()
        {
            ArrayOfMultiples thirdArray=new ArrayOfMultiples();
            int[] result= thirdArray.arrayMultiples(17, 6);
            int[] actual={17, 34, 51, 68, 85, 102};
            Assert.AreEqual(result,actual);
        }
    }
}