using System;

public class Saludar
{
    public static void Main()
    {

        Persona newPersona = new Persona();

        newPersona.SetNombre("Boris");
        newPersona.SetEdad(46);
        newPersona.Saludar();
    }
}