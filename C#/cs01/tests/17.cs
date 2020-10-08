using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test17
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void TestCircleArea()
        {
            double result = GoemetryCalculator.AreaCircle(10);
            Assert.AreEqual(result, 314.16);
        }
        [Test]
        public void TestCubeArea()
        {
            int result = GoemetryCalculator.AreaCube(12);
            Assert.AreEqual(result, 864);
        }
        [Test]
        public void TestCylinderArea()
        {
            double result = GoemetryCalculator.AreaCylinder(5, 12);
            Assert.AreEqual(result, 534.07);
        }
        [Test]
        public void TestTriangleArea()
        {
            double result = GoemetryCalculator.AreaTriangle(15, 13);
            Assert.AreEqual(result, 97.5);
        }
    }
}
