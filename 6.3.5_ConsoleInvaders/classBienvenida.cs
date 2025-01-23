using System;

public class classBienvenida()
{

    public void Bienvenida()
    {

        classPartida partida = new classPartida();
        classSalir salir = new classSalir();

        ConsoleKeyInfo tecla;

        do
        {

            System.Console.WriteLine("Bienvenido a Console Invaders");
            System.Console.WriteLine("Pulsa Enter para continuar o Escape para salir");
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