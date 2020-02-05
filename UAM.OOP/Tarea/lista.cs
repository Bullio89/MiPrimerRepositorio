using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class lista : Icrud<Ireproductores>
    {

        List<Ireproductores> list = new List<Ireproductores>();

        public Ireproductores buscar(int indice)
        {
            if (indice < list.Count)
            {

                return list[indice];
            }
            else
            {
                return null;
            }
        }

        public void Eliminar(int indice)
        {
            list.RemoveAt(indice);
        }

        public void insertar(Ireproductores tipo)
        {

            list.Add(tipo);
            //Imprimir(list);

        }

        

        private void Imprimir(List<Ireproductores> repro)
        {
            Console.WriteLine("");
            foreach (var re in repro)
            {
                
                Console.WriteLine(repro + " ");
            }
        }


    }
}
