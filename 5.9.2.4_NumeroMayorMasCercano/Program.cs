/*
(5.9.2.4) Haz un programa que pida al usuario 5 datos numéricos enteros, los
guarde en un array, pida un nuevo dato y muestre el valor del array que se
encuentra más cerca de ese dato, siendo mayor que él, o el texto "Ninguno es
mayor" si ninguno lo es.
*/

using System;
class Program
{


    static void EncontrarMasCercanoMayor(int[] array, int nuevoDato)
    {

        bool valorMayorEncontrado = false;

        //Hallo cual es el mayor valor del array como valor límite a superar
        int mayorValorArray = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (mayorValorArray < array[i])
            {
                mayorValorArray = array[i];
            }
        }

        //Hallamos el mayor valor del array como valor límite a superar
        int distanciaMinima = mayorValorArray;
        int valorMasCercanoMayor = mayorValorArray;

        foreach (int valor in array)
        {
            if (valor < nuevoDato)
            {
                valorMayorEncontrado = false;
            }
            else if (valor > nuevoDato)
            {
                valorMayorEncontrado = true;
                int distanciaActual = valor - nuevoDato;

                if (distanciaActual < distanciaMinima)
                {
                    distanciaMinima = distanciaActual;
                    valorMasCercanoMayor = valor;
                }
            }
        }

        if (valorMayorEncontrado)
        {

            Console.WriteLine(valorMasCercanoMayor);
        }
        else
        {

            Console.WriteLine("Valor mayor no encontrado");

        }

    }
    static void Main()
    {


        //Reservamos espacios en array
        int[] arrayDatos = new int[5];


        //Pedimos datos
        for (int i = 0; i < arrayDatos.Length; i++)
        {

            Console.Write($"Dato{i + 1}: ");
            arrayDatos[i] = Convert.ToInt32(Console.ReadLine());

        }

        //Mostramos el array
        for (int i = 0; i < arrayDatos.Length; i++)
        {

            Console.Write($"{arrayDatos[i]} ");

        }

        //Pedimos un nuevo dato
        Console.Write("Añade un dato más: ");
        int nuevoDato = Convert.ToInt32(Console.ReadLine());


        /*
                //Calculamos el valor mayor más cercano
                int distanciaMinima = int.MaxValue;
                int valorMasCercanoMayor = int.MaxValue;
                //Console.WriteLine(distanciaMinima); // 2147483647
                //Console.WriteLine(valorMasCercanoMayor); //2147483647

                foreach (int valor in arrayDatos)
                {
                    if (valor < nuevoDato)
                    {
                        valorMayorEncontrado = false;
                    }

                    else if (valor > nuevoDato)
                    {
                        valorMayorEncontrado = true;
                        //Hallamos su diferencia
                        int diferencia = valor - nuevoDato;

                        if (diferencia < distanciaMinima)
                        {
                            distanciaMinima = diferencia;
                            valorMasCercanoMayor = valor;

                        }
                    }
                }

                if (valorMayorEncontrado)
                {
                    Console.WriteLine(valorMasCercanoMayor);
                }
                else
                {
                    Console.WriteLine("No hay un valor mayor al dato añadido");
                }
        */

        //Lo comentado anterior lo llevamos a una función
        EncontrarMasCercanoMayor(arrayDatos, nuevoDato);



    }
}

