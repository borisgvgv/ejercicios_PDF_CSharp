/*
(2.1.8.1) Crea un programa que use el operador condicional para mostrar el valor
absoluto de un número de la siguiente forma: si el número es positivo, se
mostrará tal cual; si es negativo, se mostrará cambiado de signo
*/

using System;
class Ejemplo_02_01_06a
{
    static void Main()
    {

        Console.WriteLine("Intruduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());

        int valor = numero > 0 ? numero : -numero;

        Console.WriteLine(valor);

    }
}

