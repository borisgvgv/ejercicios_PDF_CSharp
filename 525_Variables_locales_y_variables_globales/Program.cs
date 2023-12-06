// Ejemplo_05_05a.cs
// Ejemplo de función con variables locales
// Introducción a C#, por Nacho Cabanes
using System;
class Ejemplo_05_05a
{
    static int Potencia(int nBase, int nExponente)
    {
        int temporal = 1; // Valor inicial que voy incrementando
        for (int i = 1; i <= nExponente; i++) // Multiplico "n" veces
            temporal *= nBase; // Para aumentar el valor temporal
        return temporal; // Al final, obtengo el valor que buscaba
    }

    //Desarrollo de struc y Funciones del segundo ejemplo Fichero

    struct tipoFicha
    {
        public string nombreFich; // Nombre del fichero
        public long tamanyo; // El tamaño en KB
    }

    // Variables "globales"
    static tipoFicha[] fichas;
    static int numeroFichas;
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
    static void Anyadir()
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
    }
    static void MostrarTodos()
    {
        for (int i = 0; i < numeroFichas; i++)
            Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
            fichas[i].nombreFich, fichas[i].tamanyo);
    }
    static void MostrarPorTamanyo()
    {
        Console.WriteLine("¿A partir de que tamaño quieres ver?");
        long tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
        for (int i = 0; i < numeroFichas; i++)
            if (fichas[i].tamanyo >= tamanyoBuscar)
                Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                fichas[i].nombreFich, fichas[i].tamanyo);
    }
    static void MostrarUnDato()
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
        int num1, num2;
        Console.WriteLine("Introduzca la base: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduzca el exponente: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} elevado a {1} vale {2}",
        num1, num2, Potencia(num1, num2));


        //Desarrollo en Main del funcionamiento del fichero 
        Console.WriteLine();
        Console.WriteLine("FICHERO");
        Console.WriteLine();
        // Variables locales
        int opcion;
        // Valores iniciales a las variables compartidas
        fichas = new tipoFicha[1000];
        numeroFichas = 0;
        do
        {
            MostrarMenu();
            opcion = PedirOpcion();
            switch (opcion)
            {
                case 1: Anyadir(); break;
                case 2: MostrarTodos(); break;
                case 3: MostrarPorTamanyo(); break;
                case 4: MostrarUnDato(); break;
                case 5: AvisarFin(); break;
                default: AvisarError(); break;
            }
        } while (opcion != 5);
    }
}