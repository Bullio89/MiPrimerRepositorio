using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.UAM.O0P
{
    public class Program
    {
        static void Main(string[] args)
        {

            agregarCliente_Doctor cd = new agregarCliente_Doctor();
            CrearCita cita = new CrearCita();
            cd.quemarClientes();
            cd.quemarDoctores();
            cita.quemarHoras();
            cita.agregarCita();
            cita.agregarCita();
            cita.agregarCita();
            cita.eliminarCita(1);
            cita.imprimir();
            Console.ReadKey();
            





        }
    }
}
