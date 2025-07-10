using System;
using System.IO;

public class CrearFichero
{
    protected string texto;
    public CrearFichero()
    {


        do
        {
            if (texto == null)
            {
                using (StreamWriter fichero = new StreamWriter("Fichero.txt"))
                {
                    System.Console.Write("Escribe un texto: ");
                    texto = Console.ReadLine();
                    if (texto != "" && texto != "fin")
                        fichero.WriteLine(texto);
                }
            }
            else
            {
                using (StreamWriter fichero = new StreamWriter("Fichero.txt", true))
                {
                    System.Console.Write("Añade un texto: ");
                    texto = Console.ReadLine();
                    if (texto != "" && texto != "fin")
                        fichero.WriteLine(texto);
                }
            }

        } while (texto != "fin");
    }
}
