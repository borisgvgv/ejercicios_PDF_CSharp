using System;

/*

6.2.2) Tras leer la descripción de Space Invaders que vimos en el apartado
anterior, crea una clase Juego,que sólo contenga un método Lanzar, void, sin
parámetros, que escriba en pantalla "Bienvenido a Console Invaders. Pulse Intro
para salir" y se parará hasta que el usuario pulse Intro. Prepara también un Main
(en la misma clase), que cree un objeto de la clase Juego y lo lance.

*/


public class Juego
{

    public void Lanzar()
    {


        do
        {

            System.Console.WriteLine("Bienvenido Space Invaders");
            System.Console.WriteLine("Pulse intro para salir");

        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);

    }

}

public class ProgramJuego
{

    public static void Main()
    {
        Juego juego = new Juego();
        juego.Lanzar();
        System.Console.WriteLine("Hasta pronto");
    }

}
