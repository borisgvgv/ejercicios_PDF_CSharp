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

    static void NumeroMayor(ref int a, ref int b)
    {
        int mayor = a;
        if (b > a)
        {
            mayor = b;
        }
        Console.WriteLine("El número mayor es {0}", mayor);
        
    }

    static void Intercambiar(ref int x, ref int y){
        int a = y;
        int b = x;
        Console.WriteLine("Ahora a es  {0}", a);
        Console.WriteLine("Ahora b es  {0}", b);
    }

    static void Main()
    {
        int n = 5;
        Console.WriteLine("n vale {0}", n);
        Duplicar(ref n);
        Console.WriteLine("Ahora n vale {0}", n);

        int num1 = 5, num2 = 7;
        NumeroMayor(ref num1, ref num2);
        Intercambiar(ref num1, ref num2);
    }
}