using System;
using System.IO;


public class LeerFicha
{
    public LeerFicha()
    {
        
        using (StreamReader leerFichero = new StreamReader("registroDeUsuario.txt"))
        {
            string linea;
            while ((linea = leerFichero.ReadLine()) != null)
            {
                System.Console.WriteLine(linea);
            }
        }
    }

    public void MostrarEstado()
    {
        
    }


}