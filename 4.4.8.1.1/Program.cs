using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Compara dos frases");
        Console.WriteLine();

        Console.WriteLine("Frase 1: ");
        string frase1 = Console.ReadLine();
       
        Console.WriteLine("Frase 2: ");
        string frase2 = Console.ReadLine();

       
        if (string.Compare(frase1 , frase2, true) > 0)
        {
            Console.WriteLine("La frase mayor es: {0}", frase1);
        }
        else
        {
            Console.WriteLine("La frase mayor es: {0}", frase2);
        }

    }
}