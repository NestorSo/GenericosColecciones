using System.Collections;
ArrayList colores1 = new ArrayList();
colores1.AddRange(new string[] { "magenta","rojo","blanco" });
colores1.Add("azul");
colores1.Add("verde");
colores1.Add("amarillo");
colores1.Add("cafe");
colores1.Add("celeste");
colores1.Add("morado");
colores1.Add("cyan");
Console.WriteLine("Cantidad de elementos en el arraylist es {0}",colores1.Count);
Console.WriteLine("la capacidad en el arraylist es {0}", colores1.Capacity);

for (int i = 0; i < colores1.Count; i++)
{
    Console.WriteLine("{0}",colores1[i]);
}
Console.WriteLine();
Console.WriteLine("------------------------");

foreach (string color in colores1)
{
    Console.WriteLine("{0}",color);
}
Console.WriteLine();
Console.WriteLine("------------------------");
int[] numeros = { 1, 2, 3, 4, 5, 6 };
ArrayList valores = new ArrayList();

foreach (int i in numeros)
    valores.Add(i);

//Vemos si existe el elemento en el array 
Console.WriteLine(valores.Contains(8));
Console.WriteLine(valores.Contains(2));
Console.WriteLine("------------------------");

//Insertamos en un indice en particular 
valores.Insert(2, 55);

foreach (int i in valores)
    Console.WriteLine(i);

//Remover 
valores.Remove(55);
for (int i = 0; i < valores.Count; i++)
    valores.RemoveAt(3);
Console.WriteLine("------------------------");

foreach(int i in valores)
    Console.WriteLine(i);

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

string[] colores = { "magenta", "rojo", "blanco", "azul" ,"verde"};
string[] eliminarcolor = { "rojo", "blanco" };

ArrayList lista = new ArrayList();
foreach(string color in colores)
    lista.Add(color);

ArrayList listaEliminar = new ArrayList(eliminarcolor);

Console.WriteLine("Array List: ");
MostrarInfo(lista);

EliminarColores(lista,listaEliminar);
Console.WriteLine("\nArraylist despues de llamar a eliminar colores ");
MostrarInfo(lista);

void EliminarColores(ArrayList primeraLista, ArrayList segundaLista)
{


}

void MostrarInfo(ArrayList arreglolista)
{
    foreach(object elemento in arreglolista)
        Console.WriteLine("{0}",elemento);
    Console.WriteLine("\n tamaño = {0}; capacidad={1}",arreglolista.Count,arreglolista.Capacity);

    int index = arreglolista.IndexOf("azul");
    if(index !=-1)
        Console.WriteLine("El arreglo contiene azul En el indice {0}",index);
    else
        Console.WriteLine("No se encontro el azul");

}