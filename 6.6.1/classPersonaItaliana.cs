using System;

public class classPersonaItaliana : classSaludo
{

    protected string nombre;
    public classPersonaItaliana()
    {
        nombre = "Boris";
    }

    public classPersonaItaliana(string newNombre)
    {
        nombre = newNombre;
    }

    public new void TomarTe()
    {
        System.Console.WriteLine("Ciao, mi chiamo {0} e sto bevendo il tè.", nombre);
    }

}