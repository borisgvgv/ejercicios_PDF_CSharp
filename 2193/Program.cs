/*2.1.9.3) Crea un programa que lea una letra tecleada por el usuario y diga si se
trata de una vocal, una cifra numérica o una consonante, usando "switch"*/

using System;
class E2193
{
    static void Main()
    {
        System.Console.WriteLine("Toca una tecla");
        char tecla = Convert.ToChar(Console.ReadLine());

        switch (tecla)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u': System.Console.WriteLine("Es una vocal"); break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9': System.Console.WriteLine("Es un número entre 0 y 9"); break;
            default: System.Console.WriteLine("Consonante"); break;

        }

    }
}
