using System;

class Program
{
    static void Main()
    {

        string frase = "No por mucho madrugar amanece más temprano";

        Console.WriteLine(frase);

        string[] arrayFrase = frase.Split();

        for (int i = 0; i < arrayFrase.Length; i++)
        {
            Console.WriteLine(arrayFrase[i]);

        }



    }
}






