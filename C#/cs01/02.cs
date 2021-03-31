using System;
namespace Brainchild.Curriculum.Solutions
{
    /*
    Implement  calculator class which can have follow functionalities
    //Add method - can accept any two numbers and return sum( you should be able to pass integers,floats ,very large numbers or strings)
    //Substract method - can accept any two numbers ( should accept integers,floats ,very large numbers)
    //Multiply method - should accept integers,floats ,very large numbers
    */
    public class Calculator
    {
        // please note that you can use concept method overloading to accept integers/floats etc 

       public int Add(int a,int b)
       {
           int sum=a+b;
           return sum;
       }
        public float Add(float a,float b)
       {
           float sum=a+b;
           return sum;
       }
        public long Add(long a,long b)
       {
           long sum=a+b;
           return sum;
       }
        public string Add(string a,string b)
       {
           string sum=a+b;
           return sum;
       }
       public int Substract(int a,int b)
       {
           int sum=a-b;
           return sum;
       }
        public float Substract(float a,float b)
       {
           float sum=a-b;
           return sum;
       }
        public long Substract(long a,long b)
       {
           long sum=a-b;
           return sum;
       }
        public int Multiply(int a,int b)
       {
           int sum=a*b;
           return sum;
       }
        public float Multiply(float a,float b)
       {
           float sum=a*b;
           return sum;
       }
        public long Multiply(long a,long b)
       {
           long sum=a*b;
           return sum;
       }
    }
}
