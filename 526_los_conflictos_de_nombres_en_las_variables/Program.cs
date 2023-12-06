// Ejemplo_05_06a.cs
// Dos variables locales con el mismo nombre
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_05_06a
{
    
    static int CambiaN()
    {
        int n = 7;
        return n++;
    }
    static void Main()
    {
        int n = 5;
        Console.WriteLine("n vale {0}", n);
        Console.WriteLine("Ahora n vale {0} porque toma el valor de la variable declarada en la función.", n);
        Console.WriteLine("Ahora n vale {0} porque toma el valor de la variable declarada en la función.", CambiaN());
    }
}