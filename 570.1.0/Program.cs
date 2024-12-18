using System;

class Program
{

    public static void Intercambiar(ref int a, ref int b)
    {
        int temp;
        temp = a;
        a = b;
        b = temp;
    }
    static void Main()
    {

        System.Console.Write("Numero 1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Numero 2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Intercambiar(ref n1, ref n2);
        System.Console.WriteLine($"{n1}, {n2}");


    }
}