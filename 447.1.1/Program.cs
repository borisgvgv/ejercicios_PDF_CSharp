using System;

class Program
{
    static void Main()
    {

        //Definimos la frase
        string frase = "Uno, Dos, Tres. Cuatro, Cinco";
        string frase2 = "No por mucho madrugar amanece más temprano";
        //Mostramos la frase
        Console.WriteLine(frase);
        Console.WriteLine();

        //Indicamos delimitador que queremos que elimine
        char[] delimitadores = { ',', '.' };

        //Creamos array de frase con Split
        string[] frasePartida = frase.Split(delimitadores);
        string[] frasePartida2 = frase2.Split();

        //Mostramos la frase partida

        for (int i = frasePartida.Length - 1; i > 0; i--)
        {
            Console.WriteLine(frasePartida[i].Replace(" ", ""));
        }

        //En este ejemplo Replace se utiliza para eliminar los espacios que no podemos eliminar con Split
        Console.WriteLine();

        for (int i = frasePartida2.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(frasePartida2[i].Replace(" ", ""));
        }


    }
}
