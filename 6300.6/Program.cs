using System;

class Nave
{
    private int x;
    private int y;

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

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de uso de la clase Nave
        try
        {
            Nave miNave = new Nave(512, 384); // Crear una nave en el centro de la pantalla
            Console.WriteLine("Posición de la nave: X = {0}, Y = {1}", miNave.X, miNave.Y);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
