/*
(2.1.8.2) Usa el operador condicional para calcular el menor de dos números.
*/

using System;
class Ejemplo_2182
{
    static void Main()
    {

        Console.WriteLine("Intruduce un número");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Intruduce un número");
        int b = Convert.ToInt32(Console.ReadLine());

        int numeroMayor = a > b ? a : b;

        Console.WriteLine(numeroMayor);

    }
}
