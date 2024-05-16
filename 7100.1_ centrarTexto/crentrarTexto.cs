using System;

public class CentrarTexto
{
    public static void TextoCentrar(string texto)
    {
        int totalWidth = Console.WindowWidth;
        int length = texto.Length;

        if (totalWidth < length)
        {
            Console.WriteLine("El texto no cabe en la pantalla.");
            return;
        }

        int espacios = (totalWidth - length) / 2;
        Console.WriteLine(texto.PadLeft(espacios + length));
        /*
        for (int i = 0; i < espacios; i++)
        {
            Console.Write(" ");
        }
        Console.Write(texto);
        for (int i = 0; i < espacios; i++)
        {
            Console.Write(" ");
        }
        */


    }

}

