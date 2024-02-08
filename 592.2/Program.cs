/*
5.9.2.2) Crea un programa que halle cualquier raíz (de cualquier orden) de un
número. El usuario deberá indicar el número (por ejemplo, 2) y el índice de la raíz
(por ejemplo, 3 para la raíz cúbica). Pista: hallar la raíz cúbica de 2 es lo mismo que
elevar 2 a 1/3
*/

using System;
class Program
{
    static void Main()
    {

        //Solicitamos número e indice al que se eleva
        Console.WriteLine("Introdusca un número");
        double numero = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introdusca un número");
        double indice = Convert.ToDouble(Console.ReadLine());
        indice= 1.0 / indice;

        double resultado = Math.Pow(numero, indice);
        Console.WriteLine(resultado); //1.2599210498948732
        Console.WriteLine(resultado.ToString("#.##")); //1.26

    }
}



/*



*/