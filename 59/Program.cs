/*
(2.1.5.9) Crea un programa que pida al usuario tres números y muestre cuál es el
mayor de los tres.
*/

using System;

class E59
{
    static void Main()
    {
        Console.WriteLine("Introduce un número");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce un número");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce un número");
        int numero3 = Convert.ToInt32(Console.ReadLine());

        if ((numero1 > numero2) && (numero1 > numero3))
        {
            Console.WriteLine($"{numero1} Es el número mayor");
        }
        else if ((numero2 > numero1) && (numero2 > numero3))
        {
            Console.WriteLine($"{numero2} Es el número mayor");
        }
        else
        {
            Console.WriteLine($"{numero3} Es el número mayor");

        }





    }
}