using System;
public class Juego
{


    public void Lanzar()
    {

        ConsoleKeyInfo tecla;
        do
        {
            Console.WriteLine("Bienvenido a Console Invaders. Pulse Intro para salir");
            tecla = Console.ReadKey();

        } while (tecla.Key != ConsoleKey.Enter);

    }

}

public class Program
{
    public static void Main()
    {

        Juego juego = new Juego();
        juego.Lanzar();

    }
}