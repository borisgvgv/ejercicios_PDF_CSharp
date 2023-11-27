// Ejemplo_04_04_03a.cs
// Cadenas de texto (3: longitud)
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_04_04_03a
{
    static void Main()
    {
        string saludo = "Hola";
        int longitud = saludo.Length;
        Console.WriteLine("La longitud de {0} es {1}", saludo, longitud);
        for (int i = 0; i < saludo.Length; i++)
        {
            Console.WriteLine("La letra {0} es {1}", i, saludo[i]);
        }

        Console.WriteLine("La tercera letra de {0} es {1}", saludo, saludo[2]);

    }
}