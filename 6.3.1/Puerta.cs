using System;

public class Puerta
{
    public static void Main()
    {

        Console.Clear();
        ClassPuerta p = new ClassPuerta();
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