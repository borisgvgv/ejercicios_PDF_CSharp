/*(2.1.9.2) Crea un programa que lea una letra tecleada por el usuario y diga si se
trata de un signo de puntuación (. , ; :), una cifra numérica (del 0 al 9) o algún otro
carácter, usando "switch" (pista: necesitarás que usar un dato de tipo "char").*/

using System;

class E2192
{
    static void Main()
    {
        
        Console.WriteLine("Introduce un caracter");
        char letra = Convert.ToChar(Console.ReadLine());

        switch (letra)
        {
            case '.': System.Console.WriteLine("Es un punto"); break;
            case ',': System.Console.WriteLine("Es una coma"); break;
            case ';': System.Console.WriteLine("Es un punto y coma"); break;
            case ':': System.Console.WriteLine("Son dos puntos"); break;
            case '1': 
            case '2': 
            case '3': 
            case '4': 
            case '5': 
            case '6': 
            case '7': 
            case '8': 
            case '9': 
            case '0': System.Console.WriteLine("Es un numero entre 0 y 9"); break;
            default: Console.WriteLine("Es una letra"); break;
        }

    }
}