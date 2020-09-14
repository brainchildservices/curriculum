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
        public string Print(int a)
        {
            if(a%3==0 && a%5==0){
                return "Fizz Buzz";
            }
            else if(a%3 == 0){
                return "Fizz";
            }
            else if(a% 5== 0){
                return "Buzz";
            }
            else{
                return a.ToString();
            }
        }

        ///Accept one number and return an array of strings(Fizz or Buzz or the number ) for each value 0 to num passed to the below function
        public string[] PrintNumbers(int length){
            string[] result = new string[length];
            for (int i = 1; i <=length; i++)
            {
                if(i%3 == 0 && i%5 == 0){
                    result[i-1] = "Fizz Buzz";
                }
                else if(i%3 == 0){
                    result[i-1] = "Fizz";
                }
                else if(i%5 == 0){
                    result[i-1] = "Buzz";
                }
                else{
                    result[i-1] = i.ToString();
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
