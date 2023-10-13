/*
Un ejemplo que nos diga si cada número que tecleemos es positivo o negativo, y
que termine cuando tecleemos 0, podría ser:
*/

using System;
class E2211
{
    static void Main()
    {

        System.Console.WriteLine("Añade un número");
        int numero = Convert.ToInt32(Console.ReadLine());

        while (numero != 0)
        {
            if (numero < 0)
            {
                System.Console.WriteLine($"{numero} es negativo");
            }
            else
            {
                System.Console.WriteLine($"{numero} es positivo");
            }

            System.Console.WriteLine("Añade un número");
            numero = Convert.ToInt32(Console.ReadLine());
        }

    }
}