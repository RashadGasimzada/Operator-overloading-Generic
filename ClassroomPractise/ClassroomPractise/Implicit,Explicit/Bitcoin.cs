using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomPractise.Implicit_Explicit
{
    public class Bitcoin
    {
        public double Btc { get; set; }
        public Bitcoin(double btc)
        {
            Btc = btc;
        }
        public static implicit operator Euro(Bitcoin bitcoin)
        {
            return new Euro(bitcoin.Btc * 41853.58);
        }
    }
}
