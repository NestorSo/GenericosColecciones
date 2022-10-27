using System;
using System.Text.RegularExpressions;
using System.Collections;



Hashtable tabla = RecolectarPalabras();

{
    MostrarHashtable(tabla);
    return;
}
Hashtable RecolectarPalabras()
{
    Hashtable tabla= new Hashtable();
    Console.WriteLine("Escriba la cadena: ");
    string entrada =Console.ReadLine();
    string[] palabras = Regex.Split(entrada,@"\s+");
    foreach (string palabra in palabras)
    {
        string clavePalabra= palabra.ToLower();
        if (tabla.ContainsKey(clavePalabra))
        {
            tabla[clavePalabra] = (int)tabla[clavePalabra] + 1;
        }
        else
        tabla.Add(clavePalabra, 1);
    }
    return tabla;
}

void MostrarHashtable(Hashtable tabla)
{
    Console.WriteLine("\nEl objetvo hashtable contiene; \n{0,-12}{1,-12}","clave: ","valor:");
    foreach(object clave in tabla.Keys)
        Console.WriteLine("{0,-12}{1,-12}",clave,tabla[clave]);
    Console.WriteLine( "\n tamaño: {0}",tabla.Count);
}