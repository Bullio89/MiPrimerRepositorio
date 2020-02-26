using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    class Program
    {
        static void Main(string[] args)
        {

            Conexion con = new Conexion();

            con.ConexionSQlQuery("select * from Persona");
            con.ConexionADO("select * from Persona");



            Console.ReadKey();

        }
    }
}
