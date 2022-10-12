using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Inh_Poly
{
    class Cow: Animal
    {
        public double amtOfMilk;
        public Cow(int id, double amtOfMilk) : base(id)
        {
            this.amtOfMilk = amtOfMilk; 
        }
        
        //calculate profitabilty of cow object
        override public double getProf()
        {
            double cowprof = (amtOfMilk * Prices.CowsMilkPrice) - Prices.CowVaxPrice;
            return (cowprof);
        }
    }
}
