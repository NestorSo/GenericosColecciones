using System.Collections;
Stack miStack = new Stack(); //lifo
//Agregamos elementos 
miStack.Push("manzana");
miStack.Push("pera");
miStack.Push("ciruela");
miStack.Push("melon");
miStack.Push("mango");

//iteramos 
foreach(string fruta in miStack)
    Console.WriteLine("->{0}",fruta);
Console.WriteLine("-----------");

//Usamos el pop 
Console.WriteLine(miStack.Pop());
foreach (string fruta in miStack)
    Console.WriteLine("->{0}", fruta);
Console.WriteLine("-----------");

//usamos peek
Console.WriteLine(miStack.Peek());
foreach (string fruta in miStack)
    Console.WriteLine("->{0}", fruta);
Console.WriteLine("-----------");
//cantidad elemento 
Console.WriteLine(miStack.Count);
Console.WriteLine("-----------");
