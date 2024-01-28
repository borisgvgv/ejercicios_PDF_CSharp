/*
(5.5.3) Crea una función "EsPrimo", que reciba un número y devuelva el valor
booleano "true" si es un número primo o "false" en caso contrario.
*/

using System;
class Program
{
    static void EsPrimo(int numero)
    {

        bool valor = true; 
        for (int i = numero - 1; i > 1; i--)
            
            if (numero % i == 0)
            {
                valor = false;
            }

            if(valor){
                Console.WriteLine("El número {0} es primo", numero);
            }  
            else
            Console.WriteLine("El número {0} no es primo", numero);
    }
    static void Main()
    {
        Console.WriteLine("Introduce un número para saber si es primo");
        int numero = Convert.ToInt32(Console.ReadLine());
        EsPrimo(numero);
    }
}