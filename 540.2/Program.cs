using System;
class Program
{
    public static int Menor(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n2;
        }
        else
        {
            return n1;
        }
    }

    public static int PedirNumero1()
    {
        System.Console.Write("Numero 1: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int PedirNumero2()
    {
        System.Console.Write("Numero 2: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    static void Main()
    {
        System.Console.WriteLine($"El número menor es el: {Menor(PedirNumero1(), PedirNumero2())}");
    }
}