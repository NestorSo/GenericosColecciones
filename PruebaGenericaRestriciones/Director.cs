using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGenericaRestriciones
{
    internal class Director : IparaEmpleados
    {
        private double salario;

        public Director(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
           return salario;
        }
    }
}
