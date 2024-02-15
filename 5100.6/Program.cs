/*
Crea un programa que emplee recursividad para dar la vuelta a una
cadena de caracteres (por ejemplo, a partir de "Hola" devolvería "aloH"). La función
recursiva se llamará "Invertir(cadena)". Como siempre, analiza cuál será el caso
base (qué longitud debería tener una cadena para que sea trivial darle la vuelta) y
cómo pasar del caso "n-1" al caso "n" (por ejemplo, si ya has invertido las 5
primeras letras, que ocurriría con la de la sexta posición).
*/

using System;
class Program
{
    public static string InvertirCadena(string cadena)
    {

        if (cadena.Length <= 1)
            return cadena;

        // Recursión: invertir la cadena excepto el primer carácter,
        // y concatenar el primer carácter al final

        return InvertirCadena(cadena.Substring(1)) + cadena[0];
        //ola + H
        //la + o
        //a + l
        //a + " " // cuando cadena la cadena es <= 1 la condición if est true y se lanza la cadena que ha ido gradando
        // odnuM aloH en orden inverso al que se ha ido guardando
        // recordar que las pilas guardadas se lanzan en orden inverso al que entraron.


    }
    static void Main()
    {

        string cadena = "Hola Mundo";
        Console.WriteLine(InvertirCadena(cadena));

    }
}