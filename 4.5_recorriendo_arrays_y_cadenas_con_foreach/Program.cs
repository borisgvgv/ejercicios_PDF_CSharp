/*
foreach
Se usa con el formato "foreach (variable in ConjuntoDeValores)". Será útil cuando
queramos obtener todos los elementos del array o cadena, pero sin preocuparnos
la posición en la que se encuentran:
*/

// Ejemplo_04_05a.cs
// Ejemplo de "foreach"
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_04_05a
{
    static void Main()
    {
        int[] diasMes = { 31, 28, 31 };
        foreach (int dias in diasMes)
        {
            Console.WriteLine("Días del mes: {0}", dias);
        }
        string[] nombres = { "Alberto", "Andrés", "Antonio" };
        foreach (string nombre in nombres)
        {
            Console.Write(" {0}", nombre);
        }
        Console.WriteLine();
        string saludo = "Hola";
        foreach (char letra in saludo)
        {
            Console.Write("{0}-", letra);
        }
        Console.WriteLine();

        /*
        La orden "foreach" también se puede aplicar a arrays bidimensionales, si estamos
        en el caso de que nos interese obtener todos los datos que contiene y no
        necesitemos saber de qué posición procede cada dato, como en este ejemplo:
        */

        Console.WriteLine();
        Console.WriteLine("Ejemplo 2------------------------");
        Console.WriteLine();

        // Ejemplo_04_05b.cs
        // Ejemplo de "foreach" con arrays bidimensionales
        // Introducción a C#, por Nacho Cabanes

        int[,] datos =
        {
{1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
{11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
};
        foreach (int n in datos)
        {
            Console.Write("{0} ", n);
        }


    }
}
