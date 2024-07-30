// Ejemplo_04_04_05a.cs
// Cadenas de texto (5: substring)
// Introducción a C#, por Nacho Cabanes
using System;
public class Ejemplo_04_04_05a
{
    public static void Main()
    {
        string saludo = "Hola";
        string subcadena = "ola";
        Console.WriteLine("{0} aparece dentro de {1} en la posición {2}",
        subcadena, saludo, saludo.IndexOf(subcadena));
    }
}