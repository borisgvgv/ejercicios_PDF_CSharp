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

        Console.WriteLine($"x1 = {(x1 == 100000 ? "No existe solución real" : x1.ToString())}");
        Console.WriteLine($"x2 = {(x2 == 100000 ? "No existe solución real" : x2.ToString())}");


    }

    static void CalcularRaicesSegundoGrado(double a, double b, double c, ref double x1, ref double x2)
    {
        double discriminante = Math.Pow(b, 2) - 4 * a * c;

        if (discriminante < 0)
        {
            // No hay solución real
            x1 = 100000;
            x2 = 100000;
        }
        else
        {
            double raiz = Math.Sqrt(discriminante);
            x1 = (-b + raiz) / (2 * a);
            x2 = (-b - raiz) / (2 * a);
        }
    }
}