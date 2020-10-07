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
        public void CheckingNormalHourBilling()
        {
            NormalStrategy normalstrategy = new NormalStrategy();
            CustomerBill firstCustomer = new CustomerBill(normalstrategy);
            double BillAmount = firstCustomer.Add(80, 5);
            Assert.AreEqual(BillAmount, 400);
        }
        [Test]
        public void CheckingHappyHourBilling()
        {
            HappyHourStrategy happyhourstrategy = new HappyHourStrategy();
            CustomerBill firstCustomer = new CustomerBill(happyhourstrategy);
            double BillAmount = firstCustomer.Add(80, 5);
            Assert.AreEqual(BillAmount, 320);
        }
    }
}
