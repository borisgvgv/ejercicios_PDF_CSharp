/*
En algunos lenguajes, una función debe estar declarada antes de usarse. Esto no
es necesario en C#. Por ejemplo, podríamos rescribir el ejemplo 05_07b, de modo
que "Main" aparezca en primer lugar y "Duplicar" aparezca después, y seguiría
compilando y funcionando igual:
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = 5;
        System.Console.WriteLine($"n vale {n}");
        Duplicar(ref n);
        System.Console.WriteLine($"Ahora n vale {n}");

    }
    public static void Duplicar(ref int n)
    {
        System.Console.WriteLine($"El valor recibido {n} ");
        n *= 2;
        System.Console.WriteLine($"Ahora el valor es {n}");
    }
}