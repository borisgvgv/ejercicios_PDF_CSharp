/*
(5.7.2) Crea una función "Iniciales", que reciba una cadena como "Nacho Cabanes"
y devuelva las letras N y C (primera letra, y letra situada tras el primer espacio),
usando parámetros por referencia. Crea un "Main" que te permita comprobar que
funciona correctamente.
*/
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("Nombre y apellidos");
        string n = Console.ReadLine();
        Iniciales(ref n);

    }

    public static void Iniciales(ref string n)
    {
        string[] partes;
        partes = n.Split(new char[] {' ',',','.',';'}, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < partes.Length; i++)
        {
            System.Console.Write(partes[i][0]);
        }
        System.Console.WriteLine();
       
        

    }
}