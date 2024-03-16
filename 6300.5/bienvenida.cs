using System;
public class Bienvenida
{
    private bool salir = false;

    Partida partida = new Partida();

    public void Lanzar()
    {
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a Console Invaders. Pulse Intro para jugar o ESC para salir");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Enter)
                partida.Lanzar();
            if (keyInfo.Key == ConsoleKey.Escape)
                salir = true;
                
        }
    }

}