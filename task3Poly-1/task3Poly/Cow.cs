using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3Poly
{
    internal class Cow : Animals // Inherited class from Animals
    {
        public double amtMilk;
        public Cow(int id, double amtMilk) : base(id)
        {
            this.amtMilk = amtMilk;
        }
        override public double getProf() // override method, Calcualte Profibility
        {
            double profCow = (amtMilk * Prices.CowsMilkPrice) - Prices.CowVaxPrice;
            return (profCow);
        }
    }
}
