using System;

class ConstruirPorton : ConstruirPuerta
{

    Porton porton = new Porton();
    bool estado;
    public new void construir()
    {
        Console.WriteLine("Construye un Portón");
        Console.Write("Ancho: "); int ancho = Convert.ToInt32(Console.ReadLine());
        Console.Write("Alto: "); int alto = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Color");
        Console.Write("r: "); int r = Convert.ToInt32(Console.ReadLine());
        Console.Write("g: "); int g = Convert.ToInt32(Console.ReadLine());
        Console.Write("b: "); int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Abierto o cerrado?");
        string opcion = Console.ReadLine();
        if (opcion == "Abierta")
        {
            estado = true;
        }
        else
        {
            estado = false;
        }


        porton.mostrar(ancho, alto, r, g, b, estado);
    }

}