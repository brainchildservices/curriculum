using System;
namespace Brainchild.Curriculum.Solutions
{
    
   
    public class FizzBuzz1 {
       
        public string Print(int num)
        {
             if(num%5==0 && num%3==0){
                 return "FizzBuzz";
             }
             
             else if(num%3==0){
                return "Fizz";
             }
             else if(num%5==0){
                return "Buzz";
             }
             else{
                return num.ToString();
            }
        }
    }
	public class FizzBuzz2:FizzBuzz1{
        public string[] PrintOutput(int l)
        {
            string[] result=new string[l];
            for (int i = 1; i <=l; i++)
            {
                result[i-1]=Print(i);
            }
         
          return result;
        }
    }

     
   }
   
   
    
