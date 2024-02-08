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
        if(n<=1){
            return 1;
        }
        return Fibonacci(n-1) + Fibonacci(n-2);
    }
    static void Main()
    {
        int num = 5;
        Console.WriteLine(Fibonacci(num));

    }
}