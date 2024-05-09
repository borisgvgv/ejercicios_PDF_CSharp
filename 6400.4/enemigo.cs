using System;

public class Enemigo : Sprite
{

    protected string enemigo;
    
    public Enemigo()
    {
        x= 80/4;
        y= 20/4;
        enemigo = "][";
    }

    public string GetEnemigo(){
        return enemigo;
    }

    public new void Mostrar()
    {
        Console.Write(enemigo);
    }

}