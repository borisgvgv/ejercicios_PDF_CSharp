using System;

/*
Máximo común divisor de dos números, aplicando algoritmo de Euclides
*/

class Program
{

    public static int PedirNumero1()
    {
        System.Console.Write("N1: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int PedirNumero2()
    {
        System.Console.Write("N2: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int MaximoComunDivisor(int n1, int n2)
    {
        if (n2 == 0)
        {
            return n1;
        }
        else
        {
            return MaximoComunDivisor(n2, n1 % n2);
        }
    }
    static void Main()
    {
        System.Console.WriteLine(MaximoComunDivisor(PedirNumero1(), PedirNumero2()));
    }
}