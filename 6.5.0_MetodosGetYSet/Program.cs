/*Ejemplo extraido de chatgpt*/
using System;
public class Program
{
    public static void Main()
    {
        Persona p = new Persona("Ana");
        System.Console.WriteLine(p.Nombre);

        p.Nombre = "Pedro";
        System.Console.WriteLine(p.Nombre);
    }
}

public class Persona
{
    protected string nombre;

    //Propiedad publica con metodos get y set
    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                nombre = value;
            }
            else
            {
                Console.WriteLine("El nombre está vacío.");
            }
        }
    }

    //Constructor
    public Persona(string nombre)
    {
        this.nombre = nombre;
    }
}