using System.Collections;
Queue miQ= new Queue();//FIFO

// Adicionamos objetos 
miQ.Enqueue("Manzana");
miQ.Enqueue("narajna");
miQ.Enqueue("pera");
miQ.Enqueue("sandia");
miQ.Enqueue("melon");
//Iteramos 
foreach(string fruta in miQ)
    Console.WriteLine("-> {0}",fruta);
// obtenemos el objeto 
Console.WriteLine("dequeue {0}",miQ.Dequeue());
Console.WriteLine("dequeue {0}",miQ.Dequeue());

foreach (string fruta in miQ)
    Console.WriteLine("despues de dequeue-> {0}", fruta);
Console.WriteLine("-----------------");

//Adicionamos
miQ.Enqueue("mango");
miQ.Enqueue("jicara");

//observamos el objeto 
Console.WriteLine("Peek {0}", miQ.Peek());
foreach (string fruta in miQ)
    Console.WriteLine("despues de dequeue-> {0}", fruta);
Console.WriteLine("-----------------");
//conteo de objetos 
Console.WriteLine(miQ.Count);
Console.WriteLine("-----------------");
//verficamos si existe 
Console.WriteLine(miQ.Contains("mango"));
Console.WriteLine(miQ.Contains("limon"));