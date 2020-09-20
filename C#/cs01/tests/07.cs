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
         public void factorialcheckingone()
        {
            FactorialOfaPositiveNumber factorialofanumber=new FactorialOfaPositiveNumber();
            double output=factorialofanumber.Fact(1);
            Assert.AreEqual(output,1);
        }
         [Test]
         public void factorialcheckingothernumbers()
        {
            FactorialOfaPositiveNumber factorialofanumber=new FactorialOfaPositiveNumber();
            double output=factorialofanumber.Fact(5);
            Assert.AreEqual(output,120);
        }
      }
}