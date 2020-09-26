using System;
namespace Brainchild.Curriculum.Solutions
{
    public class TypeCast
    {
        //Implicit Conversion
        public double RecastToDouble(char m)
        {
            double n = m;
            return n;
        }
        public double RecastToDouble(int m)
        {
            double n = m;
            return n;

        }
        public double RecastToDouble(long m)
        {
            double n = m;
            return n;
        }
        public double RecastToDouble(float m)
        {
            double n = m;
            return n;
        }
        public float RecastToFloat(char m)
        {
            float n = m;
            return n;
        }
        public float RecastToFloat(int m)
        {
            float n = m;
            return n;
        }
        public float RecastToFloat(long m)
        {
            float n = m;
            return n;
        }
        public long RecastToLong(char m)
        {
            long n = m;
            return n;
        }
        public long RecastToLong(int m)
        {
            long n = m;
            return n;
        }
        public int RecastToInteger(char m)
        {
            return m;
        }


        //Explicit Conversion
        public float RecastToFloat(double m)
        {
            float n = (float)m;
            return n;
        }
        public long RecastToLong(float m)
        {
            long n = (long)m;
            return n;
        }
        public long RecastToLong(double m)
        {
            long n = Convert.ToInt64(m);
            return n;
        }
        public int RecastToInteger(float m)
        {
            int n = (int)m;
            return n;
        }
        public int RecastToInteger(long m)
        {
            int n = (int)m;
            return n;
        }
        public int RecastToInteger(double m)
        {
            return Convert.ToInt32(m);
        }
        public char RecastToCharacter(int m)
        {
            return Convert.ToChar(m);
        }
        public char RecastToCharacter(long m)
        {
            char n = (char)m;
            return n;
        }
        public char RecastToCharacter(float m)
        {
            return (char)m;
        }
        public char RecastToCharacter(double m)
        {
            return (char)m;
        }
    }
}