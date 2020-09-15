using System;
namespace Brainchild.Curriculum.Solutions
{
/*
Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.

Examples
ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"

ReverseCase("MANY THANKS") ➞ "many thanks"

ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
*/
    public class StringReversal
    {
        public string stringReverse(string input)
        {
            char[] result=new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if(Char.IsUpper(input[i]))
                {
                    result[i]=Char.ToLower(input[i]);
                }
                else if(Char.IsLower(input[i]))
                {
                    result[i]=Char.ToUpper(input[i]);
                }
                else
                {
                    result[i]=input[i];
                }
            }
            string myresult=new string(result);
            return myresult;
        }
    }
}
