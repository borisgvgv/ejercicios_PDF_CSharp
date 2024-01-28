/*
(5.9.1.4) Crea un programa que genere un array relleno con 100 números reales al
azar entre -1000 y 1000. Luego deberá calcular y mostrar su media.
*/

using System;
class Program
{

    static void MostrarArray(float[] array, int totalNumeros)
    {
        Random numero = new Random();
        float valorRandom;

        for (int i = 0; i < totalNumeros; i++)
        {
            valorRandom = numero.Next(-1000, 1001);
            array[i] = valorRandom;
            Console.WriteLine(array[i]);

        }
    }
    static void CalcularMedia(float[] array, int totalNumeros)
    {
        float media = 0;
        float valor = 0;
        for (int i = 0; i < totalNumeros; i++)
            valor += array[i];

        media = valor / totalNumeros;
        Console.WriteLine($"La media = {media}");

    }
    static void Main()
    {
        int totalNumeros = 100;
        float[] array = new float[totalNumeros];
        MostrarArray(array, totalNumeros);
        CalcularMedia(array, totalNumeros);
    }
}