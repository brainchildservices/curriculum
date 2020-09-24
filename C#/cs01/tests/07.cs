using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test07
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void factorialTest01()
        {
            Factorial factorial1=new Factorial();
            long result=factorial1.Fact(1);
            Assert.AreEqual(result,1);
        }
        [Test]
        public void factorialTest02()
        {
            Factorial factorial2=new Factorial();
            long result=factorial2.Fact(3);
            Assert.AreEqual(result,6);
        }
        [Test]
        public void factorialTest03()
        {
            Factorial factorial3=new Factorial();
            long result=factorial3.Fact(6);
            Assert.AreEqual(result,720);
        }
    }
}