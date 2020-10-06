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
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
            // return num1+num2;
        }
        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }
        public long Add(long num1, long num2)
        {
            return num1 + num2;
        }
        public string Add(string name1, string name2)
        {
            return name1 + name2;
        }
        public int Subtract(int num1, int num2)
        {

            return num1 - num2;
        }
        public float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }
        public long Subtract(long num1, long num2)
        {
            return num1 - num2;
        }
        public int Multiply(int num1, int num2)
        {

            return num1 * num2;
        }
        public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public long Multiply(long num1, long num2)
        {
            return num1 * num2;
        }
    }
}