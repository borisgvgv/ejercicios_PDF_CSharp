using System;
public class Program
{
    public static void Main()
    {

        Puerta puerta1 = new Puerta();
        Puerta puerta2 = new Puerta(200, 600);
        ConstruirPuerta construirPuerta = new ConstruirPuerta();

        Porton porton1 = new Porton();
        ConstruirPorton construirPorton = new ConstruirPorton();


        puerta1.Abrir();
        puerta1.mostrar();

        construirPuerta.construir();

        porton1.Abrir();
        porton1.mostrar();
        construirPorton.construir();

    }
}