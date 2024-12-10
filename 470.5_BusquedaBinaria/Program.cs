using System;

class Program
{
    static void Main()
    {

        int capacidad = 1000;
        int[] datos = new int[capacidad];
        int datoTemporal;

        //Generamos datos al azar
        Random r = new Random();
        for (int i = 0; i < capacidad; i++)
        {
            datos[i] = r.Next(1, capacidad * 2); //Esta línea indica que deben crearse 1000 numeros al azar entre 1 y 2000
        }

        //Ordenamos el array
        Array.Sort(datos);

        //Mostramos los datos
        for (int i = 0; i < datos.Length; i++)
        {
            System.Console.WriteLine($"{i + 1} - {datos[i]}");
        }

        // Proponemos valor a buscar
        int valorBuscado = 1001;
        System.Console.WriteLine($"Comprobando si aparece {valorBuscado}");

        int limiteInferior = 0;
        int limiteSuperior = 999;
        bool terminado = false;

        while (!terminado)
        {
            int puntoMedio = limiteInferior + (limiteSuperior - limiteInferior) / 2;

            // Aviso de dónde buscamos
            Console.WriteLine($"Buscando entre posición {limiteInferior} y {limiteSuperior}, valores: {datos[limiteInferior]} y {datos[limiteSuperior]},  \" + \" centro {puntoMedio} es {datos[puntoMedio]}");

            // Compruebo si hemos acertado
            if (datos[puntoMedio] == valorBuscado)
            {
                Console.WriteLine("Encontrado!");
                terminado = true;
            }
            // O si se ha terminado la búsqueda
            else if (limiteInferior == limiteSuperior - 1)
            {
                Console.WriteLine("No encontrado");
                terminado = true;
            }

            // Si no hemos terminado, debemos seguir buscando en una mitad
            if (datos[puntoMedio] < valorBuscado)
                limiteInferior = puntoMedio;
            else
                limiteSuperior = puntoMedio;

        }


    }
}
