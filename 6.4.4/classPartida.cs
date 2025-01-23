using System;

public class classPartida
{
    public void Partida()
    {
        Console.Clear();
    
        classDibujarPartida dibujarPArtida = new classDibujarPartida();
        //classSalir salir = new classSalir();

        Random random = new Random();

        int x = random.Next(0, 78);
        int y = random.Next(0, 23);

        int enemigoX = random.Next(0, 78);
        int enemigoY = random.Next(0, 23);

        dibujarPArtida.SetMoverNave(x, y);
        dibujarPArtida.SetMoverEnemigo(enemigoX, enemigoY);
        dibujarPArtida.DibujarPartida();

    }
}