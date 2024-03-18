using System;

class Nave
{
    protected int x;
    protected int y;

    public int X
    {
        get { return x; }
        set
        {
            if (value >= 0 && value <= 1023)
            {
                x = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("X debe estar entre 0 y 1023.");
            }
        }
    }

    public int Y
    {
        get { return y; }
        set
        {
            if (value >= 0 && value <= 767)
            {
                y = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Y debe estar entre 0 y 767.");
            }
        }
    }

    public Nave(int x, int y)
    {
        X = x;
        Y = y;
    }
}