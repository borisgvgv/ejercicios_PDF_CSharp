using System;

public class classWin
{

    public void Win()
    {

        classSalir salir = new classSalir();
        classPartida partida = new classPartida();
        ConsoleKeyInfo tecla;

        do
        {
            Console.Clear();

            System.Console.WriteLine("Has ganado la partida");
            System.Console.WriteLine("Enter para jugar ---- Escape para salir");
            tecla = Console.ReadKey(true);
  
        } while (tecla.Key != ConsoleKey.Escape && tecla.Key != ConsoleKey.Enter);

        if (tecla.Key == ConsoleKey.Escape)
        {
            salir.Salir();
        }
        else
        {
            partida.Partida();
        }


    }
}