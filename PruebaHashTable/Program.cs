using System.Collections;

Hashtable openWith = new Hashtable();
//Adicionamos elementos
openWith.Add("txt", "notepad.exe");
openWith.Add("bmp", "paint.exe");
openWith.Add("dib", "paint.exe");
openWith.Add("rtf", "wordpad.exe");
//Mostramos los elementos 


foreach(DictionaryEntry elemento in openWith)
    Console.WriteLine("({0},{1})", elemento.Key,elemento.Value);

//Intentamos agregar un valor repetido 
//openWith.Add("txt","Winword.exe");

Console.WriteLine("-------");
//cantidad de elementos
Console.WriteLine(openWith.Count);
Console.WriteLine("-------");
//obtenemos el elemento de determinada llave 
Console.WriteLine(openWith["txt"]);
Console.WriteLine(openWith["xls"]);
Console.WriteLine("-------");
//colocamos elmento en una llave 
openWith["txt"] = "Winword.exe";
openWith["txt"] = "excel.exe";// esto tambien adiciona
foreach (DictionaryEntry elemento in openWith)
    Console.WriteLine("({0},{1})", elemento.Key, elemento.Value);
Console.WriteLine("-------");
//Verificamos si hay un elemento 
Console.WriteLine(openWith.Contains("xls"));
Console.WriteLine(openWith.Contains("ppt"));
Console.WriteLine("-------");

//Eliminando elemento 
openWith.Remove("xls");
foreach (DictionaryEntry elemento in openWith)
    Console.WriteLine("({0},{1})", elemento.Key, elemento.Value);
Console.WriteLine("-------");
foreach (string llave  in openWith.Keys)
    Console.WriteLine(llave);
Console.WriteLine("-------");

foreach (string value in openWith.Values)
    Console.WriteLine(value);