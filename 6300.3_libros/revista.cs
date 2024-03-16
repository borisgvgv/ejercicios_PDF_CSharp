using System;

public class Revista : Libro
{

    bool estado;
    string estadoRevista;


    public void SetEstadoRevista(string nuevoEstado)
    {
        if (nuevoEstado == "si")
        {
            //estado = true;
            estadoRevista = nuevoEstado;
        }
        else if (nuevoEstado == "no")
        {
            //estado = false;
            estadoRevista = nuevoEstado;
        }
        else
        {
            Console.WriteLine("Estado incorrecto");
        }

    }
    public bool GetEstadoRevista()
    {
        return estado = false;
    }

    public new void mostrar()
    {
        Console.WriteLine("Numeración: {0}", numeracion);
        Console.WriteLine("Titulo: {0}", titulo);
        Console.WriteLine("Autor: {0}", autor);
        Console.WriteLine("Activa: {0}", estadoRevista);
    }


}