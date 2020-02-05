using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class DVD : Ireproductores
    {

        private int id;
        private String nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public DVD()
        {
        }

        public DVD(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public void play()
        {
            Console.WriteLine("play");
        }

        public void stop()
        {
            Console.WriteLine("stop");
        }

        public void forward()
        {
            Console.WriteLine("forward");
        }

        public void rewind()
        {
            Console.WriteLine("rewind");
        }
    }
}
