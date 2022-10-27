LinkedList<int> numeros = new LinkedList<int> ();


foreach (int numero in new int[] { 10, 8, 6, 4, 2, 0 }) 
numeros.AddFirst(numero);

foreach (int numero in numeros)
    Console.WriteLine(numero);

numeros.Remove(6);
LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);
numeros.AddFirst(nodoImportante);

for(LinkedListNode<int> nodo = numeros.First;nodo!= null;nodo = nodo.Next)
    Console.WriteLine(nodo.Value);

string[] colores= { "negro", "amarillo","verde","azul","violeta","plata" };

string[] colores2 = { "oro", "blanco", "cafe", "azul", "gris" };
LinkedList<string> lista1 = new LinkedList<string> ();
foreach(string color in colores     )
    lista1.AddLast(color);

LinkedList<string> lista2 = new LinkedList<string>();
Concatenar(lista1, lista2);
ImprimirLista(lista1);

void ImprimirLista<E>(LinkedList<E> lista1)
{
    Console.WriteLine("Lista enlacada :");
    foreach(E valor in lista1)
        Console.Write("{0}",valor);
    Console.WriteLine();
}
Console.WriteLine("\n Convirtiendo la cadena de lista1 a mayusculas \n");
CadenasMayusculas(lista1);
ImprimirLista(lista1);


Console.WriteLine("\n Eliminando las cadenas entre NEGRO y CAFE \n");
EliminarElemento(lista1,"NEGRO","CAFE");

ImprimirListaInversa(lista1);

void ImprimirListaInversa<E>(LinkedList<E> lista)
{
    Console.WriteLine("Lista invertida: ");
    LinkedListNode < E >= nodoActual = lista.Last;
    while(nodoActual != null)
    {
        Console.WriteLine();
    }
}

void EliminarElemento<E>(LinkedList<E> lista,E elementoIncial, E elementofinal)
{
    LinkedListNode<E> nodoActual = lista.Find(elementoInicial);
    LinkedListNode<E> nodoFinal = lista.Find(elementoFinal);
    while ((nodoActual.Next != null)&&(nodoActual.Next!= nodoFinal))
    {
        lista.Remove(nodoActual);
    }

}

void CadenasMayusculas(LinkedList<string> lista)
{
    LinkedListNode<string> nodoactual = lista.First;
    while (nodoactual != null)
    {
        string color = nodoactual.Value;
        nodoactual.Value = color.ToUpper();

        nodoactual = nodoactual.Next;
    }
}

void Concatenar<E>(LinkedList<E> lista1, LinkedList<E> lista2)
{
    foreach (E valor in lista2)
        lista1.AddLast(valor);
}
