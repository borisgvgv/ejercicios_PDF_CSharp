using System;
public class Nave
{

    protected int x , y ;

    protected string imagen = "/\\";

    public int GetX()
    {
        return x;
    }
    public int GetY()
    {
        return y;
    }
    
/*
    public void SetX(int newX){
        x = newX;
    }
    public  void SetY(int newY){
        y = newY;
    }
*/

    public void printNave()
    {
        Console.Write(imagen);
    }

    public void moverNave(int newX, int newY)
    {
        x = newX;
        y = newY;
    }



}