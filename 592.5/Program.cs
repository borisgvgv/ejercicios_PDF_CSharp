/*
(5.9.2.5) Crea un programa que pida al usuario 5 datos numéricos reales, los
guarde en un array, pida un nuevo dato y muestre el valor del array que se
encuentra más cerca de ese dato en valor absoluto (es decir, el más próximo, sea
mayor que él o menor que él).
*/

using System;
class Program
{
    public static float valorMinimo(float[] arrayDatos)
    {

        float valorMinimo = arrayDatos[0];

        foreach (float valor in arrayDatos)
        {
            if (valor < valorMinimo)
            {
                valorMinimo = valor;
            }
        }

        return valorMinimo;
    }
    public static float valorMaximo(float[] arrayDatos)
    {
        float valorMaximo = arrayDatos[0];

        foreach (float valor in arrayDatos)
        {
            if (valor > valorMaximo)
            {
                valorMaximo = valor;
            }
        }
        return valorMaximo;
    }

    public static float masCercanoMenor(float[] arrayDatos, float nuevoDato)
    {

        float minimo = float.MinValue;
        foreach (float valor in arrayDatos)
        {
            if (valor > minimo && valor < nuevoDato)
        {
                minimo = valor;
            }
        }

        return minimo;
    }



    public static float masCercanoMayor(float[] arrayDatos, float nuevoDato)
    {
        float maximo = float.MaxValue; // Establecer el valor máximo inicial al mayor flotante posible

        foreach (float valor in arrayDatos)
        {
            if (valor < maximo && valor > nuevoDato)
            {
                maximo = valor;
            }
        }

        // Compruebe si se encontró un valor mayor; de lo contrario, devolverá un indicador (por ejemplo, float.MaxValue)

        return (maximo == float.MaxValue) ? float.MaxValue : maximo;
    }

    public static float masCercano(float menor, float mayor, float nuevoDato)
    {

        float resultado1 = nuevoDato - menor;
        float resultado2 = mayor - nuevoDato;
        float absoluto = 0;

        if (resultado1 < resultado2)
        {
            absoluto = menor;
        }
        else if (resultado1 > resultado2)
        {
            absoluto = mayor;
        }
        return absoluto;

    }

    static void Main()
    {
        int contador = 5;
        float[] arrayDatos = new float[contador];


        //Pedimos los datos
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine("Introduce un número");
            float datos = Convert.ToSingle(Console.ReadLine());
            arrayDatos[i] = datos;

        }

        Console.WriteLine();

        //Mostramos los datos
        for (int i = 0; i < arrayDatos.Length; i++)
        {
            Console.WriteLine(arrayDatos[i]);
        }

        Console.WriteLine("Añade un nuevo dato");
        float nuevoDato = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine($"Valor mínimo: {valorMinimo(arrayDatos)}");
        Console.WriteLine($"Valor máximo: {valorMaximo(arrayDatos)}");
        Console.WriteLine($"Valor mínimo cercano es: {masCercanoMenor(arrayDatos, nuevoDato)}");
        Console.WriteLine($"Valor máximo cercano es: {masCercanoMayor(arrayDatos, nuevoDato)}");
        float menor = masCercanoMenor(arrayDatos, nuevoDato);
        float mayor = masCercanoMayor(arrayDatos, nuevoDato);
        Console.WriteLine($"Valor absoluto es: {masCercano(menor, mayor, nuevoDato)}");


    }
}