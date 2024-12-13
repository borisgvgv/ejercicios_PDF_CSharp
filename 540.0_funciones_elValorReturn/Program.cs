using System;
class Program
{
    public static int CuadradoDeN(int n)
    {
        return n * n;
    }
    static void Main()
    {
        int n = 2;
        System.Console.WriteLine("El cuadrado de {0} es {1}", n, CuadradoDeN(n));
    }
}