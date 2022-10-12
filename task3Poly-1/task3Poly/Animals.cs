using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3Poly
{
    internal class Animals // Parent class Animals
    {
        public int id;

        public Animals(int id)
        {
            this.id = id;
        }
        virtual public double getProf() // Virtual method
        {
            return (0);
        }
    }
}
