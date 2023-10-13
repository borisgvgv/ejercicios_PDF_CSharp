/*
(2.2.1.1.2) Crea un "calculador de cuadrados": pedirá al usuario un número y
mostrará su cuadrado. Se repetirá mientras el número introducido no sea cero
(usa "while" para conseguirlo).
*/

using System;
class E2212
{
    static void Main()
    {
        Console.WriteLine("Añade un número");
        int numero = Convert.ToInt32(Console.ReadLine());


        while (numero != 0)
        {

            Console.WriteLine(numero * numero);
            Console.WriteLine("Añade un número");
            numero = Convert.ToInt32(Console.ReadLine());
            
        }

    }
}