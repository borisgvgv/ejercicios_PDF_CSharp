using System;
class Program
{
    static void Main()
    {

        Console.Clear();
        Persona persona = new Persona();
        PersonaInglesa personaInglesa = new PersonaInglesa();
        PersonaItaliana personaItaliana = new PersonaItaliana();



        personaInglesa.PedirYAsignarDatos();
        personaInglesa.Mostrar();
        personaInglesa.Saludar();

        Console.WriteLine();

        personaItaliana.PedirYAsignarDatos();
        personaItaliana.Mostrar();
        personaItaliana.Saludar();



    }
}