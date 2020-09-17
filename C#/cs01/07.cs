using System;
namespace Brainchild.Curriculum.Solutions
{
/*
Create a Fact method that receives a non-negative integer and returns the factorial of that number.

Examples
Fact(1) ➞ 1

Fact(3) ➞ 6

Fact(6) ➞ 720
Notes
Consider that 0! = 1.
You should return a long data type number.
use recursion
*/
    public class Factorial
    {
        public long Fact(long num)
        {
            if(num==0)
            {
                return 1;
            }
            else
            return num*Fact(num-1);
        }
    }
}
