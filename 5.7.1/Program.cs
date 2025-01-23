using System;

/*
(5.7.1) Crea una función "Intercambiar", que intercambie el valor de los dos
números enteros que se le indiquen como parámetro. Crea también un programa
que la pruebe.
*/

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