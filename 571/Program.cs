/*
(5.7.2.1) Crea una función "Intercambiar", que intercambie el valor de los dos
números enteros que se le indiquen como parámetro. Crea también un programa
que la pruebe.
*/

using System;
class Program
{

    public static void Intercambiar(int n1, int n2, out int numero1, out int numero2)
    {
        numero1 = n2;
        numero2 = n1;
        
    }

 
    static void Main()
    {
        int numero1, numero2;
        Console.WriteLine("Introduce un número");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce un número");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Intercambiar(num1, num2, out numero1, out numero2);
        Console.WriteLine("{0} {1}",numero1 , numero2); 
  
    }
}