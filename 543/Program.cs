/*
(5.4.3) Crea una función llamada "Signo", que reciba un número real, y devuelva un
número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es
cero.
*/

using System;
class Program
{

    static float Signo(float numero)
    {
        if (numero > 0)
        {
            return -numero;
        }
        else 
        {
            return numero * -1;
        }

    }
    static void Main()
    {
        Console.WriteLine("introduce un número real para hallar su signo contrario");
        float numero = Convert.ToSingle(Console.ReadLine());
        if (numero == 0)
        {
            Console.WriteLine("{0} no tiene signo contrario", numero);
        }
        else
        {
            Console.WriteLine("el singo contrario a {0} es {1}", numero, Signo(numero));
        }




    }
}