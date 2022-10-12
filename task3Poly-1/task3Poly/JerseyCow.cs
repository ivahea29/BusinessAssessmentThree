using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3Poly
{
    internal class JerseyCow : Cow // Inherited class from Cow
    {
        public JerseyCow(int id, double amtMilk) : base(id, amtMilk)
        {
            ;
        }
        override public double getProf() // override method
        {
            double proofJersey = (base.amtMilk * Prices.CowsMilkPrice) -Prices.JerseyCowVaxPrice;
            return (proofJersey);
        }
    }
}