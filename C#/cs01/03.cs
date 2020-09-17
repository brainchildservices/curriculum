using System;
namespace Brainchild.Curriculum.Solutions
{
    //implement bubblesort in C# and also create the necessary tests
    public class BubbleSort
    {
        public int[] Sort(int[] array){
            int length=array.Length;
            for (int i = 0; i < length; i++)
            {
                bool swap=false;
                for (int j = 0; j < length-1; j++)
                {
                    if(array[j]>array[j+1]){
                        int temp=array[j];
                        array[j]=array[j+1];
                        array[j+1]=temp;
                        swap=true;
                    }
                }
                if(swap==false){
                    break;
                }
            }
            return array;
        }
    }
}