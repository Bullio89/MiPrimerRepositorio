using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class claseInt : IpruebaGenerica<int>
    {
        public int division(int a, int b)
        {
            if (b < 0)
            {

                return 0;
            }
            else {

                return a / b;
            }

            
        }

        public int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        public int resta(int a, int b)
        {
            return a - b;
        }

        public int Suma(int a, int b)
        {
            return a + b;
        }
    }
}
