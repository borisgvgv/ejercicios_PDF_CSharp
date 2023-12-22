// Ejemplo_05_11a.cs
// Parámetros por defecto
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_05_11a
{
    static string Linea(int veces, char letra = '*')
    {
        return new string(letra, veces);
    }

    

    static void Main()
    {
        Console.WriteLine(Linea(10, '-'));
        Console.WriteLine(Linea(12));

        // otra forma declararlo ---------------------

        /*
        Otra posibilidad avanzada (y reciente, y que existe en pocos lenguajes) es la de
        indicar los parámetros en un orden distinto al que se definieron. Para eso, en C#
        se debe preceder cada parámetro por su nombre, usando un símbolo de "dos
        puntos" como separador:
        */

        Console.WriteLine(Linea(letra: '=', veces: 8)); // como se muestra aquí

    }
}