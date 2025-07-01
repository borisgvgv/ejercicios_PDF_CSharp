using System;
using System.IO;

public class AddDatos
{
    protected string nuevoDato;
    public AddDatos()
    {

        using (StreamWriter addDatos = new StreamWriter("registroDeUsuario.txt", true))
        {
            System.Console.WriteLine("Añade el nuevo dato:");
            nuevoDato = Console.ReadLine();
            addDatos.WriteLine(nuevoDato);
        }
    }

}