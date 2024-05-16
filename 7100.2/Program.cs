using System;

public class Program
{
    public static void Main()
    {

        CentrarTexto centrarTexto = new CentrarTexto();
        Borrar borrar = new Borrar();


        Console.WriteLine("Introduce un texto para centrarlo");
        string texto = Console.ReadLine();
        centrarTexto.SetTexto(texto);
        centrarTexto.Mostrar();

        Console.WriteLine("Borrar pantalla al pulsar Enter");
        borrar.BorrarPantalla();


    }
}