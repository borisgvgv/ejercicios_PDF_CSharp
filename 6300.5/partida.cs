using System;
public class Partida
{

    public void Lanzar()
    {

        ConsoleKeyInfo keyInfo;
        do
        {
            Console.WriteLine("Esta sería la pantalla de juego");

            Console.WriteLine("Añade tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola {0}", nombre);
            Console.WriteLine("Fin del juego");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Pulse Intro para jugar o Escape para salir");
                keyInfo = Console.ReadKey();

                if (keyInfo.Key != ConsoleKey.Enter && keyInfo.Key != ConsoleKey.Escape)
                    Console.WriteLine();
                Console.WriteLine("Opción incorrecta");

            } while (keyInfo.Key != ConsoleKey.Enter && keyInfo.Key != ConsoleKey.Escape);

        } while (keyInfo.Key == ConsoleKey.Enter);


    }

}