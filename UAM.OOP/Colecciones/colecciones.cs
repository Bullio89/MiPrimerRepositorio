using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class colecciones
    {

        public void ListaString<T>()
        {
            // Create a list of strings.
            var salmons = new List<T>();


            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");
            salmons.Add("chinook");

            // Iterate through the list.
            Imprimir(salmons);
            // Output: chinook coho pink sockeye

            salmons.Remove("coho");

            // Iterate through the list.
            Imprimir(salmons);

            try
            {
                salmons.Insert(2, "Nuevo");
                Console.WriteLine(" ");
                Imprimir(salmons);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error {0}", ex.Message);
            }


            Console.WriteLine("\n RemoveAt");
            salmons.RemoveAt(2);
            Imprimir(salmons);

            try
            {
                Console.WriteLine("\n []");
                var salmon = salmons[2];
                Console.WriteLine("Salmon = {0}", salmon);

                Console.WriteLine("\n IndexOf");
                var salmon1 = salmons.IndexOf("sockeye");
                Console.WriteLine("Salmon1 = {0}", salmon1);

                Console.WriteLine("\n Contains");
                var existe = salmons.Contains("chinook");
                Console.WriteLine("Existe = {0}", existe);

                Console.WriteLine("\n Contains");
                var contar = salmons.Count();
                Console.WriteLine("Cantidad en la lista = {0}", contar);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error {0}", ex.Message);
            }





        }

        private void Imprimir(List<string> salmons)
        {
            Console.WriteLine("");
            foreach (var salmon in salmons)
            {
                Console.WriteLine(salmon + " ");
            }
        }
    }
}






    
