using System;
namespace Brainchild.Curriculum.Solutions
{
    // ArrayList like class IntList
    // IntList should have two methods
    // Add(int num)
    // Get(int index)
    // Count Property
    public class IntList
    {
        public int[] integerArray = new int[1];
        int i = -1;
        public int Get(int index)
        {
            return integerArray[index];
        }
        public int Count
        {
            get
            {
                return i + 1;
            }
        }
        public void Add(int num)
        {
            i = i + 1;
            int index = i;
            if (index == 0)
            {
                integerArray[0] = num;
            }
            else
            {
                int[] localArray = new int[index];
                localArray = integerArray;
                integerArray = new int[index + 1];
                for (int j = 0; j < localArray.Length; j++)
                {
                    integerArray[j] = localArray[j];
                }
                integerArray[index] = num;
            }
        }

    }

}