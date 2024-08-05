using System;

class Program
{
    static void Main()
    {

        string frase = "No por mucho madrugar amanece más temprano";
        Console.WriteLine(frase);

        string fraseToLower = frase.ToLower();

        Console.WriteLine("Añade una palabra");
        string palabra = Console.ReadLine();
        string palabraToLower = palabra.ToLower();

        if (fraseToLower.Contains(palabraToLower))
        {
            Console.WriteLine($"La palabra '{palabra}' aparece en la frase");
        }
        else
        {
            Console.WriteLine($"La palabra '{palabra}' no aparece en la frase");
        }
    }
}