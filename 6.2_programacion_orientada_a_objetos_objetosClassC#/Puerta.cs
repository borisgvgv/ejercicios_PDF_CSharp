using System;

public class Puerta
{
    int alto;
    int ancho;
    string color;
    bool estado;

    public void Abierta()
    {
        estado = true;
    }
    // No es necesario crear un método cerrar porque por defecto estado es false;

    //Metodos Get y Set

    public int GetAlto()
    {
        return alto;
    }

    public void SetAlto(int nuevoAlto)
    {
        alto = nuevoAlto;
    }

    public int GetAncho()
    {
        return ancho;
    }

    public void SetAncho(int nuevoAncho)
    {
        ancho = nuevoAncho;
    }


    public string GetColor()
    {
        return color;
    }

    public void SetColor(string nuevoColor)
    {
        color = nuevoColor;
    }

     public bool GetEstado()
    {
        return estado;
    }

    public void SetEstado(bool nuevoEstado)
    {
        estado = nuevoEstado;
    }

    


    public void MostrarEstado()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Alto: {0}", alto);
        System.Console.WriteLine("Ancho: {0}", ancho);
        System.Console.WriteLine("Color: {0}", color);
        System.Console.WriteLine("Estado: {0}", estado);
    }
}


public class ProgramPuerta
{
    public static void Main()
    {

        Console.Clear();
        Puerta p = new Puerta();
        System.Console.WriteLine("Estado actual de la puerta");
        p.Abierta(); //No es necesario crear un método cerrar porque por defecto estado es false;
        p.MostrarEstado();

        System.Console.WriteLine();

        System.Console.WriteLine("Estado actual de la puerta");
        p.SetAlto(120);
        p.SetAncho(80);
        p.SetColor("Red");
        p.SetEstado(false); //No es necesario crear un método cerrar porque por defecto estado es false;
        p.MostrarEstado();

    }
}