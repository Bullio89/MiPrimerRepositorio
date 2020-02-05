using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class Netflix : Ireproductores
    {

        private int id;
        private String nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }


        public Netflix() {


        }



        public Netflix(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        



        public void forward()
        {
            Console.WriteLine("forward");
        }

        public void play()
        {
            Console.WriteLine("play");
        }

        public void rewind()
        {
            Console.WriteLine("rewind");
        }

        public void stop()
        {
            Console.WriteLine("stop");
        }
    }
}
