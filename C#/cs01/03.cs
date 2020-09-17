using System;
namespace Brainchild.Curriculum.Solutions
{
    //implement bubblesort in C# and also create the necessary tests
    public class BubbleSort
    {
        public int[] Sort(int[] arr){
            int length=arr.Length;
            for (int i = 0; i < length; i++)
            {
                bool swap=false;
                for (int j = 0; j < length-1; j++)
                {
                    if(arr[j]>arr[j+1]){
                        int temp=arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=temp;
                        swap=true;
                    }
                }
                if(swap==false){
                    break;
                }
            }
            return arr;
        }
    }
}
