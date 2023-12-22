// Ejemplo_05_07_03a.cs
// Parámetros "out"
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_05_07_03a
{
    static void ObtenerDosPrimerasLetras(string cadena,
    out char l1, out char l2)
    {
        l1 = cadena[0];
        l2 = cadena[1];
    }
    static void Main()
    {
        char letra1, letra2; 
        ObtenerDosPrimerasLetras("Nacho", out letra1, out letra2);
        Console.WriteLine("Las dos primeras letras son {0} y {1}", letra1, letra2);

        // se puededen declarar las variables directamente en la llamada a la función
        ObtenerDosPrimerasLetras("Perro", out char primeraLetra, out char segundaLetraetra);
        Console.WriteLine("Las dos primeras letras son {0} y {1}", primeraLetra, segundaLetraetra);

    }
}