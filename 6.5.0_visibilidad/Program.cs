using System;
public class Ejemplo_06_05a
{
    public static void Main()
    {
        Puerta p = new Puerta();
        Console.WriteLine("Valores iniciales...");
        p.MostrarEstado();
        Console.WriteLine();
        Console.WriteLine("Vamos a abrir...");
        p.Abrir();
        p.SetAncho(80);
        p.MostrarEstado();
        Console.WriteLine();
        Console.WriteLine("Ahora el portón...");
        Porton p2 = new Porton();
        p2.SetAncho(300);
        p2.Bloquear();
        p2.MostrarEstado();
    }
}
// ------------------------------------------
// Puerta.cs
// Clases, get y set
// Introducción a C#, por Nacho Cabanes
public class Puerta
{
    protected int ancho; // Ancho en centimetros
    protected int alto; // Alto en centimetros
    protected int color; // Color en formato RGB
    protected bool abierta; // Abierta o cerrada
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
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Abierta: {0}", abierta);
    }
} // Final de la clase Puerta
// ------------------------------------------
// Porton.cs
// Clase que hereda de Puerta
// Introducción a C#, por Nacho Cabanes
public class Porton : Puerta
{
    bool bloqueada;
    public void Bloquear()
    {
        bloqueada = true;
    }
    public void Desbloquear()
    {
        bloqueada = false;
    }
    public new void MostrarEstado()
    {
        Console.WriteLine("Portón.");
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Abierta: {0}", abierta);
        Console.WriteLine("Bloqueada: {0}", bloqueada);
    }
}