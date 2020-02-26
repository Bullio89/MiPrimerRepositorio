using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace BaseDatos
{



    public class OperacionesPersona : Ioperaciones<Persona>
    {
        private Conexion con = new Conexion();

        public Persona buscar(int id)
        {


            string query = "SELECT * FROM Persona WHERE id =" + id;
            SqlDataReader resultado = con.ConexionSQlQuery(query);

            if (resultado != null) {


                while (resultado.NextResult())
                {


                    return new Persona(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2));


                }

            }

            return null;


        }

        public List<Persona> buscarTodos()
        {

            string query = "Select * from Persona";
            List <Persona> per = new List<Persona>();
            SqlDataReader resultado = con.ConexionSQlQuery(query);

            if (resultado != null)
            {

                while (resultado.NextResult())
                {

                    per.Add(new Persona(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2)));
                }

                return per;

            }
            else {

                return null;
            }

        }

        public void eliminar(Persona item)
        {
            string query = "delete * from Persona where id="+ item.Id;
            SqlDataReader resultado = con.ConexionSQlQuery(query);

           


        }

        public void Insertar(Persona item)
        {
            throw new NotImplementedException();
        }

        public void modificar(Persona item)
        {
            throw new NotImplementedException();
        }
    }
}
