using System;
public class Persona{

    string nombre = "";
    int edad;

    public string GetNombre()
    {
        return nombre;
    }
    public void SetNombre(string nuevoNombre)
    {
        nombre = nuevoNombre;
    }

    public int GetEdad()
    {
        return edad;
    }
    public void SetEdad(string nuevaEdad)
    {
        edad = nuevaEdad;
    }

    public void MostrarEstado(){
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
    }

}

public class Program
{
    public static void Main()
    {
        Persona p = new Persona();

        p.nombre("Boris");
        p.edad(46);

        p.MostrarEstado();

    }
}

