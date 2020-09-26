using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
using System;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test12
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void CheckingTypeCating1()
        {
            TypeCast typecast = new TypeCast();
            double expecting = 'a';
            Assert.AreEqual(typecast.RecastToDouble('a'), expecting);
        }
         [Test]
        public void CheckingTypeCating2()
        {
            TypeCast typecast = new TypeCast();
            char expecting = '\u0001';
            Assert.AreEqual(typecast.RecastToCharacter(1), expecting);
        }
        [Test]
        public void CheckingTypeCating3()
        {
            TypeCast typecast = new TypeCast();
            char expecting = '\uffff';
            Assert.AreEqual(typecast.RecastToCharacter(9223372036854775807), expecting);
        }
         [Test]
        public void CheckingTypeCating4()
        {
            TypeCast typecast = new TypeCast();
            char expecting = '\u001e';
            Assert.AreEqual(typecast.RecastToCharacter(30.000000000000003552713678800500929355621337890625), expecting);
        }
       
    }
}