using System;
using System.IO;

public class CrearFicha
{
    public CrearFicha()
    {
        string texto = "";
        StreamWriter registroDeUsuario = new StreamWriter("registroDeUsuario.txt");

        do
        {
            Console.WriteLine("Introduce un texto");
            texto = Console.ReadLine();
            if (texto != "fin")
            {
                registroDeUsuario.WriteLine(texto);
            }

        } while (texto != "fin");

        registroDeUsuario.Close();

    }

    public void MostrarEstado()
    {
        
    }
    
}