using System;
namespace Brainchild.Curriculum.Solutions
{
    //implement bubblesort in C# and also create the necessary tests
    public class BubbleSorting
    {
        public int[] Sort(int[] array){
            int length=array.Length;
            for (int i = 0; i < length; i++)
            {
               
                int j= 0;
                 do {
                    if( array [ j ]>array[ j + 1 ]) {
                        int x = array [ j ];
                        array [ j ] = array[ j + 1 ];
                        array [ j + 1 ] = x;
                       
                    }
                    j++;
                }while( j < length-1 );
              
            }
            return array;
        }
    }
}