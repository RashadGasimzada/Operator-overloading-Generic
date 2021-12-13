using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomPractise.Generic
{
    public class DataArray<T,U>
    {
        private T[] arr;
        public DataArray()
        {
            arr = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = data;
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
