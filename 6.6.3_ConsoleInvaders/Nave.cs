using System;

public class Nave
{
    protected char nave;

    protected Win win = new Win();
    protected Salir salir = new Salir();

    public Nave()
    {
        nave = '*';
    }

    public void MostrarNave(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        System.Console.Write(nave);
    }

}