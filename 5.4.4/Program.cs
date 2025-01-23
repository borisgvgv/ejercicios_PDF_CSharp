using System;
class Program
{


    public static char Inicial(string p)
    {
        return p[0];
    }

    public static char UltimaLetra(string p)
    {
        return p[p.Length-1];
    }

    public static string PedirPalabra()
    {
        System.Console.Write("Palabra: ");
        return Console.ReadLine();
    }
    static void Main()
    {
        string palabra = PedirPalabra(); 
        System.Console.WriteLine($"Inicial de la palabra es: {Inicial(palabra)}");
        System.Console.WriteLine($"La última letra es palabra es: {UltimaLetra(palabra)}");


    }
}
