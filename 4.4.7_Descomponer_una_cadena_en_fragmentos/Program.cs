// Ejemplo_04_04_07a.cs
// Cadenas de texto: partir con "Split"
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_04_04_07a
{
    static void Main()
    {
        string ejemplo = "uno dos tres cuatro";
        char delimitador = ' ';

        string[] ejemploPartido = ejemplo.Split(delimitador);
        for (int i = 0; i < ejemploPartido.Length; i++)
            Console.WriteLine("Fragmento {0} = {1}",
            i, ejemploPartido[i]);

        Console.WriteLine();
        Console.WriteLine("Ejemplo 2  Split-----------------------------");
        Console.WriteLine();

        string ejemplo2 = "uno,dos.tres,cuatro cinco";
        char[] delimitadores = { ',', '.', ' ' };
        string[] ejemploPartido2 = ejemplo2.Split(delimitadores);
        for (int i = 0; i < ejemploPartido2.Length; i++)
            Console.WriteLine("Fragmento {0} = {1}",
            i, ejemploPartido2[i]);

        Console.WriteLine();
        Console.WriteLine("Ejemplo 3 Split-------------------------");
        Console.WriteLine("Si no se indica un delimitador en Split, se dará por sentado que sea desea partir empleando espacios");

        string ejemplo3 = "uno dos tres cuatro";
        string[] ejemploPartido3 = ejemplo3.Split();
        for (int i = 0; i < ejemploPartido3.Length; i++)
            Console.WriteLine("Fragmento {0} = {1}",
            i, ejemploPartido3[i]);


        Console.WriteLine();
        Console.WriteLine("Ejemplo 4 Strin.Join-------------------------------");
        Console.WriteLine();

        string ejemplo4 = "uno dos tres cuatro";
        string[] ejemploPartido4 = ejemplo4.Split();
        Console.WriteLine(String.Join(", ", ejemploPartido4));
        Console.WriteLine();
    }
}