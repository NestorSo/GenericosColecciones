using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLINQ
{
    internal class ControlEmpleadoEmpresa
    {
        public List<Empresa> ListaEmpresas;
        public List<Empleado> ListaEmpleados;
        public ControlEmpleadoEmpresa()
        {
            ListaEmpresas = new List<Empresa>();
            ListaEmpleados = new List<Empleado>();

            ListaEmpresas.Add(new Empresa{ id =1 ,nombre="Google"});   
            ListaEmpresas.Add(new Empresa{ id =1 ,nombre="Microsoft"});   
            ListaEmpresas.Add(new Empresa{ id =1 ,nombre="Sony"});   
            ListaEmpresas.Add(new Empresa{ id =1 ,nombre="Apple"});
            

            ListaEmpleados.Add(new Empleado{ id =1 ,nombre="Alvaro Garay", cargo="Borracho",});   
            ListaEmpleados.Add(new Empleado{ id =1 ,nombre="Apple"});   
              
        }
    }
}
