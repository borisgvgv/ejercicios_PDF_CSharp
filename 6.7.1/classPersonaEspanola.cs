using System;

public class classPersonaEspanola : Saludo
{

    protected string nombre;
    protected string saludo;

    public classPersonaEspanola()
    {
        nombre = "Boris";
    }
    public classPersonaEspanola(string newNombre)
    {
        nombre = newNombre;
    }

    public classPersonaEspanola(string newSaludo, string newNombre)
    {
        nombre = newNombre;
        saludo = newSaludo;

    }


    public new void MostrarSaludo()
    {
        System.Console.WriteLine("Hola soy {0}", nombre);
    }

    public new void MostrarSaludo2()
    {
        System.Console.WriteLine("{0} {1}", saludo, nombre);
    }

    public new void TomarTe()
    {
        System.Console.WriteLine("Estoy tomando té");
    }
}