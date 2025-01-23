using System;

class Program
{
    public static float PerimetroSuperficieCuadrado(float lado)
    {
        return lado * 4;
    }

    public static float PedirLongitudLado()
    {
        System.Console.Write("Longitud de un lado: ");
        return Convert.ToSingle(Console.ReadLine());
    }
    static void Main()
    {
        System.Console.WriteLine($"El perímetro es: {PerimetroSuperficieCuadrado(PedirLongitudLado())}");
    }
}