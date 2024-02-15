/*
(5.10.7) Crea, tanto de forma recursiva como de forma iterativa, una función diga
si una cadena de caracteres es simétrica (un palíndromo). Por ejemplo,
"DABALEARROZALAZORRAELABAD" es un palíndromo.
*/

using System;

class Program
{
    static void Main()
    {
        string cadenaEjemplo = "DABALEARROZALAZORRAELABAD";
        bool resultado = EsPalindromoIterativo(cadenaEjemplo);
        Console.WriteLine($"\"{cadenaEjemplo}\" es un palíndromo: {resultado}");


        bool resultado2 = EsPalindromoRecursivo(cadenaEjemplo);
        Console.WriteLine($"\"{cadenaEjemplo}\" es un palíndromo: {resultado2}");
    }

    static bool EsPalindromoIterativo(string cadena)
    {
        int inicio = 0;
        int fin = cadena.Length - 1;

        while (inicio < fin)
        {
            if (cadena[inicio] != cadena[fin])
            {
                return false;
            }

            inicio++;
            fin--;
        }

        return true;
    }

    static bool EsPalindromoRecursivo(string cadena)
    {
        return EsPalindromoAuxiliar(0, cadena.Length - 1, cadena);
    }

    static bool EsPalindromoAuxiliar(int inicio, int fin, string cadena)
    {
        if (inicio >= fin)
        {
            return true;
        }

        if (cadena[inicio] != cadena[fin])
        {
            return false;
        }

        return EsPalindromoAuxiliar(inicio + 1, fin - 1, cadena);
    }
}
