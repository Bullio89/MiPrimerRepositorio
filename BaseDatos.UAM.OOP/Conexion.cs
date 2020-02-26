using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BaseDatos
{
    public class Conexion
    {

        private string connectionString = "Data Source=LAPTOP-GPOJCE9J;Initial Catalog=Progra3;User ID=userPR3;Password=Carlos89";

        public void ConexionSQlNoQuery(string sql)
        {

            SqlConnection cnn;
            SqlCommand cmd;
           

            cnn = new SqlConnection(connectionString);

            try

            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                //SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();
                Console.WriteLine(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
            }
            // Closing the connection  
            finally
            {
                cnn.Close();
            }
        }

        public SqlDataReader ConexionSQlQuery(string sql)
        {

            SqlConnection cnn;
            SqlCommand cmd;


            cnn = new SqlConnection(connectionString);

            try

            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                //cmd.ExecuteNonQuery();
                SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();
                if (resultado.HasRows)
                {

                    cnn.Close();
                    return resultado;


                }
                else {
                    cnn.Close();

                    return null;

                }
                

                Console.WriteLine(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
                return null;
            }
            
            // Closing the connection  
            finally
            {
                cnn.Close();
               
            }
        }

        public void ConexionADO(string Sql)
        {
            try
            {
                string querystring = "Select * from Items";
                SqlDataAdapter adapter = new SqlDataAdapter(Sql, connectionString);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
            }

        }

    }
}
