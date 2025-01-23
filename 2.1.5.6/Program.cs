/*
(2.1.5.6) 
Crea un programa que pida al usuario dos números enteros y diga si 
(al menos) uno es par.
*/

using System;

class E56{
    static void Main()
    {
        Console.WriteLine("Introduce un número");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce otro número");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if ((numero1 % 2 == 0) && (numero2 % 2 == 0))
        {
            Console.WriteLine($"{numero1} y {numero2} son pares");
        }
        else if ((numero1 % 2 == 0) || (numero2 % 2 == 0))
        {
            if (numero1 % 2 == 0)
            {
                Console.WriteLine($"{numero1} es par");
            }
            else
            {
                Console.WriteLine($"{numero2} es par");
            }
        }
        else
        {
            Console.WriteLine($"Los dos números son impares.");
        }

    }
}