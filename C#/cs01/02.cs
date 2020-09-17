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
           public int Add(int a, int b){
               return a+b;
           }
            public float Add(float a, float b){
               return a+b;
           }
            public long Add(long a, long b){
               return a+b;
           }
            public string Add(string a, string b){
               return a+b;
           }
           public int Subtract(int a, int b){
               return a-b;
           }
            public float Subtract(float a, float b){
               return a-b;
           }
            public long Sutract(long a, long b){
               return a-b;
           }
            public int Multiply(int a, int b){
               return a*b;
           }
            public float Multiply(float a, float b){
               return a*b;
           }
            public long Multiply(long a, long b){
               return a*b;
           }
    }
}