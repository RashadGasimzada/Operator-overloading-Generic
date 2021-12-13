using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomPractise.Generic
{
    public class Weapon:IExample<Weapon>
    {
        public int BulletCount { get; set; }
    }
}
