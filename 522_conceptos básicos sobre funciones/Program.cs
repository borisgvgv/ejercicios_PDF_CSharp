
using System;
class E522
{

    //Planteamos las funciones y lo que hacen
    static void Saludar()
    {
        Console.Write("Bienvenido al programa ");
        Console.WriteLine("de ejemplo");
        Console.WriteLine("Espero que estés bien");
    }

    /*
    A la segunda función le pasamos un parámetro (float n). 
    Cuando pasamos parámetros debemos indicar que tipo de parámetro estamos pasando, int, char, string, float ...
    */
    static void EscribirNumeroReal(float n)
    {
        Console.WriteLine(" y otro distinto es: ");
        Console.WriteLine(n.ToString("#.###"));
    }

    static void EscribirSuma(int a, int b)
    {
        Console.Write("La suma de {0} y {1} es: ", a, b);
        Console.WriteLine(a + b);
    }

    static void Main()
    {
        Saludar(); //Salida de la Primera función

        float x;
        x = 5.1f;
        Console.WriteLine("El primer número real es: ");
        EscribirNumeroReal(x);


        EscribirNumeroReal(2.8956f); //Salida de la segunda función
        EscribirSuma(4, 3);//Salida de la tercera función

    }
}
