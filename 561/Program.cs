/*

*/ 

using System;
public class Ejemplo_05_06b
{
static int n = 7;
public static void CambiaN()
{
n ++;
Console.WriteLine("Ahora n vale {0}", n);
}
public static void Main()
{
Console.WriteLine("n vale {0}", n);
CambiaN();
Console.WriteLine("Y al final n vale {0}", n);
}
}