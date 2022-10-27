using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGenericos
{
    internal class AlmacenObjetos
    {
        private Object[] datosElementos;
       private int i = 0;

        public AlmacenObjetos( int j)
        {
            datosElementos = new Object[j];
            
        }
        public void Agregar(Object obj)
        {
            datosElementos[i] = obj;
            i++;

        }
        public Object GetElemento(int i )
        {
            return datosElementos[i];
        }
    }
}
