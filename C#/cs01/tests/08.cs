using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test08
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void TestCircle()
        {
            double result=GeometryCalculator.CircleArea(10);
            Assert.AreEqual(result,314);
        }
        [Test]
        public void TestCube()
        {
            int result=GeometryCalculator.CubeArea(5);
            Assert.AreEqual(result,150);
        }
        [Test]
        public void TestCylinder()
        {
            double result=GeometryCalculator.CylinderArea(6,5);
            Assert.AreEqual(result,414.48001098632812);
        }
        [Test]
        public void TestTriangle()
        {
            double result=GeometryCalculator.TriangleArea(6,13);
            Assert.AreEqual(result,39);
        }
      }
}