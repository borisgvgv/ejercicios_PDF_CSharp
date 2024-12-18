/*
(5.9.1.1) Crea un programa que imite el lanzamiento de un dado, generando un
número al azar entre 1 y 6
*/


using System;

class Program
{
    static void Main()
    {
        Random numero = new Random();
        int valorDelDado;

        Console.Write("Presiona enter para lanzar el dado ");
        string lanzamiento = Console.ReadLine();

        // Verificar si se presionó Enter
        if (lanzamiento == "")
        {
            valorDelDado = numero.Next(1, 7);
            Console.Write($"El valor del dado es: {valorDelDado}");
        }
        else
        {
            Console.WriteLine("No presionaste Enter para lanzar el dado.");
        }
        System.Console.WriteLine();
    }
}



