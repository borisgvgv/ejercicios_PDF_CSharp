using System;

class Program
{
    public static void CalcularMedia()
    {

        Random r = new Random();
        int[] datos = new int[2000];
        int n;
        int suma = 0, media = 0;


        for (int i = 0; i < 2000; i++)
        {
            datos[i] = r.Next(-1000, 1000);
            suma += datos[i];
        }

        System.Console.WriteLine($"La media es: {suma / 2000}");

    }

    static void Main()
    {
        Console.Clear();
        CalcularMedia();
    }
}
