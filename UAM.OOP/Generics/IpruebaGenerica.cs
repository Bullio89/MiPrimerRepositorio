using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public interface IpruebaGenerica<T>
    {

        T Suma(T a, T b);

        T resta(T a, T b);

        T division(T a, T b);

        T Multiplicacion(T a, T b);


    }

}
