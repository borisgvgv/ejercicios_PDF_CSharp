using System;

class Program
{
 static void Main()
    {
        Console.Write("Ingrese el índice de la serie Fibonacci: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Por favor, ingrese un índice no negativo.");
        }
        else
        {
            int resultado = CalcularFibonacci(n);
            Console.WriteLine($"El número en la posición {n} de la serie Fibonacci es: {resultado}");
        }
    }

    static int CalcularFibonacci(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
        }
    }
}



