using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGenericos
{
    internal class AlmacenObjetos2<T>
    {
        private T[] datosElementos;
        private int i = 0;

        public AlmacenObjetos2(int j)
        {
            datosElementos = new T[j];

        }
        public void Agregar(T obj)
        {
            datosElementos[i] = obj;    
            i++;

        }
        public T GetElemento(int i)
        {
            return datosElementos[i];
        }
    }
}
