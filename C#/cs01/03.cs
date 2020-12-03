using System;
namespace Brainchild.Curriculum.Solutions
{
    //implement bubblesort in C# and also create the necessary tests
    public class BubbleSort
    {
        public int[] Sort(int[] arr)
        {

            int n =arr.Length;
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }
    }
}