using System;

public class Persona
{

    protected string nombre;
    protected int edad;


    public void SetNombre(string nuevoNombre)
    {
        nombre = nuevoNombre;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public void SetEdad(int nuevaEdad)
    {
        edad = nuevaEdad;
    }

    public int GetEdad()
    {
        return edad;
    }


    public void Saludar()
    {
        Console.WriteLine("Hola soy {0} y tengo {1} tacos", nombre, edad);
    }


}

