using System;

public class classPersonaItaliana : classSaludo
{

    protected string nombre;
    public classPersonaItaliana()
    {
        nombre = "Jacomo";
    }

    public classPersonaItaliana(string newNombre)
    {
        nombre = newNombre;
    }

    public new void MostrarSaludo()
    {
        System.Console.WriteLine("Ciao, mi chiamo {0}",  nombre);
    }

    public new void TomarTe()
    {
        System.Console.WriteLine("Sto bevendo il tè.");
    }

}