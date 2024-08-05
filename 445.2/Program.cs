using System;

class Program
{

    static void Main()
    {

        string frase = "No por mucho madrugar amanece más temprano";
        string fraseToUpper = frase.ToUpper();


        Console.Write("Frase: ");
        Console.WriteLine(frase);

        Console.WriteLine("Escribe una palabra");
        string palabraBuscada = Console.ReadLine();
        string palabraBuscadaToUpper = palabraBuscada.ToUpper();


        if (fraseToUpper.IndexOf(palabraBuscadaToUpper) >= 0 && fraseToUpper.IndexOf(palabraBuscadaToUpper) != 0)
        {
            palabraBuscada = palabraBuscada.ToLower();
            Console.WriteLine($"La frase contiene '{palabraBuscada}'");
        }
        else if (fraseToUpper.IndexOf(palabraBuscadaToUpper) >= 0 && fraseToUpper.IndexOf(palabraBuscadaToUpper) == 0)
        {
            palabraBuscada = palabraBuscada.Substring(0,1).ToUpper() + palabraBuscada.Substring(1).ToLower();
            Console.WriteLine($"La frase contiene '{palabraBuscada}' en la posición '{fraseToUpper.IndexOf(palabraBuscadaToUpper)}'");
        }
        else
        {
            Console.WriteLine($"La frase no contiene '{palabraBuscada}'");
        }

    }
}