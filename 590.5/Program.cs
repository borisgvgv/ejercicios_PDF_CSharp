/*
(5.9.1.5) Crea un programa que "dibuje" asteriscos en 100 posiciones al azar de la
pantalla. Para ayudarte para escribir en cualquier coordenada, puedes usar un
array de dos dimensiones (con tamaños 24 para el alto y 79 para el ancho), que
primero rellenes y luego dibujes en pantalla.
*/

using System;

class Program
{
    static void Main()
    {
        // Tamaño de la pantalla
        int alto = 24;
        int ancho = 79;

        // Crear el array de dos dimensiones para representar la pantalla
        char[,] pantalla = new char[alto, ancho];

        // Inicializar la pantalla con espacios en blanco
        InicializarPantalla(pantalla);

        // Dibujar asteriscos en posiciones aleatorias
        DibujarAsteriscosAleatorios(pantalla, 100);

        // Imprimir la pantalla en la consola
        ImprimirPantalla(pantalla);
    }

    // Función para inicializar la pantalla con espacios en blanco
    static void InicializarPantalla(char[,] pantalla)
    {
        for (int i = 0; i < pantalla.GetLength(0); i++)
        {
            for (int j = 0; j < pantalla.GetLength(1); j++)
            {
                pantalla[i, j] = ' ';
            }
        }
    }

    // Función para dibujar asteriscos en posiciones aleatorias
    static void DibujarAsteriscosAleatorios(char[,] pantalla, int cantidad)
    {
        Random random = new Random();

        for (int k = 0; k < cantidad; k++)
        {
            int fila = random.Next(pantalla.GetLength(0));
            int columna = random.Next(pantalla.GetLength(1));

            pantalla[fila, columna] = '*';
        }
    }

    // Función para imprimir la pantalla en la consola
    static void ImprimirPantalla(char[,] pantalla)
    {
        for (int i = 0; i < pantalla.GetLength(0); i++)
        {
            for (int j = 0; j < pantalla.GetLength(1); j++)
            {
                Console.Write(pantalla[i, j]);
            }
            Console.WriteLine();
        }
    }
}










/*
static void DibujarEstrellas(int repeticiones, int alto, int ancho){
        
        
        Random coordenadas = new Random();
        int x, y;
        
       
        for (int p = 0; p < repeticiones; p++)
        {

            x = coordenadas.Next(0, alto);
            y = coordenadas.Next(0, ancho);


            for (int i = 0; i <= x; i++)
            {
                if (i != x)
                {
                    Console.WriteLine(".");
                }
            }

            for (int j = 0; j <= y; j++)
            {
                if (j != y)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.WriteLine("*");
                }

            }
        }
}

    static void Main()
    {
        int repeticiones = 5;
        int alto = 5;
        int ancho = 10;

        DibujarEstrellas(repeticiones, alto, ancho);

    }
*/