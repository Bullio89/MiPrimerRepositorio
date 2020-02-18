using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.UAM.O0P
{
   public class Cita
    {

        private int _idCita;
        private String _nombreDoctor;
        private String _nombreCliente;


        public Cita()
        {
        }

        public Cita(int idCita, string nombreDoctor, string nombreCliente)
        {
            IdCita = idCita;
            NombreDoctor = nombreDoctor;
            NombreCliente = nombreCliente;
        }

        public int IdCita { get => _idCita; set => _idCita = value; }
        public string NombreDoctor { get => _nombreDoctor; set => _nombreDoctor = value; }
        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
    }
}
