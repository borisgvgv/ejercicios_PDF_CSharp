// Ejemplo_05_10a.cs
// Parámetros y valor de retorno de "Main" (1)
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_05_10a
{
    static int Main(string[] args)
    {

Console.WriteLine("Parámetros: {0}", args.Length);
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("El parámetro {0} es: {1}",
            i, args[i]);
        }
        if (args.Length == 0)
        {
            Console.WriteLine("No ha indicado ningún parámetro!");
            Environment.Exit(1);
        }
        return 0;

    }
}