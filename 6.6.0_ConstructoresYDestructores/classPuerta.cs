using System;

public class classPuerta
{
    protected int alto;
    protected int ancho;
    protected string color;
    protected bool estado;

    public classPuerta()
    {

        alto = 120;
        ancho = 60;
        color = "Roja";
        estado = true;

    }
    public classPuerta(int newAlto, int newAncho)
    {

        alto = newAlto;
        ancho = newAncho;
        color = "Verde";
        estado = false;

    }

    public bool GetAbiertaOSerrada()
    {
        return estado;
    }

    public void SetAbiertaOSerrada(bool newEstado)
    {
        estado = newEstado;
    }

    public void MostrarPuerta()
    {
        System.Console.WriteLine("Características");
        System.Console.WriteLine("Alto: {0}", alto);
        System.Console.WriteLine("Ancho: {0}", ancho);
        System.Console.WriteLine("Color: {0}", color);
        if (estado)
        {
            System.Console.WriteLine("Estado: Abierta");
        }
        else
        {
            System.Console.WriteLine("Estado: Cerrada");
        }
    }

}