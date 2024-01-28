
/*
(5.9.1.2) Crea un programa que genere un número al azar entre 1 y 100. El
usuario tendrá 6 oportunidades para acertarlo.
*/

using System;
class Program
{
    static void Main()
    {
        Random numero = new Random();

        int intentos = 0;
        int numeroRandom = numero.Next(1, 101);
        Console.WriteLine(numero);

        do
        {

            Console.WriteLine("Intenta acertar el número Random");
            Console.WriteLine("Introduce un número");
            int numJugador = Convert.ToInt32(Console.ReadLine());

            if (numJugador == numeroRandom)
            {
                System.Console.WriteLine("Has acertado");
            }
            else if (numJugador > numeroRandom)
            {
                System.Console.WriteLine("No has acertado");
                System.Console.WriteLine("El número es más bajo");
            }
            else if (numJugador < numeroRandom)
            {
                System.Console.WriteLine("No has acertado");
                System.Console.WriteLine("El número es más alto");
            }
            intentos++;
        } while (intentos < 3);




    }

}