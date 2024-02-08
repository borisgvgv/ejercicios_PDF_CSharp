/*
Crea un programa que muestre los valores de la función y = 10 *
seno(x*5), para valores de x entre 0 y 72 grados
*/
using System;

class Program
{

    public static double Calcular(double x)
    {
       

        double y = 10 * Math.Sin(x * 5);
        return y;
      

    }
    public static void Main(string[] args)
    {
      Random random= new Random();
      double x = random.Next(0,73);
      Console.WriteLine(x);
        Console.WriteLine(Calcular(x));
    }
}