using System;

class Program
{

    public static void MostrarIniciales(ref string nombre)
    {

        for (int i = 0; i < nombre.Length; i++)
        {
            if (i == 0)
            {
                System.Console.Write($"{nombre[i]}.");
            }
            else if (nombre[i] == ' ')
            {
                if (i + 1 < nombre.Length) // Verificar que i+1 no esté fuera de rango.
                {
                    Console.Write($"{nombre[i + 1]}.");
                }
            }
        }
        System.Console.WriteLine();

    }
    static void Main()
    {
        Console.Clear();

        System.Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        MostrarIniciales(ref nombre);
    }
}