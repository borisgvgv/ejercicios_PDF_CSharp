using System;

class Program
{
    static void Main()
    {

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        for (int i = nombre.Length - 1; i >= 0; i--)
        {
            Console.Write("{0} ", nombre[i]);
        }
        Console.WriteLine();

    }
}
