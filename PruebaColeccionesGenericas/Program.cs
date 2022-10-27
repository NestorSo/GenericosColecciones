using PruebaColeccionesGenericas;

//List<int> valores = new List<int>();
//valores.Add(1);
//valores.Add(2);
//valores.Add(3);
//valores.Add(4);
//valores.Add(5);
//foreach (int valor in valores)
//{
//    Console.WriteLine(valor);
//}
//Console.WriteLine("---------------------");
//Console.WriteLine(valores.Contains<int>(5));
//Console.WriteLine(valores.Contains<int>(10));
//Console.WriteLine(valores.Count);
//Console.WriteLine("---------------------");
//Console.WriteLine(valores.IndexOf(4));
//Console.WriteLine("---------------------");
//valores.Insert(2,55);
//foreach (int valor in valores)
//    Console.WriteLine(valor);
//Console.WriteLine("---------------------");
//valores.Remove(2);
//valores.RemoveAt(2);
//foreach (int valor in valores)
//    Console.WriteLine(valor);
//Console.WriteLine("---------------------");
//valores.Reverse();
//foreach (int valor in valores)
//    Console.WriteLine(valor);
//Console.WriteLine("---------------------");
//valores.Sort();
//foreach (int valor in valores)
//    Console.WriteLine(valor);
//Console.WriteLine("---------------------");
//List<Punto> ListaPunto = new List<Punto>();
//ListaPunto.Add(new Punto(5, 3));
//ListaPunto.Add(new Punto(6, 8));
//ListaPunto.Add(new Punto(9, 3));
//ListaPunto.Add(new Punto(13, 4));
//foreach (Punto punto in ListaPunto)
//{
//    Console.WriteLine(punto);
//}
//Console.WriteLine("---------------------");

//ListaPunto.Insert(2,new Punto(20, 2));
//foreach (Punto punto in ListaPunto)
//{
//    Console.WriteLine(punto);
//}
//Console.WriteLine("---------------------");

//Punto[] arregloPuntos = ListaPunto.ToArray();
//for (int i = 0; i < arregloPuntos.Length; i++)
//{
//    Console.WriteLine(arregloPuntos[i]);
//}
//Console.WriteLine("---------------------");
//ListaPunto.Sort();
//foreach (Punto punto in ListaPunto)
//{
//    Console.WriteLine(punto);
//}

/***********************************************prueba Queue<T>**********************************************************/


//Queue<Punto> puntos = new Queue<Punto>();
//puntos.Enqueue(new Punto(3, 7));
//puntos.Enqueue(new Punto(7, 9));
//puntos.Enqueue(new Punto(11, 2));

// foreach(Punto punto in puntos)
//    Console.WriteLine("-> {0}",punto);
//Console.WriteLine("--------------------------");
////hacemos peek 
//Console.WriteLine("peek {0}: ",puntos.Peek());
//foreach (Punto punto in puntos)
//    Console.WriteLine("-> {0}", punto);
//Console.WriteLine("--------------------------");
////hacemos dequeue
//Console.WriteLine("Dequeue {0}",puntos.Dequeue());
//Console.WriteLine("Dequeue {0}",puntos.Dequeue());
//foreach (Punto punto in puntos)
//    Console.WriteLine("-> {0}", punto);
/***********************************************prueba Stack<T>**********************************************************/


//Stack<Punto> puntos = new Stack<Punto>();
//puntos.Push(new Punto(3, 7));
//puntos.Push(new Punto(7, 9));
//puntos.Push(new Punto(11, 2));

//foreach (Punto punto in puntos)
//    Console.WriteLine("-> {0}", punto);
//Console.WriteLine("--------------------------");
////hacemos peek 
//Console.WriteLine("peek {0}: ", puntos.Peek());
//foreach (Punto punto in puntos)
//    Console.WriteLine("-> {0}", punto);
//Console.WriteLine("--------------------------");
////hacemos dequeue
//Console.WriteLine("pop {0}", puntos.Pop());
//Console.WriteLine("pop {0}", puntos.Pop());
//foreach (Punto punto in puntos)
//    Console.WriteLine("-> {0}", punto);


/***********************************************prueba linkedlisthasSet<T>**********************************************************/

HashSet<Punto> puntos = new HashSet<Punto>();
puntos.Add(new Punto(3, 7));
puntos.Add(new Punto(8, 11));
puntos.Add(new Punto(2,6 ));



/***********************************************prueba Dictionary<TKey,value>**********************************************************/
//Dictionary<string, int> edades =   new Dictionary<string, int>();
//// rellenar el diccionario 
//edades.Add("jose", 19);
//edades.Add("Alvaro", 28);
//edades.Add("Ismael", 15);
//edades["Maria"] = 20;
//edades["Pedro"] = 20;


//// recorrer el diccionario
//foreach(KeyValuePair<string, int> kvp in edades)
//    Console.WriteLine("nombre: {0} edad :{1}",kvp.Key, kvp.Value);



/***********************************************prueba sortedList<TKey,Value>**********************************************************/

SortedList<int, string> misLista = new SortedList<int, string>();
//Adicionamos 
misLista.Add(754, "Honda");
misLista.Add(123, "Toyota");
misLista.Add(583, "Nissan");

// iteramos 
foreach (KeyValuePair<int, string> kvp in misLista)
    Console.WriteLine("key: {0} value :{1}", kvp.Key, kvp.Value);