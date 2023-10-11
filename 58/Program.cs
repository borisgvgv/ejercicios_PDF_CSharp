/*
(2.1.5.8) Crea un programa que pida al usuario dos números enteros y diga "Uno
de los números es positivo", "Los dos números son positivos" o bien "Ninguno de
los números es positivo", según corresponda.
*/

using System;

class E58
{
    static void Main()
    {
        Console.WriteLine("Introduce un número");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce otro número");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if ((numero1 > 0) && (numero2 > 0))
        {
            Console.WriteLine($"{numero1} y {numero2} son positivos");
        }
        else if ((numero1 > 0) || (numero2 > 0))
        {
            if (numero1 > 0)
            {
                Console.WriteLine($"{numero1} es positivo");
            }
            else
            {
                Console.WriteLine($"{numero2} es positivo");
            }
        }
        else
        {
            Console.WriteLine($"Los dos números son negativos");
        }

    }
}
