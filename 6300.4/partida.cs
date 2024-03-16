using System;

public class Partida{

  public void lanzar(){
    ConsoleKeyInfo tecla;
        do
        {
            Console.WriteLine("Esta sería la pantalla de juego. Pulse Intro para salir");
            tecla = Console.ReadKey();

        } while (tecla.Key != ConsoleKey.Enter);

  }

}