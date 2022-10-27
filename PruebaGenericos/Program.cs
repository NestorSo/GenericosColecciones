using PruebaGenericos;

AlmacenObjetos archivos = new AlmacenObjetos(4);
archivos.Agregar("Luisa");
archivos.Agregar("Cesar");
archivos.Agregar("Eloisa");
archivos.Agregar("Katherine");
archivos.Agregar("Alvaro");

//archivos.Agregar(new Empleado(1500));
//archivos.Agregar(new Empleado(2000));
//archivos.Agregar(new Empleado(5000));
//archivos.Agregar(new Empleado(600));

//Empleado nombrePersona = (Empleado)archivos.GetElemento(2);
//Console.WriteLine(nombrePersona.Salario);

string nombrePersona = (string)archivos.GetElemento(2);
Console.WriteLine(nombrePersona);

AlmacenObjetos2<Empleado> empleados = new AlmacenObjetos2<Empleado>(4);
empleados.Agregar(new Empleado(1500));
empleados.Agregar(new Empleado(5000));
empleados.Agregar(new Empleado(400));
empleados.Agregar(new Empleado(20));

Empleado salrioEmpleado = empleados.GetElemento(2);
Console.WriteLine(salrioEmpleado.Salario);