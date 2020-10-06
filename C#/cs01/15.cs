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
        public int[] internalArr = new int[1];
        int i = -1;
        public int Get(int index)
        {
            return internalArr[index];
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
                internalArr[0] = num;
            }
            else
            {
                int[] localArr = new int[index];
                localArr = internalArr;
                internalArr = new int[index + 1];
                for (int j = 0; j < localArr.Length; j++)
                {
                    internalArr[j] = localArr[j];
                }
                internalArr[index] = num;
            }
        }

    }

}
