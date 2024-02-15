// Ejemplo_04_04_06a.cs
// Cadenas de texto (6: manipulaciones diversas)
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_04_04_06a
{
    static void Main()
    {
        string ejemplo = "Hola, que tal estas";
        Console.WriteLine("El texto es: {0}", ejemplo);
        Console.WriteLine("La primera letra es: {0}", ejemplo[0]);
        Console.WriteLine("Las tres primeras letras son: {0}", ejemplo.Substring(0, 3));
        Console.WriteLine("La longitud del texto es: {0}", ejemplo.Length);
        Console.WriteLine("La posición de \"que\" es: {0}", ejemplo.IndexOf("que"));
        Console.WriteLine("La ultima \"a\" esta en la posicion: {0}", ejemplo.LastIndexOf("a"));
        Console.WriteLine("En mayúsculas: {0}", ejemplo.ToUpper());
        Console.WriteLine("En minúsculas: {0}", ejemplo.ToLower());
        Console.WriteLine("Si insertamos \", tío\": {0}", ejemplo.Insert(4, ", tío"));
        Console.WriteLine("Si borramos las 6 primeras letras: {0}", ejemplo.Remove(0, 6));
        Console.WriteLine("Si cambiamos ESTAS por ESTAMOS: {0}", ejemplo.Replace("estas", "estamos"));

        //Uso del método Contains
        string searchWord = "tal";
        bool containsExample = ejemplo.Contains(searchWord, StringComparison.OrdinalIgnoreCase);//El StringComparison.OrdinalIgnoreCaseEl parámetro se utiliza para una comparación que no distingue entre mayúsculas y minúsculas.

        if (containsExample)
        {
            Console.WriteLine($"La sentencia contiene la palabra '{searchWord}'.");
        }
        else
        {
            Console.WriteLine($"La sentencia contiene la palabra '{searchWord}'.");
        }
        Console.WriteLine();
    }
}