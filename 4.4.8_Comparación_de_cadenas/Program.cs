// Ejemplo_04_04_08a.cs
// Cadenas de texto y comparación alfabética
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_04_04_08a
{
    static void Main()
    {
        string frase;
        Console.WriteLine("Escriba una palabra");
        frase = Console.ReadLine();
        // Compruebo si es exactamente hola
        if (frase == "hola")
            Console.WriteLine("Ha escrito hola");
        // Compruebo si es mayor o menor
        if (frase.CompareTo("hola") > 0)
            Console.WriteLine("Es mayor que hola");
        else if (frase.CompareTo("hola") < 0)
            Console.WriteLine("Es menor que hola");
        // Comparo sin distinguir mayúsculas ni minúsculas
        //bool ignorarMays = true;
        if (String.Compare(frase, "hola", true) > 0)
            Console.WriteLine("Es mayor que hola (mays o mins)");
        else if (String.Compare(frase, "hola", true) < 0)
            Console.WriteLine("Es menor que hola (mays o mins)");
        else
            Console.WriteLine("Es hola (mays o mins)");
        // Forma alternativa, con .ToUpper()
        if (frase.ToUpper().CompareTo("hola".ToUpper()) > 0)
            Console.WriteLine("Es mayor que hola (mays o mins 2)");
        else if (frase.ToUpper().CompareTo("hola".ToUpper()) < 0)
            Console.WriteLine("Es menor que hola (mays o mins 2)");
        else
            Console.WriteLine("Es hola (mays o mins 2)");
            
    }
}
