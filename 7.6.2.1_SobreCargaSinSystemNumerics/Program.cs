using System;

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
    protected double real;
    protected double img;

    public Complejo(double real, double img)
    {
        this.real = real;
        this.img = img;
    }

    public double GetReal() => real;
    public double GetImg() => img;

    public void Set(double real, double img)
    {
        this.real = real;
        this.img = img;
    }

    public static Complejo operator +(Complejo a, Complejo b)
    {
        return new Complejo(a.real + b.real, a.img + b.img);
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"{real} + {img}i");
    }
}
