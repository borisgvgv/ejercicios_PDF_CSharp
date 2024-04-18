using System;

public class Enemigo
{

    protected int x = 10, y = 5;

    public int GetX()
    {
        return x;
    }
    public int GetY()
    {
        return y;
    }

    public void SetX(int newX)
    {
        x = newX;
    }
    public void SetY(int newY)
    {
        y = newY;
    }

    public void printEnemigo()
    {
        Console.Write("][");
    }

}