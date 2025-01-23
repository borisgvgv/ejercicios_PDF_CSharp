//Ejercicio inventado por mi

using System;

class Program
{


    public static float CalculoExponencial(float n, int exponente)
    {
        float r = 1;
        for (int i = 0; i < exponente; i++)
        {
            r *= n;
        }
        return r;
    }

    public static float PedirNumero()
    {
        System.Console.Write("Numero: ");
        return Convert.ToSingle(Console.ReadLine());
    }
    public static int PedirExponente()
    {
        System.Console.Write("Exponente: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void Main()
    {
        System.Console.WriteLine(CalculoExponencial(PedirNumero(), PedirExponente()));

    }
}