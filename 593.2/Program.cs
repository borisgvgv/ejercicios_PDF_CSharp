/*Pero el ejemplo anterior se podría simplificar, haciendo la conversión en el
"ForEach", así:
*/

// Ejemplo_05_12d.cs
// Sumar números separados por espacios, usando "lambdas" (2)
// Introducción a C#, por Nacho Cabanes
using System;
using System.Collections.Generic;
class Ejemplo_05_12c
{
    static void Main()
    {
        Console.Write("Introduce números separados por espacios: ");
        string[] datos = Console.ReadLine().Split();
        int suma = 0;
        Array.ForEach(datos, n => suma += Convert.ToInt32(n));
        Console.WriteLine(suma);
    }
}