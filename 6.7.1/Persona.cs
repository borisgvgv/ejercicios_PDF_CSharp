
using System;

public class Persona
{
    public static void Main()
    {

        Console.Clear();

        //-------------PesonaEspañola 1

        classPersonaEspanola personaEspanola1 = new classPersonaEspanola();
        System.Console.WriteLine("Hola cómo te llamas ?");
        personaEspanola1.MostrarSaludo();
        personaEspanola1.TomarTe();
        System.Console.WriteLine();

        //-------------PesonaEspañola 2

        System.Console.WriteLine("Hola cómo te llamas ?");
        string nombrePersonaEspanola2 = Console.ReadLine();
        classPersonaEspanola personaEspanola2 = new classPersonaEspanola(nombrePersonaEspanola2);
        personaEspanola2.MostrarSaludo();
        personaEspanola2.TomarTe();
        System.Console.WriteLine();

        //-------------PesonaEspañola 3

        System.Console.WriteLine("Escribe un saludo");
        string saludoPersonaEspanola3 = Console.ReadLine();
        System.Console.WriteLine("Como te llamas?");
        string nombrePersonaEspanola3 = Console.ReadLine();
        classPersonaEspanola personaEspanola3 = new classPersonaEspanola(saludoPersonaEspanola3, nombrePersonaEspanola3);
        personaEspanola3.MostrarSaludo();
        personaEspanola3.TomarTe();
        System.Console.WriteLine();

        //-------------Persona inglesa 1

        classPersonaInglesa pInglesa = new classPersonaInglesa();
        System.Console.WriteLine("Hola cómo te llamas ?");
        pInglesa.MostrarSaludo();
        pInglesa.TomarTe();
        System.Console.WriteLine();


        //-------------Persona inglesa 2


        System.Console.WriteLine("Hola cómo te llamas ?");
        string nombrePersonaInglesa = Console.ReadLine();
        classPersonaInglesa pInglesa2 = new classPersonaInglesa(nombrePersonaInglesa);
        pInglesa2.MostrarSaludo();
        pInglesa2.TomarTe();
        System.Console.WriteLine();


        //-------------Persona initaliana

        System.Console.WriteLine("Hola cómo te llamas ?");
        classPersonaItaliana pItaliana = new classPersonaItaliana();
        pItaliana.MostrarSaludo();
        pItaliana.TomarTe();
        System.Console.WriteLine();

        //-------------Persona italiana


        System.Console.WriteLine("Hola cómo te llamas ?");
        string nombrepItaliana2 = Console.ReadLine();
        classPersonaItaliana pItaliana2 = new classPersonaItaliana(nombrepItaliana2);
        pItaliana2.MostrarSaludo();
        pItaliana2.TomarTe();
        System.Console.WriteLine();


    }
}



