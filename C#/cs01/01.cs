using System;
namespace Brainchild.Curriculum.Solutions
{
    public class FizzBuzz
    {
        public string PrintIndividual(int a)
        {
            if(a%3==0 && a%5==0){
                return "Fizz Buzz";
            }
            else if(a%3==0){
                return "Fizz";
            }
            else if(a%5==0){
                return "Buzz";
            }
            else{
                return a.ToString();
            }
        }
        public string[] PrintNumbers(int length)
        {
            string[] result=new string[length];
            for (int i = 1; i <=length; i++)
            {
                if(i%3==0 && i%5==0){
                    result[i-1]="Fizz Buzz";
                }
                else if(i%3==0){
                    result[i-1]="Fizz";
                }
                else if(i%5==0){
                    result[i-1]= "Buzz";
                }
                else{
                    result[i-1]= i.ToString();
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
