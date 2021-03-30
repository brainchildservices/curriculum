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
        public string Print(int num)
        {
            if (num % 3 == 0)
            {
                return "Fizz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return num.ToString();
            }
        }

        ///Accept one number and return an array of strings(Fizz or Buzz or the number ) for each value 0 to num passed to the below function
        public string[] PrintNumbers(int num)
        {
            string[] fizzbuzzArray = new string[num + 1];
            // for (int i = 0; i < num + 1; i++)
            // {
            //     if (i % 3 == 0)
            //     {
            //         fizzbuzzArray[i] = "Fizz";
            //     }
            //     else if (i % 5 == 0)
            //     {
            //         fizzbuzzArray[i] = "Buzz";
            //     }
            //     else
            //     {
            //         fizzbuzzArray[i] = i.ToString();
            //     }
            // }
            for(int i=0;i<num+1;i++)
            {
                 if(i==0)
                {
                    fizzbuzzArray[0]="0";
                }
                else
                {
                fizzbuzzArray[i]=Print(i);
                }
            }
            return fizzbuzzArray;
        }
    }
}