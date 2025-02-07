using System;

public class classPersonaEspanola : classSaludo
{

    string nombre;
    public classPersonaEspanola(){
        nombre = "Boris";
    }
    public classPersonaEspanola(string newNombre)
    {
        nombre = newNombre;
    }

    public new void MostrarSaludo()
    {
        System.Console.WriteLine("Hola soy {0}", nombre);
    }
}