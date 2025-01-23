using System;

class Program
{

/*
Paso de parametros por valor
*/

    public static void Duplicar(int x)
    {
        System.Console.WriteLine($"El valor de x es: {x}");
        x = x * 2;
        System.Console.WriteLine($"Ahora el valor de x es: {x}");
    }
    static void Main()
    {

        int n = 5;
        System.Console.WriteLine($"n vale: {n}");
        Duplicar(n);
        System.Console.WriteLine($"Ahora n vale: {n}");

    }
}
