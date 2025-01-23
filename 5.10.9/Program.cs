/*
(5.10.9) Crea dos funciones que sirvan para saber si un cierto texto es subcadena
de una cadena. No puedes usar "Contains" ni "IndexOf", sino que debes analizar
letra a letra. Una función debe ser iterativa y la otra debe ser recursiva.
*/

using System;

class Program
{
    static void Main()
    {
        string mainString = "Hola, esto es un ejemplo";
        string subString = "es un";

        bool isSubStringIterative = IsSubStringIterative(mainString, subString);
        bool isSubStringRecursive = IsSubStringRecursive(mainString, subString);

        if (isSubStringIterative)
        {
            Console.WriteLine($"'{subString}' es una subcadena de '{mainString}'.");
        }
        else
        {
            Console.WriteLine($"'{subString}' no es una subcadena de '{mainString}'.");
        }


        if (isSubStringRecursive)
        {
            Console.WriteLine($"'{subString}' es una subcadena de '{mainString}'.");
        }
        else
        {
            Console.WriteLine($"'{subString}' no es una subcadena de '{mainString}'.");
        }

    }


    public static bool IsSubStringIterative(string mainString, string subString)
    {
        int mainLength = mainString.Length;
        int subLength = subString.Length;

        for (int i = 0; i < mainLength; i++)
        {
            int j = 0;

            while (j < subLength && mainString[i + j] == subString[j])
            {
                j++;
            }

            if (j == subLength)
                return true;

        }

        return false;
    }

    public static bool IsSubStringRecursive(string mainString, string subString)
    {

        return IsSubStringRecursiveAuxiliar(mainString, subString, 0, 0);

    }

    static bool IsSubStringRecursiveAuxiliar(string mainString, string subString, int i, int j)
    {

        if (j == subString.Length)
        {
            return true;
        }

        if (i == mainString.Length)
        {
            return false;
        }

        if (mainString[i] == subString[j])
        {
            return IsSubStringRecursiveAuxiliar(mainString, subString, i + 1, j + 1);
        }
        else
        {
            return IsSubStringRecursiveAuxiliar(mainString, subString, i + 1, 0);
        }

    }
}




