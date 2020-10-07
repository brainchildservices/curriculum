using System;
namespace Brainchild.Curriculum.Solutions
{
    // static class GoemetryCalculator
    // should have functionalities for Are of
    // Circle,Cube,Triangle,Cyllinder
    public static class GoemetryCalculator
    {
        public static double AreaCircle(int radius)
        {
            double result = Math.Round(radius * radius * Math.PI, 2);
            return result;
        }
        public static int AreaCube(int length)
        {
            int result = length * length;
            return result;
        }
        public static double AreaCylinder(int radius, int height)
        {
            double result = Math.Round(2 * radius * Math.PI * (radius + height), 2);
            return result;
        }
        public static double AreaTriangle(int base_, int height)
        {
            double result = Math.Round(0.5 * base_ * height, 2);
            return result;
        }
    }
}