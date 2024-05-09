using System;

class PersonaInglesa : Persona
{


    private string accion;
    private string nacionalidad;
    private string saludo;

    protected PedirDatos pedirDatos = new PedirDatos();


    public void PedirYAsignarDatos()
    {
        Console.WriteLine("Introduce los datos");
        nombre = pedirDatos.PedirNombre();
        saludo = "Hi, I am";
        nacionalidad = "English";
        edad = pedirDatos.PedirEdad();
        Console.Write("Estas tomando té Si o No: ");
        accion = Console.ReadLine();
    }

    public void Saludar()
    {

        if (accion == "Si")
        {
            accion = "I am drinking tea";
        }
        else
        {
            accion = "I am not drinking tea";
        }

        Console.WriteLine("{0} {1}. I am {2}, and {3}", saludo, nombre, nacionalidad, accion);
    }

    public new void Mostrar()
    {
        Console.WriteLine("Nombre: {0}", nombre);
        Console.WriteLine("Nacionalidad: {0}", nacionalidad);
        Console.WriteLine("Edad: {0}", edad);

    }

}