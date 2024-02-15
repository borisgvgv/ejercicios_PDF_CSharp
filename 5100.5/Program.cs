/*
Crea un programa que emplee recursividad para calcular el mayor de los
elementos de un vector. El planteamiento será muy similar al del ejercicio anterior.
*/

using System;
class Program
{
    public static int CalcularElMayor(int[] vector, int desde, int hasta)
    {


        if (desde == hasta)
        {
            return vector[desde];
        }
        return Math.Max(vector[desde], CalcularElMayor(vector, desde + 1, hasta));
    }
    static void Main()
    {



        int[] vector = { 46, 78, 90, 32, 2, 25, 8 };
        int desde = 0;
        int hasta = vector.Length - 1;

        int mayor = vector[0];

        for (int i = 0; i < vector.Length-1; i++)
        {
            mayor = Math.Max(mayor, vector[i + 1]);
        }


        Console.WriteLine($"El mayor con bucle for es : {mayor}");

        Console.WriteLine($"El mayor con recursividad es : {CalcularElMayor(vector, desde, hasta)}");
    }
}