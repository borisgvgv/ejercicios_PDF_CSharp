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
Y supongamos que  i está inicializado en 7 (lo que significa que estamos comenzando la comparación desde la posición 7 de  mainString).

Desglose del bucle: 

    Primera iteración (j = 0): 
        i + j se traduce a  7 + 0, por lo que estamos comparando  mainString[7] con  subString[0]. 
        mainString[7] es "w" y subString[0] también es "w".
        Estas letras son iguales, por lo que no se ejecuta  break y continuamos a la siguiente iteración. 

    Segunda iteración (j = 1): 
        i + j se traduce a  7 + 1, por lo que estamos comparando  mainString[8] con  subString[1]. 
        mainString[8]es "o" y subString[1] también es "o". 
        Estas letras son iguales, por lo que no se ejecuta  break y continuamos a la siguiente iteración. 

    Tercera iteración (j = 2): 
        i + j se traduce a  7 + 2, por lo que es mainString[9] con subString[2].
        mainString[9]es "r" y subString[2] también es "r". 
        Estas letras son iguales, por lo que no se ejecuta  break y continuamos a 

    Cuarta iteración (j = 3): 
        i + j se traduce a  7 + 3, por lo que estamos comparando  mainString[10] con  subString[3]. 
        mainString[10]es "l" y subString[3]es "d". 
        Estas letras son diferentes, por lo que la condición mainString[i + j] != subString[j] se cumple y se ejecuta break, terminando el bucle.

Resultado final: 

    En este caso, el bucle se interrumpe en la cuarta iteración porque se encontró una discrepanci mainString.
*/
