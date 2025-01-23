// Ejemplo_05_07c.cs
// Parámetros "out"
// Introducción a C#, por Nacho Cabanes
using System;
public class Ejemplo_05_07c
{
    public static void DosPrimerasLetras(string cadena,
    out char l1, out char l2)
    {
        l1 = cadena[0];
        l2 = cadena[1];
    }
    public static void Main()
    {
        char letra1, letra2;
        DosPrimerasLetras("Nacho", out letra1, out letra2);
        Console.WriteLine("Las dos primeras letras son {0} y {1}",
        letra1, letra2);
    }
}