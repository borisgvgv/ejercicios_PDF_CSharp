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

        if (isSubStringIterative)
        {
            Console.WriteLine($"'{subString}' es una subcadena de '{mainString}'.");
        }
        else
        {
            Console.WriteLine($"'{subString}' no es una subcadena de '{mainString}'.");
        }
    }

    static bool IsSubStringIterative(string mainString, string subString)
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
}

/*
    Inicialización: 
        mainLengthes la longitud de la cuerda principal. 
        subLengthes la longitud de la subcadena. 
        El bucle exterior ( for) recorre cada posible posición inicial de la subcadena dentro de la cadena principal. 

    Bucle exterior: 
        for (int i = 0; i <= mainLength - subLength; i++): El bucle comienza desde el primer carácter de la cadena principal y sube hasta una posición donde los caracteres restantes de la cadena principal son iguales o más largos que la subcadena. 

    Bucle interior (reemplazado con while): 
        int j = 0;: Inicializa una variable ja cero, que representa el índice del carácter actual en la subcadena. 
        while (j < subLength && mainString[i + j] == subString[j]): Este bucle comprueba si los caracteres en las posiciones actuales de la cadena principal y la subcadena coinciden.  El ciclo continúa mientras haya una coincidencia y jestá dentro de los límites de la subcadena. 
        El j++La declaración incrementa el índice. jpara cada carácter coincidente. 

    Verifique la coincidencia de subcadenas: 
        if (j == subLength): Esta condición verifica si toda la subcadena coincide.  Si es así, significa que la subcadena se encuentra en la posición actual de la cadena principal. 

    Resultado devuelto: 
        return true;: Si toda la subcadena coincide en cualquier posición, el método devuelve trueindicando que la subcadena está presente en la cadena principal. 

    Fin del método: 
        Si el bucle externo se completa sin encontrar una coincidencia, el método devuelve false, lo que indica que la subcadena no está presente en la cadena principal. 

Este enfoque evita el uso breakcontrolando la condición de terminación del bucle e incrementando el índice dentro del bucle. 
*/