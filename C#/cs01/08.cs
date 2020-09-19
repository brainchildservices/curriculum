using System;
namespace Brainchild.Curriculum.Solutions
{
    
   
    public class FizzBuzzPrinter1:ChangeColor
    {
       
       public void Main(){
           Console.WriteLine("hellllooo");
             FizzBuzzPrinter2 a=new FizzBuzzPrinter2();
            string[] s=a.PrintNumbers2(15);
            for (int j = 0; j < 15; j++)
            {
                Console.WriteLine(s[j]);
            }
       }
        public string Print(int num)
        {
             if(num%5==0 && num%3==0){
                 return "FizzBuzz";
            }
             
             else if(num%3==0){
                return ConsolePrintColour("Fizz","blue");
            }
            else if(num%5==0){
                return ConsolePrintColour("Buzz","green");
            }
            else{
                return num.ToString();
            }
        }
     }
	public class FizzBuzzPrinter2:FizzBuzzPrinter1
    {
        public string[] PrintNumbers2(int l)
        {
            string[] result=new string[l];
            for (int i = 1; i <=l; i++)
            {
                result[i-1]=Print(i);
            }
        
          return result;
        }

    }

   public class ChangeColor
   { 
       public string ConsolePrintColour(string text,string colour)
       {
            if (colour == "green")
             {
                    Console.BackgroundColor = ConsoleColor.Green;    
             } else if(colour == "blue")
             {
                    Console.BackgroundColor = ConsoleColor.Blue;
             }        else
             {
                    Console.ResetColor();
             }     
        Console.ForegroundColor = ConsoleColor.White;
		 return text;
		 
        }
   }
    
 }
   
   
    
