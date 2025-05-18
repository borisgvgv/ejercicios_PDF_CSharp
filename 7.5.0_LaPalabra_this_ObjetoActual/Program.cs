using System;

public class Program
{
    public static void Main()
    {
        Texto t1 = new Texto(10, 10, "Texto1");
        Texto t2 = new Texto(40);

        t1.Mostrar();
        t2.Mostrar();

    }
}
public class Texto
{
    protected byte x;
    protected byte y;
    protected string texto;
    public Texto(byte x, byte y, string texto)
    {
        this.x = x;
        this.y = y;
        this.texto = texto;
    }
    public Texto(byte x) : this(x, 20, "Texto por defecto")
    {
        
    }
    public void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        System.Console.WriteLine(texto);
    }
}