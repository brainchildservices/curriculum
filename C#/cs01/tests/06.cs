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
        public void CheckingArrayOfMultiples()
        {
            MultiplesOfNumber multiplesofanumber=new MultiplesOfNumber();
            int[] array=  multiplesofanumber.makeMultiples(3,4);
            int[] expected={3 , 6 , 9 , 12};
            Assert.AreEqual(array,expected);
        }
        [Test]
        public void CheckingArrayOfMultiples2()
        {
            MultiplesOfNumber multiplesofanumber=new MultiplesOfNumber();
            int[] array=  multiplesofanumber.makeMultiples(7,6);
            int[] expected={7, 14 , 21 , 28 , 35 ,42};
            Assert.AreEqual(array,expected);
        }
    }
}