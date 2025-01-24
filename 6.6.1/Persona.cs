
using System;

public class Persona
{
    public static void Main()
    {
       
        Console.Clear();


        //-------------PesonaEspañola

        System.Console.WriteLine("Hola cómo te llamas ?");
        classSaludo saludo = new classSaludo();
        classPersonaEspanola pEspanola = new classPersonaEspanola();
        saludo.MostrarSaludo();
        pEspanola.TomarTe();
        System.Console.WriteLine();

        //-------------PesonaEspañola

        string nombrePersonaEspanola = "";
        System.Console.WriteLine("Hola cómo te llamas ?");
        nombrePersonaEspanola = Console.ReadLine();
        classSaludo saludoPersonaEspanola = new classSaludo(nombrePersonaEspanola);
        classPersonaEspanola pEspanola2 = new classPersonaEspanola(nombrePersonaEspanola);
        saludoPersonaEspanola.MostrarSaludo();
        pEspanola2.TomarTe();
        System.Console.WriteLine();

        //-------------Persona inglesa

        System.Console.WriteLine("Hola cómo te llamas ?");
        classPersonaInglesa pInglesa = new classPersonaInglesa();
        saludo.MostrarSaludo();
        pInglesa.TomarTe();
        System.Console.WriteLine();

        //-------------Persona inglesa

        string nombrePersonaInglesa = "";
        System.Console.WriteLine("Hola cómo te llamas ?");
        nombrePersonaInglesa = Console.ReadLine();
        classSaludo saludoPersonaInglesa = new classSaludo(nombrePersonaInglesa);
        classPersonaInglesa pInglesa2 = new classPersonaInglesa(nombrePersonaInglesa);
        saludoPersonaInglesa.MostrarSaludo();
        pInglesa2.TomarTe();
        System.Console.WriteLine();

        //-------------Persona initaliana

        System.Console.WriteLine("Hola cómo te llamas ?");
        classPersonaItaliana pItaliana = new classPersonaItaliana();
        saludo.MostrarSaludo();
        pItaliana.TomarTe();
        System.Console.WriteLine();

        //-------------Persona italiana

        string nombrePersonaItaliana = "";
        System.Console.WriteLine("Hola cómo te llamas ?");
        nombrePersonaItaliana = Console.ReadLine();
        classSaludo saludoPersonaItaliana = new classSaludo(nombrePersonaItaliana);
        classPersonaItaliana pItaliana2 = new classPersonaItaliana(nombrePersonaItaliana);
        saludoPersonaItaliana.MostrarSaludo();
        pItaliana2.TomarTe();
        System.Console.WriteLine();


    }
}



