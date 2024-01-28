/*
(5.4.2) Crea una función "Menor" que calcule el menor de dos números enteros
que recibirá como parámetros. El resultado será otro número entero.
*/


using System;
class Program
{
    static float Menor(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    static void Main()
    {
        Console.WriteLine("Introduce un número ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce otro número ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("El menor de los dos números es {0}", Menor(a, b));

    }
}