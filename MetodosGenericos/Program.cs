

    int[] arregloInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20 };
    double[] arregloDouble = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20 };
    char[] arregloChar = { 'H', 'O', 'L', 'A' };

    Console.WriteLine("El arreglo arregloint contiene");
    ImprimirArreglo(arregloInt);

    Console.WriteLine("El arreglo arreglodouble contiene");
    ImprimirArreglo(arregloDouble);

    Console.WriteLine("El arreglo arreglochar contiene");
    ImprimirArreglo(arregloChar);


 void ImprimirArreglo<E>(E[] arregloEntrada)
{

    foreach (E elemento in arregloEntrada)
        Console.WriteLine(elemento + " ");
    Console.WriteLine("\n");
}
