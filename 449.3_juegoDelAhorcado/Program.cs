using System;

/*
(4.4.9.3) Crea un juego del ahorcado, en el que un primer usuario introduzca la
palabra a adivinar, se muestre ésta oculta con guiones (-----) y el programa acepte
las letras que introduzca el segundo usuario, cambiando los guiones por letras
correctas cada vez que acierte (por ejemplo, a---a-t-). La partida terminará cuando
se acierte la palabra por completo o el usuario agote sus 8 intentos.
*/
class Program
{
    static void Main()
    {
        Console.Clear();
        int cantidad = 0;
        int capacidad = 25;
        char[] palabraTemporal = new char[capacidad];

        System.Console.Write("Introduce una palabra: ");
        string palabra = Console.ReadLine();
        palabra = palabra.ToLower();

        Console.Clear();

        // llenamos array palabraTemporal
        for (int i = 0; i < palabra.Length; i++)
        {
            palabraTemporal[cantidad] = '_';
            cantidad++;
        }

        //Mostramos array palabraTemporal
        System.Console.WriteLine("Palabra");
        for (int i = 0; i < palabra.Length; i++)
        {
            System.Console.Write(palabraTemporal[i]);
        }
    System.Console.WriteLine();

        int contador = palabra.Length + 3;
        int contadorDeLetras = 0;

        do
        {
            System.Console.Write("Introduce una letra: ");
            char letra = Convert.ToChar(Console.ReadLine());
            contador--;

            for (int i = 0; i < cantidad; i++)
            {
                if (palabra[i] == letra && i == 0)
                {
                    palabraTemporal[i] = char.ToUpper(letra);
                    contadorDeLetras++;
                }
                else if (palabra[i] == letra && palabraTemporal[i] != letra)
                {
                    palabraTemporal[i] = letra;
                    contadorDeLetras++;
                }

                if (contadorDeLetras == cantidad)
                {
                    contador = 0;
                }

            }

            Console.Clear();
            System.Console.WriteLine("Palabra");

            for (int i = 0; i < cantidad; i++)
            {
                System.Console.Write(palabraTemporal[i]);
            }
            System.Console.WriteLine();

        } while (contador != 0);

        if (contadorDeLetras == cantidad)
        {
            System.Console.WriteLine("You Win");
        }
        else
        {
            System.Console.WriteLine("Game Over");
        }




    }
}