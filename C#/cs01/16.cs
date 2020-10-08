using System;
using System.Globalization;
namespace Brainchild.Curriculum.Solutions
{
    public static class Pascal
        {
            public static string ToPascalCase(this string any)
            {
                TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                return myTI.ToTitleCase(any);
            }
        }
    public static class GoemetricCalculatorArea
    {

        public static double Circle(double radius)
        {
            return Math.Round((3.14 * radius * radius), 2);
        }
        public static double Triangle(double baselengthoftriangle, double height)
        {
            return Math.Round(((baselengthoftriangle * height) / 2), 3);
        }
        public static double Cube(double sidelength)
        {
            return Math.Round((6 * sidelength * sidelength), 2);
        }
        public static double Cylinder(double radius, double height)
        {
            return Math.Round(((2 * 3.14 * radius * height) + (2 * 3.14 * radius * radius)), 2);
        }
    }
}
