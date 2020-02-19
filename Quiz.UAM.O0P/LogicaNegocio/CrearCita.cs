using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.UAM.O0P
{
    public class CrearCita:agregarCliente_Doctor
    {
        List<String> horas = new List<string>();
        public void quemarHoras()
        {
            horas.Add("8:00-9:00");
            horas.Add("9:00-10:00");
            horas.Add("10:00-11:00");
            horas.Add("11:00-12:00");

        }

        List<Cita> citas = new List<Cita>();


        public void agregarCita() {

                Cita c = new Cita();
           
                int cont= 0;
                c.NombreCliente = "Cliente: " + cont+1;
                c.NombreDoctor = "Doctor: " +  cont+1;
                c.IdCita = cont+1;
                c._Hora = horas[cont];
                cont++;
                   
                citas.Add(c);

        }

        public void eliminarCita(int c) {
            if (citas.Count == 0)
            {

                Console.WriteLine("No hay citas");

            }
            else
            {

                citas.RemoveAt(c);


            }

        }

        public void imprimir() {


            Console.WriteLine();



        }



    }
}
