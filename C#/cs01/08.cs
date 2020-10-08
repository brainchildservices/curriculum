using System;
namespace Brainchild.Curriculum.Solutions
{
    // static class GoemetryCalculator
    // should have functionalities for Are of
    // Circle,Cube,Triangle,Cyllinder
    public static class GeometryCalculator
    {
        public static double CircleArea(int radius)
        {
            float pi=3.14f;
            float result=(pi*(radius*radius));
            return result;
        }
        public static int CubeArea(int length)
        {
            int result = 6* length * length;
            return result;
        }
        public static double CylinderArea(int radius, int height)
        {
            float pi=3.14f;
            double result = (2 * radius *pi * (radius + height));
            return result;
        }
        public static double TriangleArea(int length, int height)
        {
            double result = (0.5 * length* height);
            return result;
        }
    }
} 