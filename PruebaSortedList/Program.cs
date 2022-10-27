using System.Collections;

SortedList miLista = new SortedList();
//Adicionamos 
miLista.Add(768, "Honda");
miLista.Add(567, "Hyundai");
miLista.Add(987, "Toytoa");
miLista.Add(123, "Mazda");

//Iteramos

foreach(DictionaryEntry elemento in miLista)
    Console.WriteLine("{0},{1}",elemento.Key,elemento.Value);
Console.WriteLine("-----------------------");
//Cantidad de elementos 
Console.WriteLine(miLista.Count);

//Contiene elemento 
Console.WriteLine(miLista.Contains(768));
Console.WriteLine(miLista.Contains(567));
Console.WriteLine(miLista.ContainsValue("Mazda"));
Console.WriteLine(miLista.ContainsKey(123));
Console.WriteLine("-----------------------");
//Obtenemos elemento por indice 
Console.WriteLine(miLista.GetKey(2));
Console.WriteLine(miLista.GetByIndex(2));
