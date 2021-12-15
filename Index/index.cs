using System;
using System.Collections.Generic;
using System.Text;

namespace Index
{
    public static class Index
    {
        public static int FindIndex(int[] array, int element)
        {//0
            for (int i = 1; i < array.Length; i++)//1
                if (array[i] == element)//2
                    return i;//3

            return -1; //4
        }//5
    }
}
