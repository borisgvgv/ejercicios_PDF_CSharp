/*
(5.5.5) Crea una función "SumaCifras" que reciba un numero cualquiera y que
devuelva como resultado la suma de sus dígitos. Por ejemplo, si el número fuera
123 la suma sería 6.
*/

using System;
class Program555
{

    static void SumaCifras(string numero)
    {
        int resultado = 0;
        for (int i = 0; i < numero.Length; i++)
        {
        
        int cifra = Convert.ToInt32(numero[i].ToString());
          resultado += cifra;
        
        }
        Console.WriteLine("La suma de los dígitos de {0} es {1}", numero, resultado);

    }
    static void Main()
    {
        Console.WriteLine("Introduce una número");
        string numero = Console.ReadLine();

        SumaCifras(numero);
    }
}