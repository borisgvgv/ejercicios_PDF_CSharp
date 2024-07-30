// Ejemplo_04_04_06a.cs
// Cadenas de texto (6: manipulaciones diversas)
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_04_04_06a
{
    static void Main()
    {
        string ejemplo = "Hola, que tal estas"; //frase modelo

        Console.WriteLine("01 - El texto es: {0}", ejemplo);
        Console.WriteLine("02 - La primera letra es: {0}", ejemplo[0]);
        Console.WriteLine("03 - Las tres primeras letras son: {0}", ejemplo.Substring(0, 3));
        Console.WriteLine("04 - La longitud del texto es: {0}", ejemplo.Length);
        Console.WriteLine("05 - La posición de \"que\" es: {0}", ejemplo.IndexOf("que"));
        Console.WriteLine("06 - La ultima \"a\" esta en la posicion: {0}", ejemplo.LastIndexOf("a"));
        Console.WriteLine("07 - Pasamos el exto a mayúsculas: {0}", ejemplo.ToUpper());
        Console.WriteLine("08 - Pasamos el texto a minúsculas: {0}", ejemplo.ToLower());
        Console.WriteLine("09 - Si insertamos \", tío\": {0}", ejemplo.Insert(4, ", tío"));
        Console.WriteLine("10 - Si borramos las 6 primeras letras: {0}", ejemplo.Remove(0, 6));
        Console.WriteLine("11 - Si cambiamos ESTAS por ESTAMOS: {0}", ejemplo.Replace("estas", "estamos"));

        //Uso del método Contains
        string buscarPalabra = "tio";
        bool containsExample = ejemplo.Contains(buscarPalabra, StringComparison.OrdinalIgnoreCase);//El StringComparison.OrdinalIgnoreCase El parámetro se utiliza para una comparación que no distingue entre mayúsculas y minúsculas.

        if (containsExample)
        {
            Console.WriteLine($"La sentencia contiene la palabra '{buscarPalabra}'.");
        }
        else
        {
            Console.WriteLine($"La sentencia no contiene la palabra '{buscarPalabra}'.");
        }
        Console.WriteLine();
    }
}