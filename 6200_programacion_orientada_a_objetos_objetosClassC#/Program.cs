
using System;
using System.Drawing;
public class Puerta
{

    int alto = 100;
    int ancho = 100;
    Color color;
    bool abierta;
    public void Abrir()
    {
        abierta = true;
    }
    public void Cerrar()
    {
        abierta = false;
    }
    public int GetAncho()
    {
        return ancho;
    }
    public void SetAncho(int nuevoValor)
    {
        ancho = nuevoValor;
    }

    public Color GetColor()
    {
        return color = Color.FromArgb(255, 133, 0);
    }
    

    public void MostrarEstado()

    
    {
        Console.WriteLine($"Alto: {alto}");
        Console.WriteLine($"Ancho: {ancho}");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Estado: {abierta}");
    }


}
public class Program
{
    static void Main()
    {

        Puerta puerta = new Puerta();

        Console.WriteLine("Mostrar estado");
        puerta.Cerrar();       
        puerta.MostrarEstado();
        Console.WriteLine();// salto de línea

        Console.WriteLine("Abrir puerta y mostrar estado");
        puerta.Abrir();//devuelve true en Estado;
        puerta.SetAncho(30);
        puerta.SetAncho(80);
        puerta.GetColor();
        puerta.MostrarEstado();



    }
}