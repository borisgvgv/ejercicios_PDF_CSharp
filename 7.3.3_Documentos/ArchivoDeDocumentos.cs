/*
(7.3.4) Amplía el proyecto Libro (ejercicio 7.2.5): tanto la clase Documento como la
clase Libro, tendrán un método ToString, que devuelva una cadena de texto
formada por título, autor y ubicación, separados por guiones. Crea una clase
Articulo, que añada el campo "procedencia". El cuerpo del programa permitirá
añadir Artículos o Libros, no documentos genéricos. El método ToString deberá
mostrar también el número de páginas de un libro y la procedencia de un artículo.
La opción de mostrar datos llamará a los correspondientes métodos ToString.
Recuerda usar "virtual" y "override" si en un primer momento no se comporta
como debe.
*/

using System;

public class ArchivoDeDocumentos
{
    public static void Main()
    {
        Console.Clear();

        GestionDeArchivos gestionDeArchivos = new GestionDeArchivos();
    }
}



public class Documento
{
    protected string tipoDDoc;
    protected string titulo;
    protected string autor;

    public Documento(string tipoDDoc, string titulo, string autor)
    {
        this.tipoDDoc = tipoDDoc;
        this.titulo = titulo;
        this.autor = autor;
    }

    public virtual string ToString()
    {
        return $"{tipoDDoc} - {autor} - {titulo}";
    }

}
public class Libro : Documento
{
    protected int numPag;
    public Libro(string titulo, string autor, int numPag) : base("Libro", titulo, autor)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.numPag = numPag;
    }

    public override string ToString()
    {
        return $"{base.ToString()} - {numPag.ToString()}";
    }
}

public class Articulo : Documento
{
    protected string procedencia;
    public Articulo(string titulo, string autor, string procedencia) : base("Articulo", titulo, autor)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.procedencia = procedencia;
    }

    public override string ToString()
    {
        return $"{base.ToString()} - {procedencia}";
    }
}

public class GestionDeArchivos
{
    protected bool abandonar = false;
    protected byte opcion;
    protected const int capacidad = 1000;
    protected int cantidad = 0;
    protected Documento[] doc = new Documento[capacidad];


    public GestionDeArchivos()
    {

        do
        {
            System.Console.WriteLine("Menú");
            System.Console.WriteLine("1: Add archivo");
            System.Console.WriteLine("2: Mostrar archivos");
            System.Console.WriteLine("3: Filtrar por tipo");
            System.Console.WriteLine("0: Salir");
            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    System.Console.WriteLine("caso 1");

                    if (cantidad < capacidad)
                    {
                        System.Console.Write("Tipo de documento: ");
                        string tipoDeDoc = Console.ReadLine();
                        string tipodedoc = tipoDeDoc.ToLower();

                        if (tipodedoc == "libro")
                        {
                            System.Console.Write("Titulo: ");
                            string titulo = Console.ReadLine();
                            System.Console.Write("Autor: ");
                            string autor = Console.ReadLine();
                            System.Console.Write("Número de páginas: ");
                            int numPag = Convert.ToInt32(Console.ReadLine());

                            doc[cantidad] = new Libro(titulo, autor, numPag);
                            cantidad++;

                        }
                        else if (tipodedoc == "artículo")
                        {
                            System.Console.Write("Titulo: ");
                            string titulo = Console.ReadLine();
                            System.Console.Write("Autor: ");
                            string autor = Console.ReadLine();
                            System.Console.Write("Procedencia: ");
                            string procedencia = Console.ReadLine();

                            doc[cantidad] = new Articulo(titulo, autor, procedencia);
                            cantidad++;
                        }
                        else if (tipodedoc != "artículo" && tipodedoc != "libro")
                        {
                            System.Console.WriteLine("No es posible añadir este tipo de documento");
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("No es posible añadir más datos");
                    }

                    break;
                case 2:
                    System.Console.WriteLine("Mostrar documentos");
                    for (int i = 0; i < cantidad; i++)
                    {
                        System.Console.WriteLine("Documento {0}", i + 1);
                        System.Console.WriteLine("Tipo de documento: {0}", doc[i].ToString());
                        System.Console.WriteLine();
                    }

                    break;
                case 3:
                    System.Console.WriteLine("Filtrar por tipo de documento");
                    System.Console.Write("Tipo de documento (libro/artículo): ");
                    string tipo = Console.ReadLine().ToLower();

                    bool encontrado = false;

                    for (int i = 0; i < cantidad; i++)
                    {
                        if (tipo == "libro" && doc[i] is Libro)
                        {
                            encontrado = true;
                            System.Console.WriteLine("Documento {0}", i + 1);
                            System.Console.WriteLine(doc[i].ToString());
                            System.Console.WriteLine();
                        }

                        if (tipo == "artículo" && doc[i] is Articulo)
                        {
                            encontrado = true;
                            System.Console.WriteLine("Documento {0}", i + 1);
                            System.Console.WriteLine(doc[i].ToString());
                            System.Console.WriteLine();
                        }
                    }

                    if (!encontrado)
                    {
                        System.Console.WriteLine("No hay documentos de ese tipo.");
                    }
                    break;
                case 0:
                    abandonar = true;

                    break;

                default:
                    System.Console.WriteLine("Opcion Incorrecta");
                    break;
            }

        } while (!abandonar);

    }

}