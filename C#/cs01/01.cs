using System;
namespace Brainchild.Curriculum.Solutions
{
    /*
    Write a program that prints the numbers from 1 to 100 and for multiples of '3' print "Fizz" instead of the number 
    and for the multiples of '5' print "Buzz".

    1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, 
    Fizz ...
    */
    public class FizzBuzzPrinter
    {
        ///Accept one number and return a string(Fizz or Buzz or the number ) based on the aforementioned logic 
        public string Print(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                return "Fizz";
            }
            else if (i % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return i.ToString();
            }
        }

        ///Accept one number and return an array of strings(Fizz or Buzz or the number ) for each value 0 to num passed to the below function
        public string[] PrintNumbers(int num)
        {
            string [] result = new string [num];
            for(int i=0; i<num; i++)
            {
                result [i]= Print (i+1);
            }
            return result;
        }
    }
}