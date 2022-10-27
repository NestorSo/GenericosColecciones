using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLINQ
{
    internal class Empleado
    {
        public int id { get; set; } 
        public string nombre { get; set; }
        public string cargo { get; set; }
        public int salario { get; set; }    

     //clave foranea
     public int Empresaid { get; set; }
        public override string ToString()
        {
            return string.Format("Empleado{0} con {1}, cargo {2} con salario {3}"+
                "pertenece a {4}", nombre, id, cargo, salario, Empresaid);
        }


    }
}
