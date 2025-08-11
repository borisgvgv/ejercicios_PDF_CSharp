/*
 Recomendación práctica
En proyectos serios para evitar sorpresas se recomienda ser explicito en cuanto al uso del UTF8
Máximisa la compatibilidad del enguaje multiplataforma.

// UTF-8 sin BOM
using (var archivo = new StreamWriter(nombreArchivo, append: true, encoding: new UTF8Encoding(false)))
{
    archivo.WriteLine("Hola mundo");
}

// Si quieres UTF-8 con BOM (por compatibilidad con algunas apps Windows):
using (var archivo = new StreamWriter(nombreArchivo, append: true, encoding: new UTF8Encoding(true)))
{
    archivo.WriteLine("Hola mundo");
}

*/


using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        System.Console.Write("Nombre del archivo: ");
        string nombreArchivo = Console.ReadLine() + ".txt";

        //Creamos archivo
        using (StreamWriter archivo = new StreamWriter(nombreArchivo, append: true, new System.Text.UTF8Encoding(false)))
        {
            string texto;
            System.Console.WriteLine("Añade texto al archivo");

            do
            {
                texto = Console.ReadLine();
                if (texto != "fin")
                    archivo.WriteLine(texto);
            } while (texto != "fin");
        }

        //Leemos bytes
        try
        {
            using (FileStream leerBinario = new FileStream(nombreArchivo, FileMode.Open))
            {
                int byteLeido;
                while ((byteLeido = leerBinario.ReadByte()) != -1)
                {
                    byte unDato = (byte)byteLeido;
                    if (unDato == 13)
                    {
                        continue;
                    }
                    else if (unDato == 10)
                    {
                        System.Console.WriteLine();
                    }
                    else
                    {
                        System.Console.Write("{0}", unDato);
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error al abrir el archivo: {ex.Message}");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("No tienes permisos para leer este archivo.");
        }
        catch(Exception e)
        {
            Console.WriteLine("Error" + e.Message);
        }

    }
}