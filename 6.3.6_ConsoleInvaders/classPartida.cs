using System;

public class classPartida
{
    public void Partida()
    {
        Console.Clear();
        classNave nave = new classNave();
        classSalir salir = new classSalir();

        int x = 5;
        int y = 5;

        nave.MoverA(x, y);
        nave.DibujarPartida();

    }
}