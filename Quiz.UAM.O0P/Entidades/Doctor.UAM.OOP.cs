﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.UAM.O0P
{
    public class Doctor : Persona
    {
        private String _especialidad;

        public Doctor()
        {
        }

        public Doctor(string especialidad)
        {
            Especialidad = especialidad;
        }

        public Doctor(string especialidad,int id,string nombre,string apellido,int cedula)
            : base(id,nombre,apellido,cedula)
        {
            Especialidad = especialidad;
        }

        public string Especialidad { get => _especialidad; set => _especialidad = value; }

        public override string ToString()
        {
            return "Id: " + Id + "\n" + "Nombre: " + Nombre + "\n" + "Especialidad: " + Especialidad;
        }
    }
}
