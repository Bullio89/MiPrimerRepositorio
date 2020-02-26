using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {

        private int _id;
        private String _nombre;
        private String _email;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Email { get => _email; set => _email = value; }

        public Persona()
        {
           

        }

        public Persona(int id, string nombre, string email)
        {
            _id = id;
            _nombre = nombre;
            _email = email;
        }


    }
}
