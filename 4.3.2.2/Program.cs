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
            Console.WriteLine("5 - Borrar una imagen");
            Console.WriteLine("6 - Insertar una imagen");
            Console.WriteLine("7 - Salir");

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
                    Console.WriteLine();

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
                        Console.Write("Número de imágen: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        if (n > numImagen)
                        {
                            Console.WriteLine("Archivo no encontrado");
                            Console.WriteLine("Inténtalo denuevo");
                            Console.WriteLine();
                            salir = false;
                        }
                        else
                        {
                            Console.WriteLine("Imagen {0}", n);
                            Console.WriteLine("Título: {0}.{1}", imagenes[n - 1].titulo, imagenes[n - 1].caracteristicas.formato);
                            Console.WriteLine("Ancho: {0}", imagenes[n - 1].caracteristicas.ancho);
                            Console.WriteLine("Alto: {0}", imagenes[n - 1].caracteristicas.alto);
                            Console.WriteLine("Peso: {0}", imagenes[n - 1].caracteristicas.peso);
                            Console.WriteLine("Autor: {0}", imagenes[n - 1].autor);
                            Console.WriteLine();
                            salir = true;
                        }

                    } while (!salir);

                    salir = false;
                    break;

                case 5:

                    Console.Write("Que imagen quieres borrar: ");
                    int imagenBorrar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (imagenBorrar > numImagen || imagenBorrar < 1)
                    {
                        Console.WriteLine("Debes elegir una imagen guardada");
                        Console.WriteLine("Intentalo denuevo");
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = imagenBorrar - 1; i < numImagen - 1; i++)
                        {
                            imagenes[i].titulo = imagenes[i + 1].titulo;
                            imagenes[i].caracteristicas.formato = imagenes[i + 1].caracteristicas.formato;
                            imagenes[i].caracteristicas.ancho = imagenes[i + 1].caracteristicas.ancho;
                            imagenes[i].caracteristicas.alto = imagenes[i + 1].caracteristicas.alto;
                            imagenes[i].caracteristicas.peso = imagenes[i + 1].caracteristicas.peso;
                            imagenes[i].autor = imagenes[i + 1].autor;
                        }

                        numImagen--;
                    }

                    salir = false;
                    break;

                case 6:

                    Console.Write("Imagen a insertar: ");
                    int imagenInsertar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    imagenInsertar--;
                    numImagen++;

                    if (imagenInsertar > cantidad)
                    {
                        Console.WriteLine("No se pueden añadir más imágenes");
                        Console.WriteLine("Intentalo denuevo");
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = numImagen-1; i > imagenInsertar - 1; i--)
                        {
                            imagenes[i].titulo = imagenes[i - 1].titulo;
                            imagenes[i].caracteristicas.formato = imagenes[i - 1].caracteristicas.formato;
                            imagenes[i].caracteristicas.ancho = imagenes[i - 1].caracteristicas.ancho;
                            imagenes[i].caracteristicas.alto = imagenes[i - 1].caracteristicas.alto;
                            imagenes[i].caracteristicas.peso = imagenes[i - 1].caracteristicas.peso;
                            imagenes[i].autor = imagenes[i - 1].autor;
                        }

                        Console.WriteLine("Título: ");
                        imagenes[imagenInsertar].titulo = Console.ReadLine();
                        Console.WriteLine("Formato: ");
                        imagenes[imagenInsertar].caracteristicas.formato = Console.ReadLine();
                        Console.WriteLine("Ancho: ");
                        imagenes[imagenInsertar].caracteristicas.ancho = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Alto: ");
                        imagenes[imagenInsertar].caracteristicas.alto = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Peso: ");
                        imagenes[imagenInsertar].caracteristicas.peso = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Autor: ");
                        imagenes[imagenInsertar].autor = Console.ReadLine();
                        Console.WriteLine();

                    }

                    salir = false;
                    break;

                case 7:
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
