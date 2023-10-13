/*
(2.1.9.1) Crea un programa que pida un número del 1 al 10 al usuario, y escriba el
nombre de ese número, usando "switch" (por ejemplo, si introduce "1", el
programa escribirá "uno").
*/

using System;
class Ejemplo_2191
{
    static void Main()
    {
        System.Console.WriteLine("Escbribe un número");
      int numero = Convert.ToInt32(Console.ReadLine());

        switch (numero)
        {
            case 1: Console.WriteLine($"Has Escrito {numero}"); break;
            case 2: Console.WriteLine($"Has Escrito {numero}"); break;
            case 3: Console.WriteLine($"Has Escrito {numero}"); break;
            case 4: Console.WriteLine($"Has Escrito {numero}"); break;
            case 5: Console.WriteLine($"Has Escrito {numero}"); break;
            case 6: Console.WriteLine($"Has Escrito {numero}"); break;
            case 7: Console.WriteLine($"Has Escrito {numero}"); break;
            case 8: Console.WriteLine($"Has Escrito {numero}"); break;
            case 9: Console.WriteLine($"Has Escrito {numero}"); break;
            case 10: Console.WriteLine($"Has Escrito {numero}"); break;
            default: System.Console.WriteLine("El número no es válido"); break;
        }
    }
}
