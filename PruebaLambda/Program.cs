
List<int> numeros = new List<int>();
numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
//Hacemos uso de la expresion lambda 
//List< int >numerosPares = numeros.FindAll(x=> (x% 2 == 0)); 


List<int> numerosPares = numeros.FindAll(x=>
{
    if (x % 2 == 0)
    {
        Console.WriteLine("Un par");
        return true;
    }
    else
    {
        Console.WriteLine("Un impar");

        return false;
    }
});
foreach (int numero in numerosPares)
    Console.WriteLine(numero);

numerosPares.ForEach(n =>
{
    Console.Write("\nEl numero par es: ");
   Console.WriteLine(n);
});


/*****************************************************/

//OperacionesMatematicas operacion = new OperacionesMatematicas(Suma);
OperacionesMatematicas operacion = new OperacionesMatematicas((num1,num2) =>num1+ num2);
Console.WriteLine("-----------------");
Console.WriteLine(operacion(4,7));

int Suma(int num1,int num2)
{
    return num1 + num2;
}

delegate int OperacionesMatematicas(int num1,int num2);