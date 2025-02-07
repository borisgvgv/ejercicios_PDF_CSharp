using System;

public class classPersonaInglesa : Saludo
{

    protected string nombre;
    public classPersonaInglesa()
    {
        nombre = "Jhon";
    }

    public classPersonaInglesa(string newNombre)
    {
        nombre = newNombre;
    }

    public new void MostrarSaludo()
    {
        System.Console.WriteLine("Hy I'm {0}", nombre);
    }

    public new void TomarTe()
    {
        System.Console.WriteLine("I'm drinking a tea");
    }

}