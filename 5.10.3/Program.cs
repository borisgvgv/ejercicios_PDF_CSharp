/*
Crea un programa que emplee recursividad para calcular un número de la
serie Fibonacci (en la que los dos primeros elementos valen 1, y para los restantes,
cada elemento es la suma de los dos anteriores).
*/

using System;
class Program
{

    public static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return Fibonacci(n - 1) + Fibonacci(n - 2); 
        // Lo que se suma es el resultado que devuelve cada función no la resta del número como tal
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 
        // Por ejemplo para el 6 estariamos hablando del 8, por lo que se suman 5 y 3 = 8

    }
    static void Main()
    {
        Console.WriteLine("Introduce un número para calcular su  fibonacci");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Fibonacci es = {Fibonacci(num)}");


    }
}