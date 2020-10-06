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
        int count = -1;
        int index=0;
        public int[] array = new int[1];
        public int Count
        {
            get
            {
                return count + 1;
            }
        }
        public void Add(int num)
        {
            count = count + 1;
            index=count;
            if (index == 0)
            {
                array[0] = num;
            }
            else
            {
                int[] temp = new int[index];
                temp = array;
                array = new int[index + 1];
                for (int i = 0; i < temp.Length; i++)
                {
                    array[i] = temp[i];
                }
                array[index] = num;
            }
        }
        public int Get(int index)
        {
            return array[index];
        }
    }
}
