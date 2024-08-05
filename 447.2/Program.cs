using System;

class Program
{
    static void Main()
    {

        int resultado = 0;
        Console.WriteLine("Añade los números que quieras sumar separados por coma");
        string numeros = Console.ReadLine();

        string[] arrayNumeros = numeros.Split(',');

        for (int i = 0; i < arrayNumeros.Length; i++)
        {
            resultado = resultado + Convert.ToInt32(arrayNumeros[i].Replace(" ", ""));
        }

        Console.WriteLine(resultado);
    }
}
