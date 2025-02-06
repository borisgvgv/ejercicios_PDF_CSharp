using System;

public class Bienvenida
{

    protected Partida partida = new Partida();
    protected Salir salir = new Salir();
    protected ConsoleKeyInfo key;

    public void MostrarBienvenida()
    {

        bool opcion = false;

        do
        {
            Console.Clear();
            System.Console.WriteLine("Bienvenido a Console Invaders");
            System.Console.WriteLine("Enter = Jugar / Escape = Salir");
            key = Console.ReadKey(true);
            opcion = true;

        } while (!opcion);

        if (key.Key == ConsoleKey.Enter)
        {
            partida.MostrarPartida();
        }
        else
        {
            salir.MostrarSalir();
        }
    }
}