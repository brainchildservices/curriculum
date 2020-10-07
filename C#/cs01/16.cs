using System;
namespace Brainchild.Curriculum.Solutions
{
    public static class ExtensionMethod
    {
        public static string ToPascal(this string str)
        {
            char[] result = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                {
                    result[i] = Char.ToUpper(str[i]);
                }
                else
                    result[i] = Char.ToLower(str[i]);
            }
            string output=new string(result);
            return output;
        }
    }
}
