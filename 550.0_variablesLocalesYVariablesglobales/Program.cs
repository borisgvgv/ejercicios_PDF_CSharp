

using System;
class Program
{
    static int Potencia(int numero, int potencia)
    {
        int resultado = 1;
        for (int i = 1; i <= potencia; i++)
        {
            resultado = numero * resultado;
        }
        return resultado;

    }
    static void Main()
    {

        Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce un valor de potencia");
        int potencia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("La potencia de {0} elevado a {1} es {2}", numero, potencia, Potencia(numero, potencia));

    }
}