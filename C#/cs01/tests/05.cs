using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test05
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void ReverseCase1()
        {
            StringReversal firstStringReverse=new StringReversal();
            string result = firstStringReverse.stringReverse("Happy Birthday");
            string actual="hAPPY bIRTHDAY";
            Assert.AreEqual(result,actual);
        }
        [Test]
        public void ReverseCase2()
        {
            StringReversal secondStringReverse=new StringReversal();
            string result = secondStringReverse.stringReverse("sPoNtAnEoUs");
            string actual="SpOnTaNeOuS";
            Assert.AreEqual(result,actual);
        }
        [Test]
        public void ReverseCase3()
        {
            StringReversal thirdStringReverse=new StringReversal();
            string result = thirdStringReverse.stringReverse("MANY THANKS");
            string actual="many thanks";
            Assert.AreEqual(result,actual);
        }
      }
}