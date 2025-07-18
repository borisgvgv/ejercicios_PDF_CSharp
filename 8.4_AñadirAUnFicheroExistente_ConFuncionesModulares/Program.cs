/*
La idea es sencilla: en vez de abrirlo con CreateText ("crear texto"), usaremos
AppendText ("añadir texto"). Por ejemplo, podríamos crear un fichero, guardar
información, cerrarlo, y luego volverlo a abrir para añadir datos, de la siguiente
forma:
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        string nombreFicha = "ficha.txt";
        StreamWriter fichero = File.CreateText(nombreFicha);
        StreamReader leerFichero = File.OpenText(nombreFicha);


        CrearFicha(ref fichero, ref nombreFicha);
        AddTexto(ref fichero, ref nombreFicha);
        LeerFicha(ref leerFichero, ref nombreFicha);
    }

//Función modular CrearFicha
    public static void CrearFicha(ref StreamWriter fichero, ref string nombreFicha)
    {
        fichero.WriteLine("Primera Linea");
        fichero.Close();
    }

//Función modular AddTexto
    public static void AddTexto(ref StreamWriter fichero, ref string nombreFicha)
    {
        fichero = File.AppendText(nombreFicha);
        System.Console.Write("Añade un texto: ");
        string texto = Console.ReadLine();
        fichero.WriteLine(texto);
        fichero.Close();
    }


//Función modular LeerFicha
    public static void LeerFicha(ref StreamReader leerFichero, ref string nombreFicha)
    {

        string linea;
        leerFichero = File.OpenText(nombreFicha);
        do
        {
            linea = leerFichero.ReadLine();
            if (linea != null)
                System.Console.WriteLine(linea);

        } while (linea != null);
        leerFichero.Close();
    }
}
