using System;

class Program
{
    static void Main()
    {

        string frase = "No por mucho madrugar amanece más temprano";
        Console.WriteLine(frase);

        frase = frase.Replace(" ", "");
        Console.WriteLine(frase);
    }
}