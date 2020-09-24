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
        public void CheckingPedalling()
        {
            Bicycle bicycle=new Bicycle();
            bicycle.Pedal();
            Assert.AreEqual(bicycle.Pedal(),2);
        }
       
        [Test]
         public void CheckingBackPedalling()
        {
            Bicycle bicycle=new Bicycle();
            bicycle.BackPedal();
            bicycle.BackPedal();
            bicycle.BackPedal();
            bicycle.BackPedal();
            Assert.AreEqual(bicycle.BackPedal(),-5);
        }
       
        [Test]
        public void TestingPedallingAndBackPedalling()
        {
            Bicycle bicycle=new Bicycle();
            bicycle.Pedal();
            bicycle.Pedal();
            bicycle.BackPedal();
            bicycle.Pedal();
            bicycle.BackPedal();
            Assert.AreEqual(bicycle.BackPedal(),0);
        }
        [Test]
        public void CheckingDoubleSpeededPedalling()
        {
             DoubleSpeededBicycle newbicycle=new DoubleSpeededBicycle();
             newbicycle.Pedal();
             newbicycle.Pedal();
             newbicycle.Pedal();
            Assert.AreEqual( newbicycle.Pedal(),16);
        }
        [Test]
        public void CheckingDoubleSpeededBackPedalling()
        {
             DoubleSpeededBicycle newbicycle=new DoubleSpeededBicycle();
             newbicycle.BackPedal();
             Assert.AreEqual( newbicycle.BackPedal(),-4);
        }
         [Test]
        public void CheckingDoubleSpeedPedallingandBackpedalling()
        {
             DoubleSpeededBicycle newbicycle=new DoubleSpeededBicycle();
             newbicycle.Pedal();
             newbicycle.BackPedal();
             newbicycle.Pedal();
             newbicycle.Pedal();
             newbicycle.Pedal();
             newbicycle.BackPedal();
            Assert.AreEqual( newbicycle.Pedal(),12);
        }
       
    }
}