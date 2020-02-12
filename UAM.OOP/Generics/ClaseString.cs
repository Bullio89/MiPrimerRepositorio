using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class ClaseString : IpruebaGenerica<String>
    {
        public string division(string a, string b)
        {

            char[] primer = new char[a.ToCharArray().Length];
            char[] segundo = new char[b.ToCharArray().Length];

            String nuevo = a.Substring(a.Length / 2);
            String nuevo2 = b.Substring(b.Length  / 2);

            return (nuevo + nuevo2);
           
           


        }

        public string Multiplicacion(string a, string b)
        {
            int tamaño = (a.Length < b.Length) ? a.Length : b.Length;



        }

        public string resta(string a, string b)
        {

            if (a.Length < b.Length)
            {

                return a;
            }
            else {

                return b;
            }







        }

        public string Suma(string a, string b)
        {
            return a + b;
        }
    }
}
