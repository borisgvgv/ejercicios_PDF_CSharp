using System;

public class Program
{
    public static void Main()
    {
        Persona[] persona = new Persona[3];
        persona[0] = new Persona();
        persona[1] = new PersonaInglesa();
        persona[2] = new PersonaEspanola();

        persona[0].Saludo();
        persona[1].Saludo();
        persona[2].Saludo();
    }
}

public class Persona
{
    public virtual void Saludo()
    {
        System.Console.WriteLine("Hola soy una persona del mundo");
    }
}

public class PersonaInglesa : Persona
{
    public override void Saludo()
    {
        System.Console.WriteLine("Hola soy una persona inglesa");
    }
}
public class PersonaEspanola : Persona
{
    public override void Saludo()
    {
        System.Console.WriteLine("Hola soy una persona española");
    }
}