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
        public void AddintTest1()
        {
            Calculator obj = new Calculator();
            int variable = obj.Add(5,2);
            Assert.AreEqual(7, variable);
        }
        [Test]
        public void AddintTest2()
        {
            Calculator obj = new Calculator();
            int variable = obj.Add(-5,-2);
            Assert.AreEqual(-7, variable);
        }
        [Test]
        public void AddintTest3()
        {
            Calculator obj = new Calculator();
            int variable = obj.Add(-5,2);
            Assert.AreEqual(-3, variable);
        }
        [Test]
        public void AddintTest4()
        {
            Calculator obj = new Calculator();
            int variable = obj.Add(0,2);
            Assert.AreEqual(2, variable);
        }
        [Test]
        public void AddintTest5()
        {
            Calculator obj = new Calculator();
            int variable = obj.Add(0,-2);
            Assert.AreEqual(-2, variable);
        }
         [Test]
        public void AddfloatTest1()
        {
            Calculator obj = new Calculator();
            float variable = obj.Add(5.2F,2.3F);
            Assert.AreEqual(7.5, variable);
        }
         [Test]
        public void AddlongTest1()
        {
            Calculator obj = new Calculator();
            long variable = obj.Add(10000000,20000000);
            Assert.AreEqual(30000000, variable);
        }
         [Test]
        public void AddstringTest1()
        {
            Calculator obj = new Calculator();
            string variable = obj.Add("7","2");
            Assert.AreEqual("72", variable);
        }
         [Test]
        public void AddfloatTest2()
        {
            Calculator obj = new Calculator();
            float variable = obj.Add(7.2F,-5.1F);
            Assert.AreEqual(2.1F, variable);
        }
        [Test]
        public void AddfloatTest3()
        {
            Calculator obj = new Calculator();
            float variable = obj.Add(7.2F,0);
            Assert.AreEqual(7.2F, variable);
        }
          [Test]
        public void AddfloatTest4()
        {
            Calculator obj = new Calculator();
            float variable = obj.Add(-7.2F,0);
            Assert.AreEqual(-7.2F, variable);
        }
           [Test]
        public void AddfloatTest5()
        {
            Calculator obj = new Calculator();
            float variable = obj.Add(-7.2F,-5.1F);
            Assert.AreEqual(-12.2999992F, variable);
        }
             [Test]
        public void AddlongTest2()
        {
            Calculator obj = new Calculator();
            long variable = obj.Add(-10000000,-20000000);
            Assert.AreEqual(-30000000, variable);
        }
            [Test]
        public void AddlongTest3()
        {
            Calculator obj = new Calculator();
            long variable = obj.Add(10000000,-20000000);
            Assert.AreEqual(-10000000, variable);
        }
            [Test]
        public void AddlongTest4()
        {
            Calculator obj = new Calculator();
            long variable = obj.Add(-10000000,0);
            Assert.AreEqual(-10000000, variable);
        }
            [Test]
        public void AddlongTest5()
        {
            Calculator obj = new Calculator();
            long variable = obj.Add(10000000,0);
            Assert.AreEqual(10000000, variable);
        }
          [Test]
        public void AddstringTest2()
        {
            Calculator obj = new Calculator();
            string variable = obj.Add("Sijo","George");
            Assert.AreEqual("SijoGeorge", variable);
        }
        [Test]
        public void SubstractintTest1()
        {
            Calculator obj = new Calculator();
            int variable = obj.Substract(5,2);
            Assert.AreEqual(3, variable);
        }
         [Test]
        public void SubstractintTest2()
        {
            Calculator obj = new Calculator();
            int variable = obj.Substract(-5,-2);
            Assert.AreEqual(-3, variable);
        }
         [Test]
        public void SubstractintTest3()
        {
            Calculator obj = new Calculator();
            int variable = obj.Substract(-5,2);
            Assert.AreEqual(-7, variable);
        }
         [Test]
        public void SubstractintTest4()
        {
            Calculator obj = new Calculator();
            int variable = obj.Substract(-5,0);
            Assert.AreEqual(-5, variable);
        }
         [Test]
        public void SubstractintTest5()
        {
            Calculator obj = new Calculator();
            int variable = obj.Substract(5,0);
            Assert.AreEqual(5, variable);
        }
         [Test]
        public void SubstractfloatTest1()
        {
            Calculator obj = new Calculator();
            float variable = obj.Substract(5.2F,2.3F);
            Assert.AreEqual(2.89999986F, variable);
        }
          [Test]
        public void SubstractfloatTest2()
        {
            Calculator obj = new Calculator();
            float variable = obj.Substract(-5.2F,-2.3F);
            Assert.AreEqual(-2.89999986F, variable);
        }
            [Test]
        public void SubstractfloatTest3()
        {
            Calculator obj = new Calculator();
            float variable = obj.Substract(5.2F,-2.3F);
            Assert.AreEqual(7.5F, variable);
        }
            [Test]
        public void SubstractfloatTest4()
        {
            Calculator obj = new Calculator();
            float variable = obj.Substract(5.2F,0);
            Assert.AreEqual(5.19999981F, variable);
        }
             [Test]
        public void SubstractfloatTest5()
        {
            Calculator obj = new Calculator();
            float variable = obj.Substract(-5.2F,0);
            Assert.AreEqual(-5.19999981F, variable);
        }
        [Test]
        public void SubstractlongTest1()
        {
            Calculator obj = new Calculator();
            long variable = obj.Substract(20000000,10000000);
            Assert.AreEqual(10000000, variable);
        }
         [Test]
        public void SubstractlongTest2()
        {
            Calculator obj = new Calculator();
            long variable = obj.Substract(-20000000,-10000000);
            Assert.AreEqual(-10000000, variable);
        }
         [Test]
        public void SubstractlongTest3()
        {
            Calculator obj = new Calculator();
            long variable = obj.Substract(-20000000,10000000);
            Assert.AreEqual(-30000000, variable);
        }
         [Test]
        public void SubstractlongTest4()
        {
            Calculator obj = new Calculator();
            long variable = obj.Substract(20000000,0);
            Assert.AreEqual(20000000, variable);
        }
         [Test]
        public void SubstractlongTest5()
        {
            Calculator obj = new Calculator();
            long variable = obj.Substract(-20000000,0);
            Assert.AreEqual(-20000000, variable);
        }
          [Test]
        public void MultiplyintTest1()
        {
            Calculator obj = new Calculator();
            int variable = obj.Multiply(5,2);
            Assert.AreEqual(10, variable);
        }
          [Test]
        public void MultiplyintTest2()
        {
            Calculator obj = new Calculator();
            int variable = obj.Multiply(-5,-2);
            Assert.AreEqual(10, variable);
        }
          [Test]
        public void MultiplyintTest3()
        {
            Calculator obj = new Calculator();
            int variable = obj.Multiply(-5,2);
            Assert.AreEqual(-10, variable);
        }
          [Test]
        public void MultiplyintTest4()
        {
            Calculator obj = new Calculator();
            int variable = obj.Multiply(5,0);
            Assert.AreEqual(0, variable);
        }
          [Test]
        public void MultiplyintTest5()
        {
            Calculator obj = new Calculator();
            int variable = obj.Multiply(-5,0);
            Assert.AreEqual(0, variable);
        }
         [Test]
        public void MultiplyfloatTest1()
        {
            Calculator obj = new Calculator();
            float variable = obj.Multiply(5.2F,2.3F);
            Assert.AreEqual(11.9599991F, variable);
        }
           [Test]
        public void MultiplyfloatTest2()
        {
            Calculator obj = new Calculator();
            float variable = obj.Multiply(-5.2F,-2.3F);
            Assert.AreEqual(11.9599991F, variable);
        }
            [Test]
        public void MultiplyfloatTest3()
        {
            Calculator obj = new Calculator();
            float variable = obj.Multiply(5.2F,-2.3F);
            Assert.AreEqual(-11.9599991F, variable);
        }
            [Test]
        public void MultiplyfloatTest4()
        {
            Calculator obj = new Calculator();
            float variable = obj.Multiply(5.2F,0);
            Assert.AreEqual(0, variable);
        }
            [Test]
        public void MultiplyfloatTest5()
        {
            Calculator obj = new Calculator();
            float variable = obj.Multiply(-5.2F,0);
            Assert.AreEqual(0, variable);
        }
         [Test]
        public void MultiplylongTest1()
        {
            Calculator obj = new Calculator();
            long variable = obj.Multiply(20000000,10000000);
            Assert.AreEqual(552894464, variable);
        }
         [Test]
        public void MultiplylongTest2()
        {
            Calculator obj = new Calculator();
            long variable = obj.Multiply(-20000000,10000000);
            Assert.AreEqual(-552894464, variable);
        }
            [Test]
        public void MultiplylongTest3()
        {
            Calculator obj = new Calculator();
            long variable = obj.Multiply(-20000000,-10000000);
            Assert.AreEqual(552894464, variable);
        }
              [Test]
        public void MultiplylongTest4()
        {
            Calculator obj = new Calculator();
            long variable = obj.Multiply(-20000000,0);
            Assert.AreEqual(0, variable);
        }
              [Test]
        public void MultiplylongTest5()
        {
            Calculator obj = new Calculator();
            long variable = obj.Multiply(20000000,0);
            Assert.AreEqual(0, variable);
        }
    }
}
