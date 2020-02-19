using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.UAM.O0P
{
    public class agregarCliente_Doctor : Operaciones
    {

        List<Persona> clientes_doc = new List<Persona>();
      
        public virtual void Agregar(Persona obj)
        {
            if (obj.Nombre.Equals("Cliente"))
            {

                clientes_doc.Add(obj);


            }
            else {


                clientes_doc.Add(obj);
                
            }

           


        }



        public void quemarClientes() {

            for (int i = 0; i <= 9; i++)
            {

                Cliente c = new Cliente();

                c.Nombre = "Cliente: " + i;
                c.Cedula =  i+i+i;
                c.Apellido = "Sanenz" + i;
                c.Correo = "@";
                c.Id = i;
                c.Telefono = 22698867;

                Agregar(c);


            }

            
        }


        public void quemarDoctores() {

            for (int i = 0; i <= 2; i++) {


                Doctor d = new Doctor();
                d.Id = i;
                d.Nombre = "Cliente: " + i;
                d.Apellido = "Lopez: " + i;
                d.Cedula = i + i + i + i;
                d.Especialidad = "Consulta Externa";


                Agregar(d);



            }

        }

     



    }
}
