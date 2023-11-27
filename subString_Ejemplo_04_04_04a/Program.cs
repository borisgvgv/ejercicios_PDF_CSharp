// Ejemplo_04_04_04a.cs
// Cadenas de texto (4: substring)
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_04_04_04a
{
    static void Main()
    {
        string saludo = "Hola";
        string subcadena = saludo.Substring(1, 3);
        Console.WriteLine("Una subcadena de {0} es {1}",
        saludo, subcadena);
    }
}