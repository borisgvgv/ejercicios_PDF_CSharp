/*
(2.1.6.1) Crea una variante del ejemplo 02_01_06a, en la que la comparación de
igualdad sea correcta y en la que las variables aparezcan en el lado derecho de la
comparación y los números en el lado izquierdo
*/
using System;
class Ejemplo_02_01_06a
{
    static void Main()
    {
        int numero;
        Console.WriteLine("Introduce un número");
        numero = Convert.ToInt32(Console.ReadLine());
        if (0 == numero)
            Console.WriteLine("El número es cero.");
        else
        if (0 > numero)
            Console.WriteLine("El número es negativo.");
        else
            Console.WriteLine("El número es positivo.");
    }
}