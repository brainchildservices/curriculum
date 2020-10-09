using NUnit.Framework;
using Brainchild.Curriculum.Solutions;
namespace Brainchild.Curriculum
{
    [TestFixture]
    public class Test16
    {
        [SetUp]
        public void SetUp()
        {
        }
        [Test]
        public void CheckingAreaOfCircle()
        {
            Assert.AreEqual(GoemetricCalculatorArea.Circle(5), 78.50d);

        }
        [Test]
        public void CheckingAreaOfTriangle()
        {
            Assert.AreEqual(GoemetricCalculatorArea.Triangle(6.7, 7.8), 26.13d);

        }
        [Test]
        public void CheckingTotalSurfaceAreaOfCube()
        {
            Assert.AreEqual(GoemetricCalculatorArea.Cube(5.56), 185.48d);

        }
        [Test]
        public void CheckingTotalSurfaceAreaOfCylinder()
        {
            Assert.AreEqual(GoemetricCalculatorArea.Cylinder(7, 8), 659.40d);

        }
        [Test]
        public void CheckingPascalCase()
        {
            Assert.AreEqual(Pascal.ToPascalCase("abC gH"), "Abc Gh");

        }
          [Test]
        public void CheckingPascalCase2()
        {
            string str="gh Nb mB";
            Assert.AreEqual(str.ToPascalCase(), "Gh Nb Mb");

        }
    }
}
