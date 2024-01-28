/*
5.5.1) Crea una función "PedirEntero", que reciba como parámetros el texto que
se debe mostrar en pantalla, el valor mínimo aceptable y el valor máximo
aceptable. Deberá pedir al usuario que introduzca el valor tantas veces como sea
necesario, volvérselo a pedir en caso de error, y devolver un valor correcto.
Pruébalo con un programa que pida al usuario un año entre 1800 y 2100.
*/

using System;
class Program
{

    static void PedirEntero(string textoPantalla, int minimo, int maximo)
    {
        int anyo = 0;
        do
        {
            Console.WriteLine(textoPantalla);
            anyo = Convert.ToInt32(Console.ReadLine());
            
            if ((anyo < minimo) || (anyo > maximo))
            {
                textoPantalla = "El año está fuera del rango adecuado.\nIntroduce un año.";
            }
            
        } while ((anyo < minimo) || (anyo > maximo));

        if ((anyo > minimo) && (anyo < maximo))
        {
            textoPantalla = "El año está dentro del rango adecuado";
        }

        Console.WriteLine(textoPantalla);


    }

    static void Main()
    {
        int minimo = 1800;
        int maximo = 2100;
        string textoPantalla = "Introduce un año";

        PedirEntero(textoPantalla, minimo, maximo);

    }
}