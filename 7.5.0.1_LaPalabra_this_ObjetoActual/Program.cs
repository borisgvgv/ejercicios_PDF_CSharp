using System;
public class Ejemplo_07_05b
{
    public static void Main()
    {
        Titulo t = new Titulo(38, 5, "Hola");
        Titulo t1 = new Titulo(10);
        t.Escribir();
        t1.Escribir();
    }
}
// ------------------
public class Titulo
{
    private int x;
    private int y;
    private string texto;
    public Titulo(int nuevaX, int nuevaY, string txt)
    {
        x = nuevaX;
        y = nuevaY;
        texto = txt;
    }
    public Titulo(int nuevaY, string txt) : this(40 - txt.Length / 2, nuevaY, txt)
    {
    }

    public Titulo(int nuevaY) : this(30, nuevaY, "Texto t1")
    {
        //en este constructor Titulo toma el valor nuevaY que le pasamos como parametro en la función Main
    }
    public void Escribir()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(texto);
    }
}