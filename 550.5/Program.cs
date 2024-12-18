using System;
class Program
{
    public static string PedirNumero()
    {
        System.Console.Write("Número: ");
        return Console.ReadLine();
    }


    public static int Suma(string n)
    {
        int r = 0;
        for (int i = 0; i < n.Length; i++)
        {
            r += Convert.ToInt32(n[i].ToString());
        }

        return r;
    }

    static void Main()
    {
        System.Console.WriteLine($"La suma del número añadido es: {Suma(PedirNumero())}");
    }
}