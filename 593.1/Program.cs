/*
También existe un "Array.ForEach", que permite aplicar una cierta acción a cada
elemento de un array, y esa acción se puede expresar en formato de "lambda".
Por ejemplo, podríamos calcular la suma de una serie de números separados por
espacios, en dos pasos, de la siguiente manera:
*/

// Ejemplo_05_12c.cs
// Sumar números separados por espacios, usando "lambdas"
// Introducción a C#, por Nacho Cabanes
using System;
using System.Collections.Generic;
class Ejemplo_05_12c
{
    static void Main()
    {
        Console.Write("Introduce números separados por espacios: ");
        string[] datos = Console.ReadLine().Split();
        var valores = Array.ConvertAll(
        datos, t => Convert.ToInt32(t));
        int suma = 0;
        Array.ForEach(valores, n => suma += n);
        Console.WriteLine(suma);
    }
}