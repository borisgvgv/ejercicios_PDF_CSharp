/*

Ver en pdf 5.9.2. Funciones matemáticas

*/

//Un ejemplo más avanzado, usando funciones trigonométricas, que calculase el"coseno de 45 grados" podría ser:

// Ejemplo_05_09_02a.cs
// Ejemplo de funciones trigonometricas
// Introducción a C#, por Nacho Cabanes
using System;
public class Ejemplo_05_09_02a
{
    public static void Main()
    {
        double anguloGrados = 45;
        double anguloRadianes = anguloGrados * Math.PI / 180.0;
        Console.WriteLine("El coseno de 45 grados es: {0}",
        Math.Cos(anguloRadianes));
    }
}