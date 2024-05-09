using System;
class Program
{
    static void Main()
    {

     
        Persona persona = new Persona();
        PersonaInglesa personaInglesa = new PersonaInglesa();

        persona.PedirYAsignarDatos();
        persona.mostrar();
        
        personaInglesa.PedirYAsignarDatos();
        personaInglesa.mostrar();



    }
}