using System;
namespace Brainchild.Curriculum.Solutions
{
    /*Given a string split the string into tokens. We define a token to be one or more consecutive English alphabetic letters. Then, print the number of tokens, followed by each token on a new line.
    Note: You may find the String.split method helpful in completing this challenge.
    Output Format
    On the first line, print an integer, , denoting the number of tokens in string   Next, print each of the  tokens on a new line in the same order as they appear in input string .
    Sample Input
    He is a very very good boy, isn't he?
    Sample Output
    10
    He
    is
    a
    very
    very
    good
    boy
    isn
    t
    he*/
    public class StringSplitter
    {
        public string[] SplitString(string input)
        {
            string[] result;
            char[] exceptAlphabets=nonAlphabets(input);
            result = input.Split(exceptAlphabets, StringSplitOptions.RemoveEmptyEntries);
            string[] print=new string[result.Length+1];
            print[0]=(result.Length).ToString();
            for (int i = 1; i <= result.Length; i++)
            {
                print[i]=result[i-1];
            }
            return print;
        }
        char[] nonAlphabets(string myString)
        {
            char[] symbols=new char[myString.Length];
            int j=0;
            for (int i = 0; i < myString.Length; i++)
            {
                if(!(Char.IsLetter(myString[i])))
                {
                    symbols[j]=myString[i];
                    j++;
                }
            }
            char[] symbolsLimited=new char[j];
            for (int i = 0; i < j; i++)
            {
                symbolsLimited[i]=symbols[i];
            }
            return symbolsLimited;
        }
    }
}