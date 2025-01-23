using System;
class Program
{
    public static int Signo(int n1)
    {
        if (n1 == 0)
        {
            return 0;
        }
        else if (n1 > 0)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }

    public static int PedirNumero1()
    {
        System.Console.Write("Numero: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void Main()
    {
        System.Console.WriteLine($"Valor devuelto: {Signo(PedirNumero1())}");
    }
}