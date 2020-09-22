using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test10
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void Peddaling3Times()
        {
            Bicycle myBicycle=new Bicycle();
            myBicycle.Pedal();
            myBicycle.Pedal();
            int result=myBicycle.Pedal();
            Assert.AreEqual(result,3);
        }
        [Test]
        public void Peddaling4Times()
        {
            Bicycle myBicycle=new Bicycle();
            myBicycle.Pedal();
            myBicycle.Pedal();
            myBicycle.Pedal();
            int result=myBicycle.Pedal();
            Assert.AreEqual(result,4);
        }
        [Test]
        public void BackPeddaling4Times()
        {
            Bicycle myBicycle=new Bicycle();
            myBicycle.BackPedal();
            myBicycle.BackPedal();
            myBicycle.BackPedal();
            int result=myBicycle.BackPedal();
            Assert.AreEqual(result,-4);
        }
        [Test]
        public void BackPeddaling3Times()
        {
            Bicycle myBicycle=new Bicycle();
            myBicycle.BackPedal();
            myBicycle.BackPedal();
            int result=myBicycle.BackPedal();
            Assert.AreEqual(result,-3);
        }
        [Test]
        public void PedalAndBackPeddal()
        {
            Bicycle myBicycle=new Bicycle();
            myBicycle.BackPedal();
            myBicycle.BackPedal();
            myBicycle.Pedal();
            myBicycle.Pedal();
            myBicycle.Pedal();
            myBicycle.Pedal();
            int result=myBicycle.BackPedal();
            Assert.AreEqual(result,1);
        }
        [Test]
        public void SpeedPeddaling3Times()
        {
            SpeedBicycle myBicycle=new SpeedBicycle();
            myBicycle.DoubleSpeedPedal();
            myBicycle.DoubleSpeedPedal();
            int result=myBicycle.DoubleSpeedPedal();
            Assert.AreEqual(result,6);
        }
        [Test]
        public void SpeedPeddaling4Times()
        {
            SpeedBicycle myBicycle=new SpeedBicycle();
            myBicycle.DoubleSpeedPedal();
            myBicycle.DoubleSpeedPedal();
            myBicycle.DoubleSpeedPedal();
            int result=myBicycle.DoubleSpeedPedal();
            Assert.AreEqual(result,8);
        }
        [Test]
        public void SpeedBackPeddaling3Times()
        {
            SpeedBicycle myBicycle=new SpeedBicycle();
            myBicycle.DoubleSpeedBackPedal();
            myBicycle.DoubleSpeedBackPedal();
            int result=myBicycle.DoubleSpeedBackPedal();
            Assert.AreEqual(result,-6);
        }
        [Test]
        public void SpeedBackPeddaling4Times()
        {
            SpeedBicycle myBicycle=new SpeedBicycle();
            myBicycle.DoubleSpeedBackPedal();
            myBicycle.DoubleSpeedBackPedal();
            myBicycle.DoubleSpeedBackPedal();
            int result=myBicycle.DoubleSpeedBackPedal();
            Assert.AreEqual(result,-8);
        }
        [Test]
        public void SpeedPedalAndBackPeddal()
        {
            SpeedBicycle myBicycle=new SpeedBicycle();
            myBicycle.DoubleSpeedPedal();
            myBicycle.DoubleSpeedPedal();
            myBicycle.DoubleSpeedPedal();
            myBicycle.DoubleSpeedBackPedal();
            myBicycle.DoubleSpeedBackPedal();
            myBicycle.DoubleSpeedBackPedal();
            int result=myBicycle.DoubleSpeedPedal();
            Assert.AreEqual(result,2);
        }
    }
}