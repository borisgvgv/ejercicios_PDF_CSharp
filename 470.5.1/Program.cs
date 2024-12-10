using System;

/*
4.7.5) Realiza una variante del ejercicio 4.7.4, que en vez de hacer una búsqueda
lineal (desde el principio), use "búsqueda binaria": se comenzará a comparar con el
punto medio del array; si nuestro dato es menor, se vuelve a probar en el punto
medio de la mitad inferior del array, y así sucesivamente.
*/
class Program
{
    static void Main()
    {

        int cantidad = 0, capacidad = 20, limiteInferior = cantidad, limiteSuperior = capacidad - 1;
        bool encontrado = false;
        int[] datos = new int[capacidad];

        //Añadimos datos
        Random r = new Random();
        for (int i = 0; i < capacidad; i++)
        {
            datos[cantidad] = r.Next(1, capacidad * 2);
            cantidad++;
        }

        //Ordenamos el array
        Array.Sort(datos);

        //Mostramos el array
        for (int i = 0; i < cantidad; i++)
        {
            System.Console.WriteLine($"{i + 1} - {datos[i]}");
        }

        //Proponemos un valos a buscar
        int valorABuscar = 18;

        while (!encontrado)
        {

            int puntoMedio = limiteInferior + (limiteSuperior - limiteInferior) / 2;

            //Avisamos de donde buscamos
            Console.WriteLine($"Buscando entre posición {limiteInferior} y {limiteSuperior}, valores: {datos[limiteInferior]} y {datos[limiteSuperior]},  \" + \" centro {puntoMedio} es {datos[puntoMedio]}");

            // Compruebo si hemos acertado
            if (datos[puntoMedio] == valorABuscar)
            {
                Console.WriteLine("Encontrado!");
                encontrado = true;
            }
            // O si se ha encontrado la búsqueda
            else if (limiteInferior == limiteSuperior - 1)
            {
                Console.WriteLine("No encontrado");
                encontrado = true;
            }
            // Si no hemos encontrado, debemos seguir buscando en una mitad
            if (datos[puntoMedio] < valorABuscar)
                limiteInferior = puntoMedio;
            else
                limiteSuperior = puntoMedio;
        }

    }
}
