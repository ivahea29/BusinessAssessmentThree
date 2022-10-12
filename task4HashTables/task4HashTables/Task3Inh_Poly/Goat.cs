using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Inh_Poly
{
    class Goat: Animal
    {
        public double amtOfMilk;
        public Goat(int id, double amtOfMilk) : base(id)
        {
            this.amtOfMilk = amtOfMilk;
        }

        //calculate profitability of Goat object
        override public double getProf()
        {
            double goatprof = (amtOfMilk * Prices.GoatsMilkPrice) - Prices.GoatVaxPrice;
            return (goatprof);
        }
    }
}
