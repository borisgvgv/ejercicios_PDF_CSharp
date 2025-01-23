/*
(5.9.2.3) Haz un programa que resuelva ecuaciones de segundo grado, del tipo ax al cuadrado
+ bx + c = 0. El usuario deberá introducir los valores de a, b y c. Se deberá crear
una función "CalcularRaicesSegundoGrado", que recibirá como parámetros los
coeficientes a, b y c (por valor), así como las soluciones x1 y x2 (por referencia).
Deberá devolver los valores de las dos soluciones x1 y x2. Si alguna solución no
existe, se devolverá como valor 100.000 para esa solución. Pista: la solución se
calcula con
x = -b +/- raíz (b al cuadrado – 4·a·c) / (2·a)
*/

using System;
class Program
{
    static void Main()
    {
        Console.Write("valor de a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("valor de b");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("valor de c");
        int c = Convert.ToInt32(Console.ReadLine());

        CalcularRaicesSegundoGrado(a, b, c, ref x1, ref x2);
    }
}