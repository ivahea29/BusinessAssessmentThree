using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Inh_Poly
{
    class Jersey_Cow: Cow
    {
        public Jersey_Cow(int id, double amtOfMilk): base(id, amtOfMilk)
        {
            
        }

        //calculate profitibility of Jersey_Cow object
        public override double getProf()
        {
            double jerseyprof = (base.amtOfMilk * Prices.CowsMilkPrice) - Prices.JerseyCowVaxPrice;
            return (jerseyprof);
        }
    }
}
