using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test14
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void NormalHourBill()
        {
            NormalStrategy norStrat = new NormalStrategy();
            CustomerBill firstCust = new CustomerBill(norStrat);
            double result = firstCust.Amount(10, 10);
            Assert.AreEqual(result, 100);
        }
        [Test]
        public void NormalHourBill2()
        {
            NormalStrategy norStrat = new NormalStrategy();
            CustomerBill firstCust = new CustomerBill(norStrat);
            double result = firstCust.Amount(10.20, 20);
            Assert.AreEqual(result, 204);
        }
        [Test]
        public void HappyHourBill()
        {
            HappyHourStrategy happStrat = new HappyHourStrategy();
            CustomerBill firstCust = new CustomerBill(happStrat);
            double result = firstCust.Amount(10, 10);
            Assert.AreEqual(result, 80);
        }
        [Test]
        public void HappyHourBill2()
        {
            HappyHourStrategy happStrat = new HappyHourStrategy();
            CustomerBill firstCust = new CustomerBill(happStrat);
            double result = firstCust.Amount(10.20, 20);
            Assert.AreEqual(result, 163.20);
        }
    }
}
