using PruebaGenericaRestriciones;
AlmacenEmpleados<Director> empleado1 = new AlmacenEmpleados<Director>(3);
empleado1.Agregar(new Director(1000000));
empleado1.Agregar(new Director(20));
empleado1.Agregar(new Director(300));

AlmacenEmpleados<Secretario> empleado2 = new AlmacenEmpleados<Secretario>(3);
empleado2.Agregar(new Secretario(200));
empleado2.Agregar(new Secretario(3500));
empleado2.Agregar(new Secretario(500));
