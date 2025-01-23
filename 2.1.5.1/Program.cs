/*

(2.1.5.1) Crea un programa que pida al usuario un número entero y responda si es
múltiplo de 2 o de 3

*/
using System;

class E2151
{
    static void Main()
    {
        Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());

        if ((numero % 2 == 0)&&(numero % 3 == 0))
        {
            Console.WriteLine($"{numero} es multiplo de 2 y de 3.");
        }
        else if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} es múltiplo de 2 pero no de 3.");
        }
        else if (numero % 3 == 0)
        {
            Console.WriteLine($"{numero} es múltiplo de 3 pero no de 2.");
        }
        else
        {
            Console.WriteLine($"{numero} No es múltiplo  ni de 2 ni de 3.");
        }

    }
}