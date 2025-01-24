using System;

public class classPersonaInglesa : classSaludo
{

    protected string nombre;
    public classPersonaInglesa()
    {
        nombre = "Boris";
    }

    public classPersonaInglesa(string newNombre)
    {
        nombre = newNombre;
    }

    public new void TomarTe()
    {
        System.Console.WriteLine("Hy I'm {0}, and I'm drinking a tea", nombre);
    }

}