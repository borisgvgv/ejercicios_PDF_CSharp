using System;
using System.Numerics;

public class Program
{
    public static void Main()
    {

        Complejo c1 = new Complejo(2, 3); // 2 + 3i
        Complejo c2 = new Complejo(1, 4); // 1 + 4i

        Complejo suma = c1 + c2;

        suma.MostrarEstado(); // Debería mostrar 3 + 7i

    }
}

public class Complejo
{
    protected Complex numComplex;

    public Complejo(double real, double img)
    {
        numComplex = new Complex(real, img);
    }

    public double GetReal() => numComplex.Real;
    public double GetImg() => numComplex.Imaginary;

    public void Set(double real, double img)
    {
        numComplex = new Complex(real, img);
    }

    public static Complejo operator +(Complejo a, Complejo b)
    {
        Complex resultado = a.numComplex + b.numComplex;
        return new Complejo(resultado.Real, resultado.Imaginary);
    }

    public void MostrarEstado()
    {
        System.Console.WriteLine($"{numComplex.Real} + {numComplex.Imaginary}i");
    }

}