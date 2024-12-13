using System;
class Program
{

    public static float Cubo(float n)
    {
        return n * n * n;
    }
    static void Main()
    {

        float real = 3.2f;
        int entero = 5;

        Console.WriteLine($"{Cubo(real)}");
        Console.WriteLine($"{Cubo(real).ToString("#.##")}");
        Console.WriteLine($"{Cubo(entero)}");



    }
}