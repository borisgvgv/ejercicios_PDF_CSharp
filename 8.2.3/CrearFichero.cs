using System;
using System.IO;

public class CrearFichero
{
    protected string texto;
    public CrearFichero()
    {
        using (StreamWriter fichero = new StreamWriter("Fichero.txt"))
        {
            do
            {
                if (texto == null)
                {
                    System.Console.Write("Escribe un texto: ");
                    texto = Console.ReadLine();
                    if (texto != "" && texto != "fin")
                        fichero.WriteLine(texto);
                }
                else
                {
                    System.Console.Write("Añade un texto: ");
                    texto = Console.ReadLine();
                    if (texto != "" && texto != "fin")
                        fichero.WriteLine(texto);
                }

            } while (texto != "fin");
        }
    }
}