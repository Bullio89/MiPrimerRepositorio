﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public interface Icrud<T>
    {

        void insertar(T Icrud);

        void Eliminar(int indice);

        T buscar(int indice);

    }
}
