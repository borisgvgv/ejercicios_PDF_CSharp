using System;

public class Lider : Sprite
{
    protected string lider;
    public Lider()
    {
        x = 80/2;
        y = 20/2;
        lider = "/\\";
    }

    public int GetX(){
        return x;
    }
    public int GetY(){
        return y;
            
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
