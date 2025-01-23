using System;

class Program
{
    static void Main()
    {


        Console.WriteLine("Introduce una palabra");
        //Prueba con "Hola" y con "hola".
        string palabra = "Hola";

        //CompareTo distingue entre mayúsculas y minúsculas
        if (palabra.CompareTo("hola") > 0)
        {
            Console.WriteLine("Mayor");
        }
        else
        {
            Console.WriteLine("Menor");
        }

        //String.Compare no distingue entre mayúsculas y minúsculas
        bool ignorarMayuscula = true;
        if (String.Compare(palabra, "hola", ignorarMayuscula) > 0)
        {
            Console.WriteLine("Mayor");
        }
        else
        {
            Console.WriteLine("Menor");
        }

    }
}
