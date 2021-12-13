using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomPractise.Implicit_Explicit
{
    public class Euro
    {
        public double Eur { get; set; }
        public Euro(double eur)
        {
            Eur = eur;
        }
        public static implicit operator Bitcoin(Euro euro)
        {
            return new Bitcoin(euro.Eur / 41853.58);
        }
    }
}
