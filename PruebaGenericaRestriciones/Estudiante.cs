using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGenericaRestriciones
{
    internal class Estudiante
    {
        private double nota;

        public Estudiante(double nota)
        {
            this.nota = nota;
        }
        public double Nota { get { return nota; } } 
    }
}
