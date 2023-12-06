// Ejemplo_05_04a.cs
// Función "Cuadrado"
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_05_04a
{
    // nuestra función no es "void", sino "int", porque va a devolver un número entero
    //la función debe ser del tipo que 
    static int Cuadrado(int n)
    {
        return n * n;
    }

    static float Mayor(float n1, float n2)
    {
        float mayor = n1;
        if (n2 > n1)
            mayor = n2;
        return mayor;
    }

    static string Inalcanzable()
    {
        return "Aquí sí llegamos"; //En cuanto se alcance un "return", se sale de la función por completo
        string ejemplo = "Aquí no llegamos";
        return ejemplo;
    }
    static void Main()
    {
        int numero;
        int resultado;
        numero = 5;
        resultado = Cuadrado(numero);
        Console.WriteLine("El cuadrado del numero {0} es {1}",
        numero, resultado);
        Console.WriteLine(" y el de 3 es {0}", Cuadrado(3));

        Console.WriteLine("Devolución de número mayor");
        Console.WriteLine(Mayor(8.6f, 7.6f));
        float x = 10.5f, y = 9.5f;
        Console.WriteLine(Mayor(x, y));

        Console.WriteLine("return inalcanzable en función Inalcanzable()");
        Console.WriteLine(Inalcanzable());
        
    }
}