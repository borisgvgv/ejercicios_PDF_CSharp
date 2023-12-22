
/*
La recursividad consiste en resolver un problema a partir de casos más simples del
mismo problema. Una función recursiva es aquella que se "llama a ella misma",
reduciendo la complejidad paso a paso hasta llegar a un caso trivial.
Dentro de las matemáticas tenemos varios ejemplos de funciones recursivas. Uno
clásico es el "factorial de un número":
El factorial de 1 es 1:
1! = 1
Y el factorial de un número arbitrario es el producto de ese número por los que le
siguen, hasta llegar a uno:
n! = n · (n-1) · (n-2) · ... · 3 · 2 · 1
(por ejemplo, el factorial de 4 es 4 · 3 · 2 · 1 = 24)
Si pensamos que el factorial de n-1 es
(n-1)! = (n-1) · (n-2) · (n-3) · ... · 3 · 2 · 1
Entonces podemos escribir el factorial de un número a partir del factorial del
siguiente número:
n! = n · (n-1)!
Esta es la definición recursiva del factorial, ni más ni menos. Esto se podría
programar así:
*/

// Ejemplo_05_10a.cs
// Funciones recursivas: factorial
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_05_10a
{
    static long Factorial(int n)
    {
        if (n == 1) // Aseguramos que termine (caso base)
            return 1;
        return n * Factorial(n - 1); // Si no es 1, sigue la recursión
    }
    static void Main()
    {
        int num;
        Console.WriteLine("Introduzca un número entero: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Su factorial es: {0}", Factorial(num));
    }
}