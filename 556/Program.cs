
/*
(5.5.6) Crea una función "Triángulo" que reciba una letra y un número, y escriba un
"triángulo" formado por esa letra, que tenga como anchura inicial la que se ha
indicado. Por ejemplo, si la letra es * y la anchura es 4, debería escribir
****
***
**
*

*/

using System;
class Program555
{

    static void Triangulo(char letra, int numero)
    {
        int numeroj= numero;
        for (int i = 0; i <= numero; i++)
        {
            for (int j = numeroj; j > 0; j--)
            {
                Console.Write(letra);
            }
            Console.WriteLine();
            numeroj--;
        }


    }
    static void Main()
    {
        Console.WriteLine("Introduce una letra");
        char letra = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());

        Triangulo(letra, numero);
    }
}