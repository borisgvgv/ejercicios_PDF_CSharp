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
            if (frase[i] == ' ')
            {
                i++;
                fraseModificable[i] = char.ToUpper(frase[i]);   
            }
            else
            {    
                fraseModificable[i] = char.ToLower(frase[i]);
            }
        }

        frase = fraseModificable.ToString().Replace(" ","");
        Console.WriteLine(frase);

    }
}