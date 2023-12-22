/*
Una función sencilla como la siguiente:
static int Doble(int n)
{
return n * 2;
}

Se podría escribir de forma alternativa de esta manera:
static Func<int,int> Doble2 = n => n * 2;

*/

//Y un programa completo de ejemplo podría ser:


// Ejemplo_05_12a.cs
// Contacto con las "lambdas"
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_05_12a
{
    static int Doble(int n)
    {
        return n * 2;
    }
    static Func<int, int> Doble2 = n => n * 2;
    static void Main()
    {
        Console.WriteLine(Doble(5));
        Console.WriteLine(Doble2(5));
    }
}