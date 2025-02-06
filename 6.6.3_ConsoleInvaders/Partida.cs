using System;

public class Partida
{
    protected DibujarPartida dibujarPartida = new DibujarPartida();
    public void MostrarPartida()
    {
        Console.Clear();
        System.Console.WriteLine("Estás en una partida");
        System.Console.WriteLine();
        dibujarPartida.MostrarDibujarPartida();
    }
}