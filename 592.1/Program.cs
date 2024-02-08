/*
(5.9.2.1) Crea un programa que halle (y muestre) la raíz cuadrada del número que
introduzca el usuario. Se repetirá hasta que introduzca 0.
*/

using System;

class Program
{
    static void Main()
    {

        /*
        Console.WriteLine("Introdusca un número para hallar su raiz cuadrada");
        double numero = Convert.ToInt32(Console.ReadLine());
        double raizCuadradaDeNumero = Math.Sqrt(numero);
        Console.WriteLine(raizCuadradaDeNumero);
        */
        //Lo anterior se resume en 
        
        double numero = 0;
        double raizCuadradaDeNumero = 0;

        do
        {
            Console.WriteLine("Introdusca un número para hallar su raiz cuadrada");
            numero = Convert.ToInt32(Console.ReadLine());

            raizCuadradaDeNumero = Math.Sqrt(numero);
            Console.WriteLine(raizCuadradaDeNumero);

        } while (numero != 0);

        Console.WriteLine("Hasta pronto");



    }
}