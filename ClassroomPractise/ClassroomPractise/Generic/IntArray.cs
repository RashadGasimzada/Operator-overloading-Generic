using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomPractise.Generic
{
    public class IntArray
    {
        private int[] arr;
        public IntArray()
        {
            arr = new int[0];
        }

        public void Add(int n)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = n;
        }

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
