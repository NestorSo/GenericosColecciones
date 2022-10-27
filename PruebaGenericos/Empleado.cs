using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGenericos
{
    internal class Empleado
    {
        private double salario;

        public Empleado(double salario)
        {
            this.salario = salario;
        }
        public double Salario { get => salario; set => salario = value; }
    }
}
