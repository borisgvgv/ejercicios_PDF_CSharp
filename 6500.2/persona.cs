using System;
class Persona
{

    PedirDatos pedirDatos = new PedirDatos();

    protected string nombre;
    protected string nacionalidad;
    protected int edad;

    public Persona()
    {
        nombre = "Indefinido";
        nacionalidad = "indefinida";
        edad = 0;
    }

    public string GetNombre()
    {
        return nombre;
    }
    public string GetNacionalidad()
    {
        return nacionalidad;
    }
    public int GetEdad()
    {
        return edad;
    }
    
    public void SetDatos(string nombre, string nacionalidad, int edad)
    {
        this.nombre = nombre;
        this.nacionalidad = nacionalidad;
        this.edad = edad;
    }

    public void PedirYAsignarDatos()
    {
        Console.WriteLine("Introduce los datos");
        nombre = pedirDatos.PedirNombre();
        nacionalidad = pedirDatos.PedirNacionalidad();
        edad = pedirDatos.PedirEdad();
    }


    public void Mostrar()
    {
        Console.WriteLine("Nombre: {0}", nombre);
        Console.WriteLine("Nacionalidad: {0}", nacionalidad);
        Console.WriteLine("Edad: {0}", edad);
    }

}