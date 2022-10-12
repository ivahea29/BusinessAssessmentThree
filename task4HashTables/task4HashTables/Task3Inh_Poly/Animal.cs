using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Inh_Poly
{
    class Animal
    {
        public int id;
        public Animal(int id) { this.id = id; }

        virtual public double getProf()
        {
            // Animal getProf method returns 0 as no object is ever made from the animal class itself.
            return (0);
        }
    }
}
