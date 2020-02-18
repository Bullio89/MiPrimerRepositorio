using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.UAM.O0P
{
    public class Cliente : Persona
    {

        private String _correo;
        private int _telefono;

        public Cliente()
        {
        }

        public Cliente(string correo, int telefono)
        {
            _correo = correo;
            _telefono = telefono;
        }

        public Cliente(string correo, int telefono, int id, string nombre, string apellido, int cedula)
            : base(id, nombre, apellido, cedula)
        {
            _correo = correo;
            _telefono = telefono;
        }




        public string Correo { get => _correo; set => _correo = value; }
        public int Telefono { get => _telefono; set => _telefono = value; }


        public override string ToString(){

            return "Id: " + Id + "\n" + "Nombre: " + Nombre;
}


    }


}