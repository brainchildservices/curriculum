using System;
using System.Globalization;
namespace Brainchild.Curriculum.Solutions
{
     public static class Pascal
    {
        public static string ToPascalCase(this string any)
        {
            String[] split = { " ", "," };
            String[] strarr = any.Split(split, StringSplitOptions.RemoveEmptyEntries);
            string pascalstr = "";
			int len=strarr.Length;
			foreach (string str in strarr)
            {
				char[] x=new char[str.Length];
                 x[0]=char.ToUpper(str[0]);
                for (int i = 1; i < str.Length; i++)
                {
                    x[i]=char.ToLower(str[i]);
                }
				if(str!=strarr[len-1]){
				pascalstr+=new string(x)+" ";
				}else{pascalstr+=new string(x);
				}
				
            }
            return pascalstr;
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
