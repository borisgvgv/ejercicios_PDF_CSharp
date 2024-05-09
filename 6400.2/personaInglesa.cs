using System;

class PersonaInglesa : Persona
{

   string accion;
  


     public void PedirYAsignarDatos()
    {
        Console.WriteLine("Introduce los datos");
        nombre = pedirDatos.PedirNombre();
        nacionalidad = pedirDatos.PedirNacionalidad();
        edad = pedirDatos.PedirEdad();
        Console.Write("Estas tomando té Si o No: ");
        accion = Console.ReadLine();
    }

    public new void mostrar()
    {
        Console.WriteLine("Nombre: {0}", nombre);
        Console.WriteLine("Nacionalidad: {0}", nacionalidad);
        Console.WriteLine("Edad: {0}", edad);

        if(accion == "Si"){
            Console.WriteLine("Estoy Tomando un té");
        }else{
            Console.WriteLine("No estoy tomando té");
        }
    }

}