using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGenericaRestriciones
{
    internal class AlmacenEmpleados<T> where T : IparaEmpleados
    {

    
    
        private T[] datosElementos;
        private int i = 0;

        public AlmacenEmpleados(int j)
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
