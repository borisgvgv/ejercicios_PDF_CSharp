/*
(4.2.1) Un programa que pida al usuario dos bloques de 10 números enteros
(usando un array de dos dimensiones). Después deberá mostrar el mayor dato
que se ha introducido en cada uno de ellos.
*/

using System;
class Program
{
    static void Main()
    {

        int longitud = 2;
        int[,] notas = new int[2, longitud];
        int mayor = 0;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < longitud; j++)
            {
                Console.WriteLine("Introduce una nota");
                int nota = Convert.ToInt32(Console.ReadLine());

                notas[i, j] = nota;
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < longitud; j++)
            {
                Console.WriteLine($"Grupo {i + 1}.{j + 1} = {notas[i, j]}");
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < longitud; j++)
            {
             
                if (mayor < notas[i, j] )
                {
                    mayor = notas[i, j];
                }
                

            }
        }
        Console.WriteLine($"El numero mayor es {mayor}");

    }
}