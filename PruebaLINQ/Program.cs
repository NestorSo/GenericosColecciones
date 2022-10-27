//1. obtener origen de datos 
int[] numeros = new int[] {0,1,2,3,4,5,6,7};
//2. crear la consulta
//numPares es un IEnumerable<int>
IEnumerable<int> numPares = from num in numeros
                            where (num % 2) == 0
                            select num;
//3. ejecutar la consulta 
foreach (int num in numPares)
{
    Console.Write("{0,1} ",num);
}    
