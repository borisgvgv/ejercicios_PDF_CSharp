using System;

class PersonaItaliana : Persona
{


    private string accion;
    private string nacionalidad;
    private string saludo;

    protected PedirDatos pedirDatos = new PedirDatos();


    public void PedirYAsignarDatos()
    {
        Console.WriteLine("Introduce los datos");
        nombre = pedirDatos.PedirNombre();
        saludo = "Ciao io sono";
        nacionalidad = "Italian";
        edad = pedirDatos.PedirEdad();
        Console.Write("Estás tomando té Si o No: ");
        accion = Console.ReadLine();
    }

    public void Saludar()
    {

        if (accion == "Si")
        {
            accion = "se sto bevendo il tè";
        }
        else
        {
            accion = "non bevo il tè";
        }

        Console.WriteLine("{0} {1}. Io ho  {2}, e {3}", saludo, nombre, nacionalidad, accion);
    }

    public new void Mostrar()
    {
        Console.WriteLine("Nombre: {0}", nombre);
        Console.WriteLine("Nacionalidad: {0}", nacionalidad);
        Console.WriteLine("Edad: {0}", edad);

    }

}