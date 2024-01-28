/*
(5.4.4) Crea una función "Inicial", que devuelva la primera letra de una cadena de
texto. Prueba esta función para calcular la primera letra de la frase "Hola"
*/

using System;
class Program
{

    static char Inicial(string palabra)
    {
        char inicial = palabra[0];
        return inicial;
    }
    static void Main()
    {
        Console.WriteLine("Escribe una palabra para que obtengamos su inicial");
        string palabra = Console.ReadLine();
        Console.WriteLine("La inicial de {0} es {1}", palabra, Inicial(palabra));
    }
}