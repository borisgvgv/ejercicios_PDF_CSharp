/*
Aquí vemos que al salir de la función, no se conservan los cambios que hagamos a
esa variable que se ha recibido como parámetro.
Esto se debe a que, si no indicamos otra cosa, los parámetros "se pasan por
valor", es decir, la función no recibe los datos originales, sino una copia de ellos. Si
modificamos algo, estamos cambiando una copia de los datos originales, no
dichos datos.
*/ 

using System;
public class Ejemplo_05_07a
{
    public static void Duplicar(int x)
    {
        Console.WriteLine(" El valor recibido vale {0}", x);
        x = x * 2;
        Console.WriteLine(" y ahora vale {0}", x);
    }
    public static void Main()
    {
        int n = 5;
        Console.WriteLine("n vale {0}", n);
        Duplicar(n);
        Console.WriteLine("Ahora n vale {0}", n);
    }
}