using System;

class Program
{

    public static string PedirPalabra()
    {
        System.Console.Write("Palabra: ");
        return Console.ReadLine();
    }
    public static char PedirLetra()
    {
        System.Console.Write("Letra: ");
        return Convert.ToChar(Console.ReadLine());
    }

    public static int ContadorDeLetras(string p, char l)
    {
        
        int contador = 0;
        for (int i = 0; i < p.Length; i++)
        {
            if (l == p[i])
            {
                contador++;
            }
        }
        return contador;
    }
    static void Main()
    {
        Console.Clear();
        System.Console.WriteLine($"La letra aparece: {ContadorDeLetras(PedirPalabra(), PedirLetra())} veces en la palabra");
    }
}