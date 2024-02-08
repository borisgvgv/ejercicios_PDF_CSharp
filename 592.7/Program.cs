/*
Crea un programa que pida al usuario un ángulo (en grados) y muestre su
seno, coseno y tangente. Recuerda que las funciones trigonométricas esperan que el ángulo se indique en radianes, no en grados. La equivalencia es que 360 grados
son 2*PI radianes.
*/
using System;

class Program {
  public static void Main (string[] args) {

    Console.WriteLine("Añade un ángulo en grados");
    double anguloGrados = Convert.ToDouble(Console.ReadLine()); 
    double anguloRadianes = anguloGrados * Math.PI / 180.0;

    Console.WriteLine(Math.Sin(anguloRadianes));
    Console.WriteLine(Math.Cos(anguloRadianes));
    Console.WriteLine(Math.Tan(anguloRadianes));
  }
}