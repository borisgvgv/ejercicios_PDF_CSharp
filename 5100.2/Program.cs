using System;

/*
(5.10.3) Crea un programa que emplee recursividad para calcular un número de la
serie Fibonacci (en la que los dos primeros elementos valen 1, y para los restantes,
cada elemento es la suma de los dos anteriores).
*/

class Program
{
    public static int Fibonacci(int n)
    {
        if (n == 0)
        {
            return n;
        }
        else if (n == 1 || n == 2)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    public static int PedirNumero()
    {
        System.Console.Write("Numero: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void Main()
    {
        System.Console.WriteLine(Fibonacci(PedirNumero())); ;
    }
}


