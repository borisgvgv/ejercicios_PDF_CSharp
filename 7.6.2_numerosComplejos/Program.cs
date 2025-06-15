using System;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        //Crear número complejo 3 parte real, 4i parte imaginaria
        Complex z = new Complex(3, 4);


        double parteReal = z.Real;
        double parteImaginaria = z.Imaginary;

        System.Console.WriteLine("La parte real es: {0}", parteReal);
        System.Console.WriteLine("La parte imaginaria es: {0}", parteImaginaria);

    }
}