using System;

class Program
{
    static void Main()
    {
        string fraseMayor1 = "";
        string fraseMayor2 = "";
        string[] frases = new string[2];

        for (int i = 0; i < frases.Length; i++)
        {
            Console.WriteLine("Frase {0}: ", i + 1);
            frases[i] = Console.ReadLine();
            //frases[i]= frases[i].Replace(" ", "");
        }
        Console.WriteLine();

        for (int i = 0; i < frases.Length; i++)
        {
            Console.WriteLine("Frase {0}: {1}", i + 1, frases[i]);
        }
        Console.WriteLine();


        //Comparamos con CompareTo

        for (int i = 0; i < frases.Length; i++)
        {

            if (fraseMayor1.CompareTo(frases[i]) > 0)
            {
                fraseMayor1 = fraseMayor1;
            }
            else
            {
                fraseMayor1 = frases[i];
            }
        }

        //Comparamos con String.Compare


        for (int i = 0; i < frases.Length; i++)
        {

            if (string.Compare(fraseMayor2, frases[i], true) > 0)
            {
                fraseMayor2 = fraseMayor2;
            }
            else
            {
                fraseMayor2 = frases[i];
            }

        }


        //Con OmpareTo las mayusculas se consideran mayores que las minsculas
        //String.Compare no hace distición entre mayusculas y minúsculas

        Console.WriteLine("La frase mayor utilizando CompareTo es: {0}", fraseMayor1);

        Console.WriteLine("La frase mayor utilizando String.Compare es: {0}", fraseMayor2);


    }
}
