using System;

/*
(5.5.1) Crea una función "PedirEntero", que reciba como parámetros el texto que
se debe mostrar en pantalla, el valor mínimo aceptable y el valor máximo
aceptable. Deberá pedir al usuario que introduzca el valor tantas veces como sea
necesario, volvérselo a pedir en caso de error, y devolver un valor correcto.
Pruébalo con un programa que pida al usuario un año entre 1800 y 2100.
*/
class Program
{
    public static int PedirEntero(string txt, int min, int max)
    {
        int anyo;
        do
        {
            System.Console.WriteLine(txt);
            anyo = Convert.ToInt32(Console.ReadLine());

        } while (anyo < min || anyo > max);

        return anyo;

    }
    static void Main()
    {
        int min = 1080;
        int max = 2100;
        string txt = "Introduce un año entre 1080 y 2100";

        System.Console.WriteLine($"{PedirEntero(txt, min, max)} Aceptado");

    }
}