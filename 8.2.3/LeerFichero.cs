using System;
using System.IO;

public class LeerFirchero
{
    protected string linea;
    public LeerFirchero()
    {
        using (StreamReader leerfichero = new StreamReader("Fichero.txt"))
        {
            do
            {
                linea = leerfichero.ReadLine();
                if (linea != null)
                    System.Console.WriteLine(linea);

            } while (linea != null);
        }
    }
}