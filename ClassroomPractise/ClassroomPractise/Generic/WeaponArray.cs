using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomPractise.Generic
{
    public class WeaponArray
    {
        private Weapon[] arr;
        public WeaponArray()
        {
            arr = new Weapon[0];
        }

        public void Add(Weapon person)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = person;
        }

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item.BulletCount);
            }
        }


    }
}
