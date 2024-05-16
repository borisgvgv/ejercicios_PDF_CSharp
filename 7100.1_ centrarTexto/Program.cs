using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Escribe un texto para centrarlo:");
        string texto = Console.ReadLine();

        CentrarTexto.TextoCentrar(texto);

        Console.WriteLine("Borrar pantalla al pulsar Enter");
        Console.ReadLine();

        Borrar.borrarPantalla();

    }
}
