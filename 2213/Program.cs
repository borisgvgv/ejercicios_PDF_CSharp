/*
(2.2.1.1.3) Crea un programa que pida de forma repetitiva pares de números al
usuario. Tras introducir cada par de números, responderá si el primero es múltiplo
del segundo. Se repetirá mientras los dos números sean distintos de cero
(terminará cuando uno de ellos sea cero)
*/

using System;
class E2213
{
    static void Main()
    {

        Console.WriteLine("Añade un número");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Añade otro número");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        while ((numero1 != 0) && (numero2 != 0))
        {
            if (numero1 % numero2 == 0)
            {
                Console.WriteLine($"{numero1} es múltiplo de {numero2}");
            }
            else
            {
                Console.WriteLine($"{numero1} no es múltiplo de {numero2}");

            }

            Console.WriteLine("Añade un número");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Añade otro número");
            numero2 = Convert.ToInt32(Console.ReadLine());
        }

    }
}