﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class VHS : reproductores
    {

        private int id;
        private String nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public VHS(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public VHS()
        {
        }

        public void forward()
        {
            throw new NotImplementedException();
        }

        public void play()
        {
            throw new NotImplementedException();
        }

        public void rewind()
        {
            throw new NotImplementedException();
        }

        public void stop()
        {
            throw new NotImplementedException();
        }
    }
}
