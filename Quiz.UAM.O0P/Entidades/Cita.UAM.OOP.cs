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
        private String _hora;


        public Cita()
        {
        }

        public Cita(int idCita, string nombreDoctor, string nombreCliente, string hora)
        {
            _idCita = idCita;
            _nombreDoctor = nombreDoctor;
            _nombreCliente = nombreCliente;
            _hora = hora;
        }

        public override string ToString()
        {
            return "Id: " + IdCita + "Nombre: " + NombreCliente;
        }

        public int IdCita { get => _idCita; set => _idCita = value; }
        public string NombreDoctor { get => _nombreDoctor; set => _nombreDoctor = value; }
        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public string _Hora { get => _hora; set => _hora = value; }
    }




}
