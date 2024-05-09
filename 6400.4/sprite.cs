using System;

public class Sprite
{
    protected int x, y;
    protected string nave;

public Sprite()
    {
        x = 80;
        y = 20;
        nave = "";
    }
    public int GetX()
    {
        return x;
    }
    public int GetY()
    {
        return y;
    }
    public string GetNave()
    {
        return nave;
    }

    public void SetXY(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void SetXYN(int x, int y, string nave)
    {
        this.x = x;
        this.y = y;
        this.nave = nave;
    }
    public void Mostrar()
    {
        Console.Write(nave);
    }


}