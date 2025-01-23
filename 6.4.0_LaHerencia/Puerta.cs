using System;

public class Puerta
{

    public static void Main()
    {
        Console.Clear();
        ClassPuerta puerta = new ClassPuerta();

        puerta.SetAlto(120);
        puerta.SetAncho(60);
        puerta.SetColor("rojo");
        puerta.SetEstado(false);
        puerta.MostrarPuerta();

        System.Console.WriteLine();//Salto de línea

        ClassPorton porton = new ClassPorton();
        porton.SetAlto(400);
        porton.SetAncho(200);
        porton.SetColor("Verde");
        porton.SetEstado(true);
        porton.SetEstadoDeBloqueo(false);
        porton.MonstrarEstado();


    }

}