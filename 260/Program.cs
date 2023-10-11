/*
(2.1.5.10) Crea un programa que pida al usuario dos números enteros y diga si son
iguales o, en caso contrario, cuál es el mayor de ellos
*/
using System;

class E2510
{
    static void Main()
    {
        Console.WriteLine("Introduce un número");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce un número");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 < numero2)
        {
            Console.WriteLine($"{numero2} es mayor");
        }
        else if (numero1 > numero2)
        {
            Console.WriteLine($"{numero1} es mayor");
        }
        else
        {
            Console.WriteLine($"{numero1} y {numero2} son guales");
        }
    }
}