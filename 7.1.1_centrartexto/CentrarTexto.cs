using System;

public class CentrarTexto
{

    public static void CentrarTextoEnPantalla(string texto)
    {

        int anchoConsola = Console.WindowWidth;
        int posicion = (anchoConsola - texto.Length) / 2;

        Console.SetCursorPosition(posicion, Console.CursorTop);
        Console.WriteLine(texto);

    }

    public static void Main()
    {

        System.Console.WriteLine("Escribe un texto");
        string texto = Console.ReadLine();

        CentrarTexto.CentrarTextoEnPantalla(texto);

    }
}
