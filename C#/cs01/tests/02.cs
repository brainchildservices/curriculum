using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test02
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void AddIntTest1()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Add(5,2);
            Assert.AreEqual(7, calcInt);
        }
        [Test]
        public void AddIntTest2()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Add(-5,-2);
            Assert.AreEqual(-7, calcInt);
        }
        [Test]
        public void AddIntTest3()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Add(-5,2);
            Assert.AreEqual(-3, calcInt);
        }
        [Test]
        public void AddIntTest4()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Add(0,2);
            Assert.AreEqual(2, calcInt);
        }
        [Test]
        public void AddIntTest5()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Add(0,-2);
            Assert.AreEqual(-2, calcInt);
        }
        [Test]
        public void AddFloatTest1()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Add(5.2F,2.3F);
            Assert.AreEqual(7.5, calcFloat);
        }
        [Test]
        public void AddLongTest1()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Add(10000000,20000000);
            Assert.AreEqual(30000000, calcLong);
        }
        [Test]
        public void AddStringTest1()
        {
            Calculator sumString = new Calculator();
            string calcString = sumString.Add("7","2");
            Assert.AreEqual("72", calcString);
        }
        [Test]
        public void AddFloatTest2()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Add(7.2F,-5.1F);
            Assert.AreEqual(2.1F, calcFloat);
        }
        [Test]
        public void AddFloatTest3()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Add(7.2F,0);
            Assert.AreEqual(7.2F, calcFloat);
        }
        [Test]
        public void AddFloatTest4()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Add(-7.2F,0);
            Assert.AreEqual(-7.2F, calcFloat);
        }
        [Test]
        public void AddFloatTest5()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Add(-7.2F,-5.1F);
            Assert.AreEqual(-12.2999992F, calcFloat);
        }
        [Test]
        public void AddLongTest2()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Add(-10000000,-20000000);
            Assert.AreEqual(-30000000, calcLong);
        }
        [Test]
        public void AddLongTest3()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Add(10000000,-20000000);
            Assert.AreEqual(-10000000, calcLong);
        }
        [Test]
        public void AddLongTest4()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Add(-10000000,0);
            Assert.AreEqual(-10000000, calcLong);
        }
        [Test]
        public void AddLongTest5()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Add(10000000,0);
            Assert.AreEqual(10000000, calcLong);
        }
        [Test]
        public void AddStringTest2()
        {
            Calculator sumString = new Calculator();
            string calcString = sumString.Add("Sijo","George");
            Assert.AreEqual("SijoGeorge", calcString);
        }
        [Test]
        public void SubstractIntTest1()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Substract(5,2);
            Assert.AreEqual(3, calcInt);
        }
        [Test]
        public void SubstractIntTest2()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Substract(-5,-2);
            Assert.AreEqual(-3, calcInt);
        }
        [Test]
        public void SubstractIntTest3()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Substract(-5,2);
            Assert.AreEqual(-7, calcInt);
        }
        [Test]
        public void SubstractIntTest4()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Substract(-5,0);
            Assert.AreEqual(-5, calcInt);
        }
        [Test]
        public void SubstractIntTest5()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Substract(5,0);
            Assert.AreEqual(5, calcInt);
        }
        [Test]
        public void SubstractFloatTest1()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Substract(5.2F,2.3F);
            Assert.AreEqual(2.89999986F, calcFloat);
        }
        [Test]
        public void SubstractFloatTest2()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Substract(-5.2F,-2.3F);
            Assert.AreEqual(-2.89999986F, calcFloat);
        }
        [Test]
        public void SubstractFloatTest3()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Substract(5.2F,-2.3F);
            Assert.AreEqual(7.5F, calcFloat);
        }
        [Test]
        public void SubstractFloatTest4()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Substract(5.2F,0);
            Assert.AreEqual(5.19999981F, calcFloat);
        }
        [Test]
        public void SubstractFloatTest5()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Substract(-5.2F,0);
            Assert.AreEqual(-5.19999981F, calcFloat);
        }
        [Test]
        public void SubstractLongTest1()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Substract(20000000,10000000);
            Assert.AreEqual(10000000, calcLong);
        }
        [Test]
        public void SubstractLongTest2()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Substract(-20000000,-10000000);
            Assert.AreEqual(-10000000, calcLong);
        }
        [Test]
        public void SubstractLongTest3()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Substract(-20000000,10000000);
            Assert.AreEqual(-30000000, calcLong);
        }
        [Test]
        public void SubstractLongTest4()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Substract(20000000,0);
            Assert.AreEqual(20000000, calcLong);
        }
        [Test]
        public void SubstractLongTest5()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Substract(-20000000,0);
            Assert.AreEqual(-20000000, calcLong);
        }
        [Test]
        public void MultiplyIntTest1()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Multiply(5,2);
            Assert.AreEqual(10, calcInt);
        }
        [Test]
        public void MultiplyIntTest2()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Multiply(-5,-2);
            Assert.AreEqual(10, calcInt);
        }
        [Test]
        public void MultiplyIntTest3()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Multiply(-5,2);
            Assert.AreEqual(-10, calcInt);
        }
        [Test]
        public void MultiplyIntTest4()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Multiply(5,0);
            Assert.AreEqual(0, calcInt);
        }
        [Test]
        public void MultiplyIntTest5()
        {
            Calculator sumInt = new Calculator();
            int calcInt = sumInt.Multiply(-5,0);
            Assert.AreEqual(0, calcInt);
        }
        [Test]
        public void MultiplyFloatTest1()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Multiply(5.2F,2.3F);
            Assert.AreEqual(11.9599991F, calcFloat);
        }
        [Test]
        public void MultiplyFloatTest2()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Multiply(-5.2F,-2.3F);
            Assert.AreEqual(11.9599991F, calcFloat);
        }
        [Test]
        public void MultiplyFloatTest3()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Multiply(5.2F,-2.3F);
            Assert.AreEqual(-11.9599991F, calcFloat);
        }
        [Test]
        public void MultiplyFloatTest4()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Multiply(5.2F,0);
            Assert.AreEqual(0, calcFloat);
        }
        [Test]
        public void MultiplyFloatTest5()
        {
            Calculator sumFloat = new Calculator();
            float calcFloat = sumFloat.Multiply(-5.2F,0);
            Assert.AreEqual(0, calcFloat);
        }
        [Test]
        public void MultiplyLongTest1()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Multiply(20000000,10000000);
            Assert.AreEqual(552894464, calcLong);
        }
        [Test]
        public void MultiplyLongTest2()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Multiply(-20000000,10000000);
            Assert.AreEqual(-552894464, calcLong);
        }
        [Test]
        public void MultiplyLongTest3()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Multiply(-20000000,-10000000);
            Assert.AreEqual(552894464, calcLong);
        }
        [Test]
        public void MultiplyLongTest4()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Multiply(-20000000,0);
            Assert.AreEqual(0, calcLong);
        }
        [Test]
        public void MultiplyLongTest5()
        {
            Calculator sumLong = new Calculator();
            long calcLong = sumLong.Multiply(20000000,0);
            Assert.AreEqual(0, calcLong);
        }
    }
}
