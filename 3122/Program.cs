/*
(3.1.2.2) Pide al usuario dos números de dos cifras ("byte"), calcula su
multiplicación, que se deberá guardar en un "int", y muestra el resultado en
pantalla.
*/

using System;

class E3122
{
    static void Main()
    {
        System.Console.WriteLine("Introduce un número de dos cifras");
        byte num1 = Convert.ToByte(Console.ReadLine());
        System.Console.WriteLine("Introduce otro número de dos cifras");
        byte num2 = Convert.ToByte(Console.ReadLine());

        byte resultado = num1 * num2;
        byte numero = 144;
        System.Console.WriteLine($"{resultado} - {numero}");

    }
}
