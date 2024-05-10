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

    public int GetX(){
        return x;
    }
    public int GetY(){
        return y;
    }

    public void SetXY(int x, int y){
        this.x = x;
        this.y = y;
    }

    public string GetEnemigo(){
        return enemigo;
    }

    public new void Mostrar()
    {
        Console.Write(enemigo);
    }

}