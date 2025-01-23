using System;
using System.Text;
class Program
{
    static void Main()
    {

        string frase = "Hola mundo";
 
        StringBuilder fraseModificable = new StringBuilder(frase);

        for (int i = 0; i < frase.Length; i++)
        {
            fraseModificable[i] = 'O';
        }

        frase = fraseModificable.ToString();

        Console.Write(frase);

    }
}
