using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLINQ
{
    internal class Empresa
    {
        public int id { get; set; } 
        public string nombre { get; set; }
        public override string ToString()
        {
            return string.Format("Empresa{0} con {1} ", nombre,id);
        }

    }
}
