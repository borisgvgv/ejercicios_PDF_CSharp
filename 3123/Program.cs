/*
(3.1.2.3) Pide al usuario dos números enteros largos ("long") y muestra su suma,
su resta y su producto.
*/ 

using System;

class E3123
{
    static void Main()
    {
        System.Console.WriteLine("Introduce un número mayor de 7 cifras");
        long num1 = Convert.ToInt64(Console.ReadLine());
        System.Console.WriteLine("Introduce otro número mayor de 7 cifras");
        long num2 = Convert.ToInt64(Console.ReadLine());

        long mult = num1 * num2;
        long suma = num1 + num2;
        long resta = num1 - num2;
        
        System.Console.WriteLine($"Multiplicación: {mult}, Suma: {suma}, Resta: {resta}");

    }
}
