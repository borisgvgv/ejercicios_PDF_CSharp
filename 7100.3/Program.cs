using System;

public class Program
{
    public struct tipoFicha
    {
        public string nombreFich; // Nombre del fichero
        public long tamanyo; // El tamaño en KB
    };


    public static void GestorDeArchivos()
    {



        tipoFicha[] fichas = new tipoFicha[1000]; // Los datos en si 
        int numeroFichas = 0; //  Número de fichas que ya tenemos
        int i; // Para bucles
        int option = 0; // La opcion del menu que elija el usuario
        string textoBuscar; // Para cuando preguntemos al usuario
        long tamanyoBuscar; // Para buscar por tamaño

        Menu menu = new Menu();
        AddDatos addDatos = new AddDatos(fichas);
        MostrarDatos mostrarDatos = new MostrarDatos(fichas);
        MostrarSegunTamanyo mostrarSegunTamanyo = new MostrarSegunTamanyo(fichas);

        do
        {
            // Menu principal, repetitivo
            menu.Mostrar();
            option = Convert.ToInt32(Console.ReadLine());
            menu.SetOption(option);
            menu.GetOption();

            // Hacemos una cosa u otra según la opción escogida
            switch (option)
            {
                case 1: // Añadir un dato nuevo
                    addDatos.Mostrar();
                    numeroFichas++;
                    addDatos.SetNumeroFichas(numeroFichas);
                    break;
                case 2: // Mostrar todos
                    mostrarDatos.SetNumeroFichas(numeroFichas);
                    mostrarDatos.Mostrar();
                    break;
                case 3: // Mostrar según el tamaño
                    Console.WriteLine("¿A partir de que tamaño quieres ver?");
                    tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
                    mostrarSegunTamanyo.SetTamanyoBuscar(tamanyoBuscar);
                    mostrarSegunTamanyo.SetNumeroFichas(numeroFichas);
                    mostrarSegunTamanyo.Mostrar();
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