using System;
using System.Drawing;

public class Coche
{

    public Coche()
    {
        // Constructor vacío
    }


    private string marca;

    private int r, g, b;
    private Color color;
    private double potencia;



    public string GetMarca()
    {
        return marca;
    }
    /*
    public int GetR()
    {
        return r;
    }
    public int GetG()
    {
        return g;
    }
    public int GetB()
    {
        return b;
    }
    */

    public Color GetColor()
    {
        return color;
    }

    public double GetPotencia()
    {
        return potencia;
    }



    public void SetDatosCoche(string marca, int r, int g, int b, double potencia)
    {
        this.marca = marca;
        this.r = r;
        this.g = g;
        this.b = b;
        this.color = Color.FromArgb(r, g, b);
        this.potencia = potencia;
    }

    public void mostrarCoche()
    {
        Console.WriteLine();
        Console.WriteLine("Marca: {0}", marca);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Potencia: {0} cilindros", potencia);
    }


}