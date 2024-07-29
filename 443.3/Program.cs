using System;

class Program
{
    static void Main()
    {

        bool letraEncontrada = false;
        char letraBuscada;

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("letra: ");
        char letra = Convert.ToChar(Console.ReadLine());

        for (int i = 0; i < nombre.Length; i++)
        {
            letraBuscada = Convert.ToChar(nombre[i]);
            if (letra == letraBuscada)
            {
                Console.WriteLine("{0} aparece en la posición {1} del nombre: {2}", nombre[i], i + 1, nombre);
                letraEncontrada = true;
            }
        }

        if (!letraEncontrada)
            Console.WriteLine("La letra añadida no aparece");

        Console.WriteLine();

    }
}

