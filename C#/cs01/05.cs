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
    public class StringCharacterCaseReversal
    {
        public static void convertToOppositeCase(StringBuilder str)
        {
            
            int ln = str.Length; 
            for (int i = 0 ; i < ln; i++) {
                
                  if (str[i]>='a' && str[i]<='z') {
                              
                     str[i] = (char)(str[i] - 32);
                  } 
                  
                  else if(str[i]>='A' && str[i]<='Z') {
                             
                       str[i] = (char)(str[i] + 32); 
                  } 
            }
        } 
     
    }
}
