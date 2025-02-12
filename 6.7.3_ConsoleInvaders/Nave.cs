using System;

public class Nave
{
    protected char nave = '*';
    protected int x;
    protected int y;

    public Nave()
    {
        x = 10;
        y = 10;
    }

    public void MostrarNave()
    {
        System.Console.Write(nave);
    }

}