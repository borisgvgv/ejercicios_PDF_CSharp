/*
(4.2.2) Un programa que pida al usuario dos bloques de 6 cadenas de texto.
Después pedirá al usuario una nueva cadena y comprobará si aparece en alguno
de los dos bloques de información anteriores.
*/

using System;
class Program
{
    static void Main()
    {

        int longitud = 3;
        string palabra;
        bool repeat = false;
        string[,] palabras = new string[2, longitud];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < longitud; j++)
            {
                Console.WriteLine("Introduce una palabra");
                palabra = Console.ReadLine();
                palabras[i, j] = palabra;
            }
        }

        Console.WriteLine("Introduce una palabra");
        string otraPalabra = Console.ReadLine();

        Console.WriteLine();
         for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < longitud; j++)
            {
                Console.WriteLine(palabras[i, j]);
                
            }
            Console.WriteLine();
        }

          for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < longitud; j++)
            {
                if(otraPalabra == palabras[i,j]){
                Console.WriteLine($" La palabra que se repite es {palabras[i,j]}"); 
                repeat = true;
                }

            }
        
        }

        if(repeat == false){
            Console.WriteLine("La parlabra no se encuentra "); 
        }

    }
}