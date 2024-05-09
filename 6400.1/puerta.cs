using System;
using System.Drawing;
public class Puerta
{
    protected int ancho;
    protected int alto;
    protected int r, g, b;
    protected Color color;
    protected bool estado;


    //constructores --------------------
    public Puerta()
    {
        ancho = 30;
        alto = 90;
        r = 22; g = 30; b = 30;
        color = Color.FromArgb(r, g, b);
        estado = false;

    }

    public Puerta(int ancho, int alto)
    {
        this.ancho = ancho;
        this.alto = alto;
        color = Color.FromArgb(r, g, b);
        estado = false;
    }

    // Gets y Sets---------------------------

    public int GetAncho()
    {
        return ancho;
    }
    public void SetAncho(int ancho)
    {
        this.ancho = ancho;
    }

    public int GetAlto()
    {
        return alto;
    }
    public void SetAlto(int alto)
    {
        this.alto = alto;
    }

    public Color GetColor()
    {
        return color;
    }
    public void SetColor(Color color)
    {
        this.color = color;
    }

    public void Abrir()
    {
        estado = true;
    }
    public void Cerrar()
    {
        estado = false;
    }


    public void mostrar()
    {
        Console.WriteLine("Puerta");
        Console.WriteLine("Ancho: {0} ", ancho);
        Console.WriteLine("Alto: {0} ", alto);
        Console.WriteLine("Color: {0}", color);
        if (estado)
        {
            Console.WriteLine("Estado: Abierta");
        }
        else
        {
            Console.WriteLine("Estado: Cerrada");
        }

        Console.WriteLine();
    }

    public void mostrar(int ancho, int alto, int r, int g, int b, bool estado)
    {

        color = Color.FromArgb(r, g, b);

        Console.WriteLine("Puerta");
        Console.WriteLine("Ancho: {0} ", ancho);
        Console.WriteLine("Alto: {0} ", alto);
        Console.WriteLine("Color: {0}", color);
        if (estado)
        {
            Console.WriteLine("Estado: Abierta");
        }
        else
        {
            Console.WriteLine("Estado: Cerrada");
        }

        Console.WriteLine();

    }


}