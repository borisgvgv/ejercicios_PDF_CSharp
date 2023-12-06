// Ejemplo_05_05c.cs
// Versión del Ejemplo_05_05b.cs sin variables globales
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_05_05c
{
    struct tipoFicha
    {
        public string nombreFich; // Nombre del fichero
        public long tamanyo; // El tamaño en KB
    }
    static void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Escoja una opción:");
        Console.WriteLine("1.- Añadir datos de un nuevo fichero");
        Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
        Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño");
        Console.WriteLine("4.- Ver datos de un fichero");
        Console.WriteLine("5.- Salir");
    }
    static int PedirOpcion()
    {
        return Convert.ToInt32(Console.ReadLine());
    }
    static int Anyadir(tipoFicha[] fichas, int numeroFichas)
    {
        if (numeroFichas < 1000)
        { // Si queda hueco
            Console.WriteLine("Introduce el nombre del fichero: ");
            fichas[numeroFichas].nombreFich = Console.ReadLine();
            Console.WriteLine("Introduce el tamaño en KB: ");
            fichas[numeroFichas].tamanyo = Convert.ToInt32(
            Console.ReadLine());
            // Y ya tenemos una ficha más
            numeroFichas++;
        }
        else // Si no hay hueco para más fichas, avisamos
            Console.WriteLine("Máximo de fichas alcanzado (1000)!");
        return numeroFichas;
    }
    static void MostrarTodos(tipoFicha[] fichas, int numeroFichas)
    {
        for (int i = 0; i < numeroFichas; i++)
            Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
            fichas[i].nombreFich, fichas[i].tamanyo);
    }
    static void MostrarPorTamanyo(tipoFicha[] fichas, int numeroFichas)
    {
        Console.WriteLine("¿A partir de que tamaño quieres ver?");
        long tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
        for (int i = 0; i < numeroFichas; i++)
            if (fichas[i].tamanyo >= tamanyoBuscar)
                Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                fichas[i].nombreFich, fichas[i].tamanyo);
    }
    static void MostrarUnDato(tipoFicha[] fichas, int numeroFichas)
    {
        Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
        string textoBuscar = Console.ReadLine();
        for (int i = 0; i < numeroFichas; i++)
            if (fichas[i].nombreFich == textoBuscar)
                Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                fichas[i].nombreFich, fichas[i].tamanyo);
    }
    static void AvisarFin()
    {
        Console.WriteLine("Fin del programa");
    }
    static void AvisarError()
    {
        Console.WriteLine("Opción desconocida!");
    }
    static void Main()
    {

        // Variables locales
        tipoFicha[] fichas = new tipoFicha[1000];
        int numeroFichas = 0;
        int opcion;
        do
        {
            MostrarMenu();
            opcion = PedirOpcion();
            switch (opcion)
            {
                case 1:
                    numeroFichas = Anyadir(fichas, numeroFichas);
                    break;
                case 2: MostrarTodos(fichas, numeroFichas); break;
                case 3: MostrarPorTamanyo(fichas, numeroFichas); break;
                case 4: MostrarUnDato(fichas, numeroFichas); break;
                case 5: AvisarFin(); break;
                default: AvisarError(); break;
            }
        } while (opcion != 5);
    }
}