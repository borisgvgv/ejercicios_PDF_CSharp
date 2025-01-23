using System;

/*
(5.10.9) Crea dos funciones que sirvan para saber si un cierto texto es subcadena
de una cadena. No puedes usar "Contains" ni "IndexOf", sino que debes analizar
letra a letra. Una función debe ser iterativa y la otra debe ser recursiva.
*/

class Program
{

    public static string PedirFrase()
    {
        System.Console.Write("Frase: ");
        return Console.ReadLine();
    }

    public static string Pedirtexto()
    {
        System.Console.Write("Texto: ");
        return Console.ReadLine();
    }


    public static void BusquedaIterativaconFor(string frase, string texto)
    {
        string texAlt = "";
        int j = 0;
        for (int i = 0; i <= frase.Length; i++)
        {
            if (texAlt.Length < texto.Length && frase[i] == texto[j])
            {
                texAlt += frase[i];
                j++;
            }
        }

        System.Console.WriteLine(texAlt);

        if (texAlt == texto)
        {
            System.Console.WriteLine("Aparece");
        }
        else
        {
            System.Console.WriteLine("No aparece");
        }
    }

    public static void BusquedaIterativaConSubstring(string frase, string texto)
    {
        string texAlt = "";
        string buscado = "";
        for (int i = 0; i <= frase.Length - texto.Length; i++)
        {
            texAlt = frase.Substring(i, texto.Length);
            if (texAlt == texto)
            {
                buscado = texAlt;
            }

        }

        if (buscado == texto)
        {
            System.Console.WriteLine($"{buscado} Aparece");
        }
        else
        {
            System.Console.WriteLine($"{texto} No aparece");
        }
    }

    static int i = 0;
    public static string BusquedaRecursiva(string frase, string texto)
    {

        if (i <= frase.Length - texto.Length && frase.Substring(i, texto.Length) == texto)
        {
            return "Encontrado";
        }
        else if (i > frase.Length - texto.Length)
        {
            return "El texto no se ha encontrado";
        }

        i++;
        return BusquedaRecursiva(frase, texto);


    }



    static void Main()
    {
        System.Console.WriteLine("BusquedaIterativaconFor");
        BusquedaIterativaconFor(PedirFrase(), Pedirtexto());
        System.Console.WriteLine("BusquedaIterativaConSubstring");
        BusquedaIterativaConSubstring(PedirFrase(), Pedirtexto());
        System.Console.WriteLine("busquedaRecursiva");
        System.Console.WriteLine(BusquedaRecursiva(PedirFrase(), Pedirtexto()));
    }
}