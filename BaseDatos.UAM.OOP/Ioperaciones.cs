using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public interface Ioperaciones<T>
    {

        void Insertar(T item);

        T buscar(int id);

        List<T> buscarTodos();

        void modificar(T item);

        void eliminar(T item);

        


    }
}
