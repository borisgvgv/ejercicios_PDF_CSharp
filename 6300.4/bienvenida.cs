using System;

public class Bienvenida{

  public void lanzar(){
    ConsoleKeyInfo tecla;
        do
        {
            Console.WriteLine("Bienvenido a Console Invaders. Pulse Intro para jugar");
            tecla = Console.ReadKey();

        } while (tecla.Key != ConsoleKey.Enter);

  }

}