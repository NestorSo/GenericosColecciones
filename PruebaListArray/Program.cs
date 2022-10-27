using System.Collections;

BitArray miArreglo = new BitArray(new byte[] {1,2,4,8,16});
Console.WriteLine( miArreglo.Count);
MuestraMiArrgelo(miArreglo);
Console.WriteLine("------");
// Obtenemos un bit en particular 
Console.WriteLine(miArreglo.Get(4));
Console.WriteLine("------");

//Ponemos algo en particular
miArreglo.Set(3, true);
MuestraMiArrgelo(miArreglo);
Console.WriteLine(miArreglo.Get(3));
Console.WriteLine("------");

// clonamos el bit array 
BitArray arreglo2 = (BitArray)miArreglo.Clone();
MuestraMiArrgelo(arreglo2);
Console.WriteLine("------");
//invertimos el arreglo
arreglo2 = arreglo2.Not();
MuestraMiArrgelo(arreglo2);
//creamos otro array 
BitArray arreglo3 = new BitArray(new byte[] {5,6,7,8,9,12,13});
MuestraMiArrgelo(arreglo3, "Arreglo 3");
Console.WriteLine("------");
//hacemos or entre arreglos 
arreglo3.Or(miArreglo);
MuestraMiArrgelo(miArreglo, "miArreglo");
MuestraMiArrgelo(arreglo3, "Arreglo 3");
Console.WriteLine("=========");

//Hacemos and
MuestraMiArrgelo(miArreglo, "mi arreglo");
MuestraMiArrgelo(arreglo3, "arreglo3");


arreglo3.And(miArreglo);
MuestraMiArrgelo(arreglo3, "arreglo 3");
Console.WriteLine("=========");
//Hacemos xdr
arreglo3 = new BitArray(new byte[] { 5, 6, 7, 8, 9, 10, 11, });


void MuestraMiArrgelo(BitArray pArreglo, string pNombre = "")
{
    int c = 0;
    Console.Write("{0}\t",pNombre);
    foreach(bool b in pArreglo)
    {
        c++;
        if(b)
            Console.Write("1");

        else
            Console.Write("0");

        if (c%8==0)
            Console.Write(",");
    }

    Console.WriteLine();
}