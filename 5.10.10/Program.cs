using System;

/*
(5.10.10) Crea una función que reciba una cadena de texto, y una subcadena, y
devuelva cuántas veces aparece la subcadena en la cadena, como subsecuencia
formada a partir de sus letras en orden. Por ejemplo, si recibes la palabra "Hhoola"
y la subcadena "hola", la respuesta sería 4, porque se podría tomar la primera H
con la primera O (y con la L y con la A), la primera H con la segunda O, la segunda
H con la primera O, o bien la segunda H con la segunda O. Si recibes "hobla", la
respuesta sería 1. Si recibes "ohla", la respuesta sería 0, porque tras la H no hay
ninguna O que permita completar la secuencia en orden.
*/

class Program
{
    static int ContarSubsecuencias(string cadena, string subcadena)
    {
        // Caso base: Si la subcadena está vacía, hay una coincidencia.
        if (subcadena.Length == 0)
        {
            return 1;
        }

        // Caso base: Si la cadena está vacía pero aún queda subcadena, no es posible.
        if (cadena.Length == 0)
        {
            return 0;
        }

        // Si el primer carácter de la subcadena coincide con el primer carácter de la cadena
        if (cadena[0] == subcadena[0])
        {
            // Contamos las subsecuencias con y sin usar el carácter actual de la cadena
            return ContarSubsecuencias(cadena.Substring(1), subcadena.Substring(1)) + // Usando este carácter
                   ContarSubsecuencias(cadena.Substring(1), subcadena);              // Sin usar este carácter
        }
        else
        {
            // Si no coinciden, seguimos buscando en el resto de la cadena
            return ContarSubsecuencias(cadena.Substring(1), subcadena);
        }
    }

    static void Main()
    {
        string cadenaPrincipal = "Hhhoola";
        string subcadenaABuscar = "hola";

        int resultado = ContarSubsecuencias(cadenaPrincipal, subcadenaABuscar);
        Console.WriteLine($"La subcadena '{subcadenaABuscar}' aparece {resultado} veces en la cadena '{cadenaPrincipal}'.");
    }
}
