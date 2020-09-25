using NUnit.Framework;
using System;
using Brainchild.Curriculum.Solutions;
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
        public void TypeCastMethodReturningDouble()
        {
            TypeCasting mytype = new TypeCasting();
            Assert.AreEqual(mytype.ConvertToDouble(1), 1);
            Assert.AreEqual(mytype.ConvertToDouble(130), 130);
            Assert.AreEqual(mytype.ConvertToDouble(9223372036854775807), 9223372036854775807);
            Assert.AreEqual(mytype.ConvertToDouble(3.12345678f), 3.1234567165374756d);
        }
        [Test]
        public void TypeCastMethodReturningFloat()
        {
            TypeCasting mytype = new TypeCasting();
            Assert.AreEqual(mytype.ConvertToFloat(1), 1);
            Assert.AreEqual(mytype.ConvertToFloat(130), 130);
            Assert.AreEqual(mytype.ConvertToFloat(9223372036854775807), 9223372036854775807);
            Assert.AreEqual(mytype.ConvertToFloat(3.1234567165374756d), 3.12345672f);
        }
        [Test]
        public void TypeCastMethodReturningLong()
        {
            TypeCasting mytype = new TypeCasting();
            Assert.AreEqual(mytype.ConvertToLong(1), 1);
            Assert.AreEqual(mytype.ConvertToLong(130), 130);
            Assert.AreEqual(mytype.ConvertToLong(922337217429372928.12345672f), 922337217429372928);
            Assert.AreEqual(mytype.ConvertToLong(922337217429372928.8234567165374756d), 922337217429372928);
        }
        [Test]
        public void TypeCastMethodReturningInt()
        {
            TypeCasting mytype = new TypeCasting();
            Assert.AreEqual(mytype.ConvertToInt(1), 1);
            Assert.AreEqual(mytype.ConvertToInt(9223372), 9223372);
            Assert.AreEqual(mytype.ConvertToInt(922337216.12345672f), 922337216);
            Assert.AreEqual(mytype.ConvertToInt(922337216.8234567165374756d), 922337217);
        }
        [Test]
        public void TypeCastMethodReturningChar()
        {
            TypeCasting mytype = new TypeCasting();
            Assert.AreEqual(mytype.ConvertToChar(1), 1);
            Assert.AreEqual(mytype.ConvertToChar(127), 127);
        }
    }
}
