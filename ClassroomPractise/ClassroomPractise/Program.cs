using ClassroomPractise.Generic;
using ClassroomPractise.Implicit_Explicit;
using System;

namespace ClassroomPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit,Explicit

            Euro euro = new Euro(500);
            Bitcoin bitcoin = euro;

            Console.WriteLine(bitcoin.Btc);

            Bitcoin bitcoin1 = new Bitcoin(2);
            Euro euro1 = bitcoin1;

            Console.WriteLine(euro1.Eur);

            #endregion

            #region Generic

            //DataArray<Pistol, Weapon> weapons = new DataArray<Pistol, Weapon>();

            //weapons.Add(new Pistol());
            //weapons.Add(new Pistol());

            //weapons.GetAll();


            //IntArray list = new IntArray();
            //list.Add(2);
            //list.Add(5);
            //list.GetAll();

            //WeaponArray weaponList = new WeaponArray();
            //Weapon p1 = new Weapon
            //{
            //    BulletCount = 32
            //};

            //weaponList.Add(p1);
            //weaponList.Add(new Weapon { BulletCount = 35 });

            //weaponList.GetAll();

            #endregion
        }
    }
}
