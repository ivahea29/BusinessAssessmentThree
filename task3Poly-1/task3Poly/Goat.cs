using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3Poly
{
    internal class Goat : Animals // Inherited class from Animals
    {
        public double amtMilk;
        public Goat(int id, double amtMilk) : base(id)
        {
            this.amtMilk = amtMilk;
        }
        override public double getProf() // override method, Calcualte profibility
        {
            double profGoat = (amtMilk * Prices.GoatsMilkPrice) - Prices.GoatVaxPrice;
            return (profGoat);
        }
    }
}
