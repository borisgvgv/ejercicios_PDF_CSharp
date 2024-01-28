/*
(5.4.5) Crea una función "UltimaLetra", que devuelva la última letra de una cadena
de texto. Prueba esta función para calcular la última letra de la frase "Hola"
*/

using System;
class Program
{
static char UltimaLetra(string palabra){
    return palabra[palabra.Length-1];
}
    static void Main()
    {
        Console.WriteLine("Escribe una palabra");
        string palabra = Console.ReadLine();

        Console.WriteLine(UltimaLetra(palabra));
    
    }
}