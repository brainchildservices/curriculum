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
           public int Add(int x, int y){
               return x+y;
           }
            public float Add(float x, float y){
               return x+y;
           }
            public long Add(long x, long y){
               return x+y;
           }
            public string Add(string x, string y){
               return x+y;
           }
           public int Subtract(int x, int y){
               return x-y;
           }
            public float Subtract(float x, float y){
               return x-y;
           }
            public long Subtract(long x, long y){
               return x-y;
           }
            public int Multiply(int x, int y){
               return x*y;
           }
            public float Multiply(float x, float y){
               return x*y;
           }
              public long Multiply(long x, long y){
               return x*y;
           }
    }
}