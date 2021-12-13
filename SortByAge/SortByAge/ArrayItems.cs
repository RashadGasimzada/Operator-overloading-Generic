using System;
using System.Collections.Generic;
using System.Text;

namespace SortByAge
{
    public class ArrayItems<T> where T: Person
    {
        public T[] arr = new T[0];
        public int[] arr2 = new int[0];
        public void AddItems(T person)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = person;
        }
        public void GetSortedByAgeItems()
        { 
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Resize(ref arr2, arr2.Length + 1);
                arr2[i] = arr[i].Age;
            }
            Array.Sort(arr2);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
