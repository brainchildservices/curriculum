using System;
using System.Text;
namespace Brainchild.Curriculum.Solutions
{
    /*
    Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.

    Examples
    ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"

    ReverseCase("MANY THANKS") ➞ "many thanks"

    ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
    */
    public class Conversion
    {
        public string convertopposite(string str1)
        {

            char[] arr1;
            int len;
            char ch;
            len = str1.Length;
            arr1 = str1.ToCharArray(0, len);

            for (int i = 0; i < len; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch))
                    arr1[i] = Char.ToUpper(ch);
                else
                    arr1[i] = Char.ToLower(ch);
            }
            string str = new string(arr1);
            return str;
        }
    }
}