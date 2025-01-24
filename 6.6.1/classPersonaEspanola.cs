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

    public new void TomarTe()
    {
        System.Console.WriteLine("Hola soy {0}, y estoy tomando té", nombre);
    }
}