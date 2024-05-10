using System;

public class Bienvenida
{

    protected string bienvenida;

    public Bienvenida()
    {
        bienvenida = "   **** BIENVENIDOS A CONSOLE INVADERS ****   ";
    }

    public void Mostrar()
    {
        Console.WriteLine();
        Console.WriteLine(bienvenida);
        Console.WriteLine();
    }
}