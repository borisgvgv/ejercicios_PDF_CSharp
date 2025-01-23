using System;

class Program
{
    static void Main()
    {
        int resultado = 0;

        Console.WriteLine("Introduce números separados por espacios");

        string numeros = Console.ReadLine();

        Console.WriteLine("Los númeroos añadidos son {0}", numeros);

        string[] arrayNumeros = numeros.Split();



        foreach (string num in arrayNumeros)
        {

            resultado = resultado + Convert.ToInt32(num);

        }

        Console.WriteLine("La suma de todos los números añadidos es: {0}", resultado);



    }
}
