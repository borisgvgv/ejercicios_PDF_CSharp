/*
(5.5.4) Crea una función "ContarLetra", que reciba una cadena y una letra, y
devuelva la cantidad de veces que dicha letra aparece en la cadena. Por ejemplo, si
la cadena es "Barcelona" y la letra es 'a', debería devolver 2 (porque la "a" aparece
2 veces).
*/

using System;
class Program
{

    static void ContarLetra(string cadena, char letra)
    {
        int contador = 0;
        foreach (char l in cadena)
        {
            if (l == letra)
            {
                contador += 1;
            }
        }
        Console.WriteLine("La {0} aparece {1} veces", letra, contador);

    }
    static void Main()
    {
        Console.WriteLine("Introduce una palabra");
        string cadena = Console.ReadLine();
        Console.WriteLine("Introduce una letra");
        char letra = Convert.ToChar(Console.ReadLine());
        ContarLetra(cadena, letra);
    }
}