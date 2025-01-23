using System;

public class ClassPuerta
{

    protected int alto;
    protected int ancho;
    protected string color;
    protected bool estado;

    public int GetAlto()
    {
        return alto;
    }
    public void SetAlto(int newAlto)
    {
        alto = newAlto;
    }

    public int GetAncho()
    {
        return ancho;
    }
    public void SetAncho(int newAncho)
    {
        ancho = newAncho;
    }

    public string GetColor()
    {
        return color;
    }
    public void SetColor(string newColor)
    {
        color = newColor;
    }

    public bool GetEstado()
    {
        return estado;
    }
    public void SetEstado(bool newEstado)
    {
        estado = newEstado;
    }

    public void MostrarPuerta()
    {
        System.Console.WriteLine("Características de la puerta ");
        System.Console.WriteLine("Alto: {0}", alto);
        System.Console.WriteLine("Ancho: {0}", ancho);
        System.Console.WriteLine("Color: {0}", color);
        if (estado)
        {
            System.Console.WriteLine("Estado: abierta");
        }
        else
        {
            System.Console.WriteLine("Estado: cerrada");
        }
    }

}