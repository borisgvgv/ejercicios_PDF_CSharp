using System;

public class AddDatos
{

    public void Mostrar()
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

}


public class Ejemplo_04_06a
{
    struct tipoFicha
    {
        public string nombreFich; // Nombre del fichero
        public long tamanyo; // El tamaño en KB
    };


    public static void GestorDeArchivos()
    {

        Menu menu = new Menu();
        AddDatos addDatos = new AddDatos();
        tipoFicha[] fichas = new tipoFicha[1000]; // Los datos en si 
        int numeroFichas = 0; // Número de fichas que ya tenemos
        int i; // Para bucles
        int option = 0; // La opcion del menu que elija el usuario
        string textoBuscar; // Para cuando preguntemos al usuario
        long tamanyoBuscar; // Para buscar por tamaño



        do
        {
            // Menu principal, repetitivo
            menu.Mostrar();
            option = Convert.ToInt32(Console.ReadLine());
            menu.SetOption(option);

            // Hacemos una cosa u otra según la opción escogida
            switch (option)
            {
                case 1: // Añadir un dato nuevo
                    addDatos.Mostrar();
                    break;
                case 2: // Mostrar todos
                    for (i = 0; i < numeroFichas; i++)
                        Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                        fichas[i].nombreFich, fichas[i].tamanyo);
                    break;
                case 3: // Mostrar según el tamaño
                    Console.WriteLine("¿A partir de que tamaño quieres ver?");
                    tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
                    for (i = 0; i < numeroFichas; i++)
                        if (fichas[i].tamanyo >= tamanyoBuscar)
                            Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                            fichas[i].nombreFich, fichas[i].tamanyo);
                    break;
                case 4: // Ver todos los datos (pocos) de un fichero
                    Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
                    textoBuscar = Console.ReadLine();
                    for (i = 0; i < numeroFichas; i++)
                        if (fichas[i].nombreFich == textoBuscar)
                            Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                            fichas[i].nombreFich, fichas[i].tamanyo);
                    break;
                case 5: // Salir: avisamos de que salimos */
                    Console.WriteLine("Fin del programa");
                    break;
                default: // Otra opcion: no válida
                    Console.WriteLine("Opción desconocida!");
                    break;
            }
        } while (option != 5); // Si la opcion es 5, terminamos

    }
    public static void Main()
    {


        GestorDeArchivos();


    }
}