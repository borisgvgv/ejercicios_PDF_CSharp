using System;
class Program
{
    public static int Potencia(int n, int p)
    {
        if (p == 0)
        {
            return 1;
        }
        else
        {
            return Convert.ToInt32(n * Potencia(n, p - 1));
        }
    }

    public static int PedirNumero()
    {
        System.Console.Write("Número: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int PedirPotencia()
    {
        System.Console.Write("Potencia: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    static void Main()
    {

        System.Console.WriteLine(Potencia(PedirNumero(), PedirPotencia()));

    }
}