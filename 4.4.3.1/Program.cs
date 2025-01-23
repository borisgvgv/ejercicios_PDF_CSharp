using System;

class Program
{
    static void Main()
    {

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < nombre.Length; i++)
        {
            Console.Write("{0} ", nombre[i]);

        }
        Console.WriteLine();
    }
}