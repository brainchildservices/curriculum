using System;
namespace Brainchild.Curriculum.Solutions
{
    public static class PascalConverter
    {
        public static string ToPascalCase(this string str)
        {
           char[] temp=new char[str.Length];
           temp[0]=Char.ToUpper(str[0]);
           for (int i = 1; i < str.Length; i++)
           {
               temp[i]=Char.ToLower(str[i]);
           }
           string caseResult=new string(temp);
           return caseResult;
        }
    }
}