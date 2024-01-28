/*
(5.7.2.2) Crea una función "Iniciales", que reciba una cadena como "Nacho
Cabanes" y devuelva las letras N y C (primera letra, y letra situada tras el primer
espacio), usando parámetros por referencia. Crea un "Main" que te permita
comprobar que funciona correctamente.
*/

using System;

class Program
{
    static void Main()
    {
        string nombreCompleto = "Nacho Cabanes";
        char primeraLetra, segundaLetra;

        Iniciales(nombreCompleto, out primeraLetra, out segundaLetra);

        Console.WriteLine("Primera letra: " + primeraLetra);
        Console.WriteLine("Segunda letra: " + segundaLetra);
    }

    static void Iniciales(string nombreCompleto, out char primeraLetra, out char segundaLetra)
    {
        primeraLetra = ' '; // Carácter nulo por defecto
        segundaLetra = ' ';

        if (!string.IsNullOrEmpty(nombreCompleto))
        {
            // Dividir el nombre completo en palabras
            string[] palabras = nombreCompleto.Split(' ');

            // Obtener la primera letra del primer nombre
            if (palabras.Length > 0 && palabras[0].Length > 0)
            {
                primeraLetra = palabras[0][0];
            }

            // Obtener la primera letra del segundo nombre si existe
            if (palabras.Length > 1 && palabras[1].Length > 0)
            {
                segundaLetra = palabras[1][0];
            }
        }
    }
}
