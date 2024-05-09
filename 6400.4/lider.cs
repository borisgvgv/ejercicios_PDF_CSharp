using System;

public class Lider : Sprite
{
    protected string lider;
    public Lider()
    {
        x = 80 / 2;
        y = 20 / 2;
        lider = "/\\";
    }

    public string GetLider()
    {
        return lider;
    }

    public new void Mostrar()
    {
        Console.Write(lider);
    }

}
