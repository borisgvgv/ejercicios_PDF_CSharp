using System;

public class Program
{

    struct myStructCTR
    {
        public string formato;
        public float ancho;
        public float alto;
        public float peso;
    }
    struct myStruct
    {
        public string titulo;
        public myStructCTR caracteristicas;
        public string autor;
    }
    public static void Main()
    {
        int cantidad = 3;
        myStruct[] imagenes = new myStruct[cantidad];

        bool salir = true;
        byte opcion;
        int numImagen = 0;

        do
        {

            Console.WriteLine("Menú");
            Console.WriteLine("1 - Add imágenes");
            Console.WriteLine("2 - Mostrar imágenes");
            Console.WriteLine("3 - Mostrar por autor");
            Console.WriteLine("4 - Mostrar por número");
            Console.WriteLine("5 - Salir");

            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:

                    if (numImagen < cantidad)
                    {
                        Console.WriteLine("Título: ");
                        imagenes[numImagen].titulo = Console.ReadLine();
                        Console.WriteLine("Formato: ");
                        imagenes[numImagen].caracteristicas.formato = Console.ReadLine();
                        Console.WriteLine("Ancho: ");
                        imagenes[numImagen].caracteristicas.ancho = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Alto: ");
                        imagenes[numImagen].caracteristicas.alto = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Peso: ");
                        imagenes[numImagen].caracteristicas.peso = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Autor: ");
                        imagenes[numImagen].autor = Console.ReadLine();
                        Console.WriteLine();

                        numImagen++;
                    }
                    else
                    {

                        Console.WriteLine("No se pueden añadir más datos");
                        Console.WriteLine("Debes elegir otra opción");

                    }

                    salir = false;

                    break;

                case 2:

                    for (int i = 0; i < numImagen; i++)
                    {
                        Console.WriteLine("Imagen {0}", i + 1);
                        Console.WriteLine("Título: {0}.{1}", imagenes[i].titulo, imagenes[i].caracteristicas.formato);
                        Console.WriteLine("Ancho: {0}", imagenes[i].caracteristicas.ancho);
                        Console.WriteLine("Alto: {0}", imagenes[i].caracteristicas.alto);
                        Console.WriteLine("Peso: {0}", imagenes[i].caracteristicas.peso);
                        Console.WriteLine("Autor: {0}", imagenes[i].autor);
                        Console.WriteLine();
                    }

                    salir = false;

                    break;

                case 3:

                    Console.Write("Autor: ");
                    string autorBuscado = Console.ReadLine();

                    for (int i = 0; i < numImagen; i++)
                    {
                        if (autorBuscado == imagenes[i].autor)
                        {
                            Console.WriteLine("Imagen {0}", i + 1);
                            Console.WriteLine("Título: {0}.{1}", imagenes[i].titulo, imagenes[i].caracteristicas.formato);
                            Console.WriteLine("Ancho: {0}", imagenes[i].caracteristicas.ancho);
                            Console.WriteLine("Alto: {0}", imagenes[i].caracteristicas.alto);
                            Console.WriteLine("Peso: {0}", imagenes[i].caracteristicas.peso);
                            Console.WriteLine("Autor: {0}", imagenes[i].autor);
                            Console.WriteLine();
                        }
                    }

                    salir = false;
                    break;

                case 4:

                    int n;

                    do
                    {
                        Console.WriteLine("Número de imágen: ");
                        n = Convert.ToInt32(Console.ReadLine());

                        if (n > numImagen)
                        {
                            Console.WriteLine("Archivo encontrado");
                            Console.WriteLine("Inténtalo denuevo");
                            salir = false;
                        }
                        else
                        {
                            salir = true;
                        }

                    } while (!salir);

                    Console.WriteLine("Imagen {0}", n);
                    Console.WriteLine("Título: {0}.{1}", imagenes[n - 1].titulo, imagenes[n - 1].caracteristicas.formato);
                    Console.WriteLine("Ancho: {0}", imagenes[n - 1].caracteristicas.ancho);
                    Console.WriteLine("Alto: {0}", imagenes[n - 1].caracteristicas.alto);
                    Console.WriteLine("Peso: {0}", imagenes[n - 1].caracteristicas.peso);
                    Console.WriteLine("Autor: {0}", imagenes[n - 1].autor);
                    Console.WriteLine();

                    salir = false;
                    break;

                case 5:
                    salir = true;
                    break;


                default:
                    Console.WriteLine("Opción incorrecta");
                    Console.WriteLine("Elige otra opción");
                    salir = false;
                    break;
            }


        } while (!salir);

        Console.WriteLine("FIN");


    }

}
