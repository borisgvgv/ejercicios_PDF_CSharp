// Ejemplo_05_07_01a.cs
// Modificar una variable recibida como parámetro - acercamiento
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_05_07_01a
{
    static void Duplicar(int x)
    {
        Console.WriteLine(" El valor recibido es {0}", x);
        x = x * 2;
        Console.WriteLine(" y ahora vale {0}", x);
    }
    static void Main()
    {
        int n = 5;
        int y = 6;
        Console.WriteLine("n vale {0}", n);
        Duplicar(n); //Aquí pasamos valor a la función n = 5
        Console.WriteLine("Ahora n vale {0}", n );
        Duplicar(y);
    }
}
