using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.UAM.O0P
{
    public class Persona
    {
        private int _id;
        private String _nombre;
        private String _apellido;
        private int _cedula;

        public Persona()
        {
        }

        public Persona(int id, string nombre, string apellido, int cedula)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _cedula = cedula;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Cedula { get => _cedula; set => _cedula = value; }
    }




}
