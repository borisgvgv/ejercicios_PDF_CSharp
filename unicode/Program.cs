using System;
class Unicode
{
    static void Main()
    {
        byte simbolo;

        Console.WriteLine("Introduce un número entre 33 y 126");
        simbolo = Convert.ToByte(Console.ReadLine());

        while (simbolo < 33 || simbolo > 126)
        {
            Console.WriteLine("Número fuera de rango");
            Console.WriteLine("Introduce un número entre 33 y 126");
            simbolo = Convert.ToByte(Console.ReadLine());
        }

        Console.WriteLine($"En el formato unicode {simbolo} == {(char)simbolo}");



        char letra1, letra1menor;
        char letra2, letra2mayor;

        Console.WriteLine("Introduce una letra Mayúscula");
        letra1 = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Introduce una letra Mayúscula");
        letra2 = Convert.ToChar(Console.ReadLine());


        if (letra2 < letra1)
        {
            letra1menor = letra2;
            letra2mayor = letra1;
        }
        else
        {
            letra1menor = letra1;
            letra2mayor = letra2;
        }

        for (char letra = letra1menor; letra <= letra2mayor; letra++)
        {
            Console.Write(letra + " ");
        }

    }
}