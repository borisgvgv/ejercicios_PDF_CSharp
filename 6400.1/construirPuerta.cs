using System;

public class ConstruirPuerta
{

    Puerta puerta = new Puerta();
    protected bool estado;

    public void construir()
    {
        Console.WriteLine("Construye una puerta");
        Console.Write("Ancho: "); int ancho = Convert.ToInt32(Console.ReadLine());
        Console.Write("Alto: "); int alto = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Color");
        Console.Write("r: "); int r = Convert.ToInt32(Console.ReadLine());
        Console.Write("g: "); int g = Convert.ToInt32(Console.ReadLine());
        Console.Write("b: "); int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Abierta o cerrada?");
        string opcion = Console.ReadLine();
        if (opcion == "Abierta")
        {
            estado = true;
        }
        else
        {
            estado = false;
        }

        puerta.mostrar(ancho, alto, r, g, b, estado);
    }

}