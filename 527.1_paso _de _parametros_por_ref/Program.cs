// Ejemplo_05_07_02a.cs
// Modificar una variable recibida como parámetro - correcto
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_05_07_02a
{
    static void Duplicar(ref int x)
    {
        Console.WriteLine(" El valor recibido vale {0}", x);
        x = x * 2;
        Console.WriteLine(" y ahora vale {0}", x);
    }
    static void Main()
    {
        int n = 5;
        Console.WriteLine("n vale {0}", n);
        Duplicar(ref n);
        Console.WriteLine("Ahora n vale {0}", n);
    }
}