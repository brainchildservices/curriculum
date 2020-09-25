using System;
namespace Brainchild.Curriculum.Solutions
{
    //Implicit Casting (automatically) - converting a smaller type to a larger type size
    // char -> int -> long -> float -> double

    // Explicit Casting (manually) - converting a larger type to a smaller size type
    // double -> float -> long -> int -> char

    public class TypeCasting
    {
        //Returning Double values
        public double ConvertToDouble(char a)
        {
            return a; //Implicit conversion
        }
        public double ConvertToDouble(int a)
        {
            return a; //Implicit conversion
        }
        public double ConvertToDouble(long a)
        {
            return a; //Implicit conversion
        }
        public double ConvertToDouble(float a)
        {
            return a; //Implicit conversion
        }
        //Returning Float values
        public float ConvertToFloat(char a)
        {
            return a; //Implicit conversion
        }
        public float ConvertToFloat(int a)
        {
            return a; //Implicit conversion
        }
        public float ConvertToFloat(long a)
        {
            return a; //Implicit conversion
        }
        public float ConvertToFloat(double a)
        {
            return Convert.ToSingle(a); //Explicit conversion
        }
        //Returning Long values
        public long ConvertToLong(char a)
        {
            return a; //Implicit conversion
        }
        public long ConvertToLong(int a)
        {
            return a; //Implicit conversion
        }
        public long ConvertToLong(float a)
        {
            return Convert.ToInt64(a); //Explicit conversion
        }
        public long ConvertToLong(double a)
        {
            return Convert.ToInt64(a); //Explicit conversion
        }
        //Returning Integer values
        public int ConvertToInt(char a)
        {
            return a; //Implicit conversion
        }
        public int ConvertToInt(float a)
        {
            return Convert.ToInt32(a); //Explicit conversion
        }
        public int ConvertToInt(long a)
        {
            return Convert.ToInt32(a); //Explicit conversion
        }
        public int ConvertToInt(double a)
        {
            return Convert.ToInt32(a); //Explicit conversion
        }
        //Returning Char values
        public char ConvertToChar(int a)
        {
            return Convert.ToChar(a); //Explicit conversion
        }
        public char ConvertToChar(long a)
        {
            return Convert.ToChar(a); //Explicit conversion
        }
        //Following two methods will always throw an InvalidCastException.
        //ToChar(Double) and ToChar(Float)
        public char ConvertToChar(float a)
        {
            return Convert.ToChar(a); //Explicit conversion
        }
        public char ConvertToChar(double a)
        {
            return Convert.ToChar(a); //Explicit conversion
        }
    }
}
