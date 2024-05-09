using System;
using System.Drawing;

class Porton : Puerta
{


    bool estado;
    public void Abrir()
    {
        estado = true;
    }
    public void Cerrar()
    {
        estado = false;
    }
    
    public new void mostrar()
    {
        Console.WriteLine("Portón");
        Console.WriteLine("Ancho: {0} ", ancho);
        Console.WriteLine("Alto: {0} ", alto);
        Console.WriteLine("Color: {0}", color);
        if (estado)
        {
            Console.WriteLine("Estado: Abierto");
        }
        else
        {
            Console.WriteLine("Estado: Cerrado");
        }

        Console.WriteLine();
    }

     public void mostrar(int ancho, int alto, int r, int g, int b, bool estado)
    {

        color = Color.FromArgb(r, g, b);

        Console.WriteLine("Portón");
        Console.WriteLine("Ancho: {0} ", ancho);
        Console.WriteLine("Alto: {0} ", alto);
        Console.WriteLine("Color: {0}", color);
        if (estado)
        {
            Console.WriteLine("Estado: Abierto");
        }
        else
        {
            Console.WriteLine("Estado: Cerrado");
        }

        Console.WriteLine();

    }

}