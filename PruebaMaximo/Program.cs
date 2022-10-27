

Console.WriteLine("El maximo de {0},{1} y {2} es {3}\n",
    3,4,5,Maximo(3,4,5));
Console.WriteLine("El maximo de {0},{1} y {2} es {3}\n",
    3.3, 9.9, 5.8, Maximo(3.3, 9.9, 5.8));
Console.WriteLine("El maximo de {0},{1} y {2} es {3}\n",
    "pera", "manzana", "naranja", Maximo("pera", "manzana", "naranja"));


T Maximo<T>(T x, T y, T z) where T : IComparable<T>
{
    T max= x;// Supone que al principio x es el mayor 
    //compaea y co max 
    if (y.CompareTo(max) > 0)
        max = y;// y es el mayor
    //Compara z con max
    if(z.CompareTo(max) > 0)
        max= z;//z es el mayor 
    return max;
}