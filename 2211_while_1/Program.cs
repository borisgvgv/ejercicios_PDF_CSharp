/*
(2.2.1.1.1) Crea un programa que pida al usuario su contraseña (numérica).
Deberá terminar cuando introduzca como contraseña el número 1111, pero
volvérsela a pedir tantas veces como sea necesario
*/

using System;

class E2211_1
{
    static void Main()
    {

        Console.WriteLine("Contraseña");
        int id = Convert.ToInt32(Console.ReadLine());

        while (id != 1111)
        {
            
            Console.WriteLine("Contraseña incorrecta.\nPrueba otra contraseña");
            id = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine("Contraseña correcta");

    }
}