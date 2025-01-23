using System;

class Program
{
    public static int PedirNumero()
    {
        System.Console.Write("Numero: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static void MostrarTabla(int n)
    {
        for (int i = 1; i < 11; i++)
        {
            System.Console.WriteLine($"{n} * {i} = {n * i}");
        }
    }

    static void Main()
    {
        MostrarTabla(PedirNumero());
    }
}
