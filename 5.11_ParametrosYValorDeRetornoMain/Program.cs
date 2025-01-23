// Ejemplo_05_11a.cs
// Parámetros y valor de retorno de "Main"
// Introducción a C#, por Nacho Cabanes
using System;
public class Ejemplo_05_11a
{
    public static int Main(string[] args)
    {
        //Indicamos cuantos parámetros pasamos
        Console.WriteLine("Cantidad de parámetros: {0}", args.Length);

        //Mostramos los parametros que hemos pasado 
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("El parámetro {0} es: {1}", i, args[i]);
        }

        // Si no hemos pasado ningún parametro 
        if (args.Length == 0)
        {
            Console.WriteLine("No ha indicado ningún parámetro!");
            Environment.Exit(1);
        }
        return 0;
    }
}