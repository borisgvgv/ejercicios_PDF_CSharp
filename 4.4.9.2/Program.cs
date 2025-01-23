using System;
using System.Text;

class Program
{
    static void Main()
    {

        Console.WriteLine("Añade una frase");
        string frase = Console.ReadLine();


        StringBuilder fraseModificable = new StringBuilder(frase);

        for (int i = 0; i < frase.Length; i++)
        {

            if (i % 2 == 0)
            {

                fraseModificable[i] = char.ToLower(frase[i]);
            }
            else
            {
                fraseModificable[i] = char.ToUpper(frase[i]);
            }


        }

        frase = fraseModificable.ToString();
        Console.WriteLine(frase);

    }
}