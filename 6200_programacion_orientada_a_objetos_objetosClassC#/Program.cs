using System;
public class Puerta
{

    int alto;
    int ancho;
    int color;
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

    public void MostrarEstado()
    {
        Console.WriteLine($"Alto: {alto}");
        Console.WriteLine($"Ancho: {ancho}");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Abierta: {abierta}");
    }


}
public class Program
{
    static void Main()
    {

        Puerta puerta = new Puerta();

        Console.WriteLine("Mostrar estado");
        puerta.MostrarEstado();

        Console.WriteLine();// salto de línea

        Console.WriteLine("Abrir puerta y mostrar estado");
        puerta.Abrir();
        puerta.Cerrar();
        puerta.GetAncho();
        puerta.SetAncho(80);
        puerta.MostrarEstado();



    }
}