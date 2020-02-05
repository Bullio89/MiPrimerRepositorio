using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Persona persona = new Persona();
            //int telefono = 88221672;
            //persona.Telefono = telefono;
            //int telefono2 = persona.Telefono;

            //int id = persona.Identificacion;
            ////persona.Identificacion = 12324;

            //persona._correo = "@";

            //Estudiante estudiante = new Estudiante();
            //Persona persona1 = new Estudiante();
            //persona1.Telefono = 1;

            //PersonaDeportesCAbst personaDeportesC = new DeporteCR();

            //DeporteCR deporteCR = new DeporteCR();
            //DeporteUSA deporteUSA = new DeporteUSA();

            //deporteCR.Basket();
            //deporteUSA.Basket();

            //deporteCR.Futbol();
            //deporteUSA.Futbol();

            //deporteCR.Tennis();
            //deporteUSA.Tennis();

            //deporteCR.BaseBall();
            //deporteUSA.BaseBall();

            //Console.ReadKey();

            //MyGenericClass<int> myGenericClass = new MyGenericClass<int>(1);

            //myGenericClass.genericMethod(4234);


            //MyGenericClass<String> myGenericClassString = new MyGenericClass<String>("Valor al atributo");

            //myGenericClassString.genericMethod("Valor al parametro");

            //Console.ReadKey();


            //colecciones colecciones = new colecciones();

            //colecciones.ListaString();

            //Console.ReadKey();

            Ireproductores reproductor = new VHS();//interfaz se puede comportar como cualquiera de sus hijos yb ella no se puede instanciar por si misma, de esta manera se hace polimorfismo

            lista ejemplo = new lista();

            VHS vHS = new VHS(1, "VHS");

            ejemplo.insertar(vHS);
            ejemplo.insertar(new DVD(1, "DVD"));
            ejemplo.insertar(new Netflix() { Id = 3, Nombre = "Netlix" });
            //Console.ReadKey();

            var item = ejemplo.buscar(0);

            if (item is DVD)
            {

                Console.WriteLine(((DVD)item).Id);

            }
            else
            {
                if (item is VHS)
                {

                    Console.WriteLine(((VHS)item).Id);

                }
                else
                {
                    if (item is Netflix)
                    {

                        Console.WriteLine(((Netflix)item).Id);
                    }
                }


            }

            Console.ReadKey();


        }
    }
}
