using System;
namespace Brainchild.Curriculum.Solutions
{
/*
Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num up to length.

Examples
ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]

ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]

ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]
Notes
Notice that num is also included in the returned array.
*/
    public class MultiplesOfNumber
    {
        public int[] makeMultiples(int num, int length)
        {
            int[] array=new int[length];
           int i = 1;
           do
            {
                array[i-1]=num*i;
                i++;
            }while(i<=length);
            return array;
        }
    }
}
