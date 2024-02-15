using System;

class Program
{
    public static void ImprimirX(int x)
    {
        if (x >= 1)
        {
            ImprimirX(x - 1);
            Console.Write($"{x} ");

        }
    }
    public static void InvertirX(int x)
    {
        if (x >= 1)
        {
            Console.Write($"{x} ");
            ImprimirX(x - 1);
        }

    }

    public static string ImprimirPalindormo(string frase)
    {
        if (frase.Length < 1)
            return frase;


        return ImprimirPalindormo(frase.Substring(1)) + frase[0];
    }


    static void Main()
    {

        int x = 5;
        string frase = "LAZORRAELABAD";

        ImprimirX(x);
        Console.WriteLine();
        InvertirX(x);
        Console.WriteLine();
        Console.WriteLine(ImprimirPalindormo(frase) + frase.Substring(1));
    

    }

}
