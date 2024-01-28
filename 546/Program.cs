/*
(5.4.6) Crea una función "MostrarPerimSuperfCuadrado" que reciba un número
entero y calcule y muestre en pantalla el valor del perímetro y de la superficie de
un cuadrado que tenga como lado el número que se ha indicado como parámetro.
*/ 

using System;
class Program
{
static int MostrarPerimSuperfCuadrado(int lado){
    return lado * 4;
}
    static void Main()
    {
        Console.WriteLine("Escribe longitud de un lado");
        int lado = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(MostrarPerimSuperfCuadrado(lado));

    }
}