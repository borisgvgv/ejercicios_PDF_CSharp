using System;

public class classPartida
{
    public void Partida()
    {
        ConsoleKeyInfo tecla;
        classSalir salir = new classSalir();

        do
        {
            System.Console.WriteLine("Estás en una partida");
            System.Console.WriteLine("Presiona escape si quiere abandonar");
            tecla = Console.ReadKey(true);

        } while (tecla.Key != ConsoleKey.Escape);

        salir.Salir();

    }
}