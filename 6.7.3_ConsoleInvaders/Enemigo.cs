using System;

public class Enemigo
{
    protected int x;
    protected int y;
    protected char enemigo;

    public Enemigo(int newX, int newY)
    {
        x = newX;
        y = newY;
        enemigo = '=';
    }

    public void MostrarEnemigo()
    {
        Console.SetCursorPosition(x, y);
        System.Console.Write(enemigo);
    }
}

