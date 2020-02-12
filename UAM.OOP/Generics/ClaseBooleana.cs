using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP.Generics
{
    class ClaseBooleana : IpruebaGenerica<Boolean>
    {
        public bool division(bool a, bool b)
        {

            return (a || b);
        }

        public bool Multiplicacion(bool a, bool b)
        {
            return (a && b);
        }

        public bool resta(bool a, bool b)
        {
            return !(a || b);
        }

        public bool Suma(bool a, bool b)
        {
            return !(a && b);
        }
    }
}

