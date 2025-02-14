using System;


public class TextoCentrado
{
    public static void Main()
    {
        System.Console.WriteLine("Texto");
        string texto = Console.ReadLine();
        CentraTexto centraTexto = new CentraTexto(texto); 

    }
}

public class CentraTexto
{
    public CentraTexto(string texto)
    {
        int posicion = (Console.WindowWidth - texto.Length) / 2;
        Console.SetCursorPosition(posicion, Console.CursorTop);
        System.Console.WriteLine(texto);

    }
}
