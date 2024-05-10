using System;

public class Sprite
{
    protected int x, y;

public Sprite()
    {
        x = 80;
        y = 20;
       
    }
    public int GetX()
    {
        return x;
    }
    public int GetY()
    {
        return y;
    }
  
    public void SetXY(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

}