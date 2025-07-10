
/* Ejemplo 4._06a
Vamos a plantear un ejemplo completo que use tablas ("arrays"), registros
("struct") y que además manipule cadenas.
La idea va a ser la siguiente: Crearemos un programa que pueda almacenar datos
de hasta 1000 ficheros (archivos de ordenador). Para cada fichero, debe guardar
los siguientes datos: Nombre del fichero, Tamaño (en KB, un número de 0 a
8.000.000.000). El programa mostrará un menú que permita al usuario las
siguientes operaciones:

1- Añadir datos de un nuevo fichero
2- Mostrar los nombres de todos los ficheros almacenados
3- Mostrar ficheros que sean de más de un cierto tamaño (por ejemplo, 2000 KB).
4- Ver todos los datos de un cierto fichero (a partir de su nombre)
5- Salir de la aplicación (como aún no sabemos usar ficheros, los datos se
perderán).

*/

/*
(5.2.3) Descompón en funciones la base de datos de ficheros (ejemplo 04_06a), de
modo que el "Main" sea breve y más legible (Pista: las variables que se compartan
entre varias funciones deberán estar fuera de todas ellas, y deberán estar
precedidas por la palabra "static").
*/

/*
(8.1.2) Crea una versión de la base de datos de ficheros (ejercicio 5.2.3), de modo
que todos los datos se vuelquen a un fichero de texto al terminar la ejecución del
programa.
*/

/* En este utilizo un struct para acceder a los datos en lugar de split como hice en el ejercicio 8.1.2*/

using System;
using System.IO;
using System.Globalization;

public class Program
{


    public static void Main()
    {
        Console.Clear();
        GestionSwitch gestionSwitch = new GestionSwitch();
    }

}

public class Menu
{
    protected byte opcion;
    public Menu()
    {
        do
        {
            System.Console.WriteLine("Menu");
            System.Console.WriteLine("1- Añadir datos de un nueva ficha");
            System.Console.WriteLine("2- Mostrar todas las fichas almacenadas");
            System.Console.WriteLine("3- Mostrar los nombres de todas las ficha almacenados");
            System.Console.WriteLine("4- Mostrar fichas que sean de más de un cierto tamaño");
            System.Console.WriteLine("5- Ver todos los datos de una cierta ficha");
            System.Console.WriteLine("0- Salir de la aplicación");
            opcion = Convert.ToByte(Console.ReadLine());

            if (opcion < 0 || opcion > 5)
            {
                System.Console.WriteLine("Opción incorrecta");
            }

        } while (opcion < 0 || opcion > 5);
    }

    public byte Opcion()
    {
        return opcion;
    }
}

public class GestionSwitch
{
    protected struct myStruct
    {
        public string nombre;
        public double tamanyo;
    }

    protected byte opcion;
    protected bool salir = false;
    protected int contador = 0;



    public GestionSwitch()
    {
        myStruct datos = new myStruct();


        do
        {
            Menu menu = new Menu();
            Console.Clear();
            switch (menu.Opcion())
            {
                case 1:

                    string linea;
                    if (contador == 0)
                    {
                        System.Console.WriteLine("1- Creamos ficha");
                        using (StreamWriter fichero = new StreamWriter("fichero.txt"))
                        {
                            System.Console.Write("Nombre: ");
                            datos.nombre = Console.ReadLine();
                            System.Console.Write("Tamaño: ");
                            datos.tamanyo = Convert.ToDouble(Console.ReadLine());
                            fichero.WriteLine($"Nombre: {datos.nombre}, Tamaño: {datos.tamanyo}");
                        }
                        if (contador == 0)
                            contador++;
                    }
                    else
                    {
                        System.Console.WriteLine("1- Añadimos datos a fichero");
                        using (StreamWriter fichero = new StreamWriter("fichero.txt", true))
                        {
                            System.Console.Write("Nombre: ");
                            datos.nombre = Console.ReadLine();
                            System.Console.Write("Tamaño: ");
                            datos.tamanyo = Convert.ToDouble(Console.ReadLine());
                            fichero.WriteLine($"Nombre: {datos.nombre}, Tamaño: {datos.tamanyo}");
                        }
                    }

                    break;

                case 2:

                    System.Console.WriteLine("2- Mostrar todas las fichas almacenadas");

                    using (StreamReader fichero = new StreamReader("fichero.txt"))
                    {
                        do
                        {
                            linea = fichero.ReadLine();
                            if (linea != null)
                            {
                                System.Console.WriteLine(linea);
                            }

                        } while (linea != null);


                    }
                    break;

                case 3:
                    System.Console.WriteLine("3- Mostrar los nombres de todas las ficha almacenados");

                    using (StreamReader fichero = new StreamReader("fichero.txt"))
                    {
                        do
                        {
                            linea = fichero.ReadLine();
                            if (linea != null)
                            {
                                // Separar la línea en partes
                                string[] parte = linea.Split(' ');

                                //Quitamos la coma final de cada nombre
                                if (parte[1].EndsWith(","))
                                {
                                    parte[1] = parte[1].Substring(0, parte[1].Length - 1);
                                }

                                System.Console.WriteLine(parte[1]);
                            }

                        } while (linea != null);

                    }
                    break;

                case 4:
                    System.Console.WriteLine("4- Mostrar ficheros que sean de más de un cierto tamaño");

                    using (StreamReader fichero = new StreamReader("fichero.txt"))
                    {

                        System.Console.Write("A partir de que tamaño quieres buscar?: ");
                        double buscarTamanyo = Convert.ToDouble(Console.ReadLine());

                        do
                        {
                            linea = fichero.ReadLine();
                            if (linea != null)
                            {
                                // Separar la línea en partes y evita que haya espacios de más
                                string[] parte = linea.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                                if (parte.Length > 3)
                                {
                                    string valor = parte[3];
                                    //Quitamos la coma final de cada nombre
                                    if (valor.EndsWith(","))
                                    {
                                        valor = valor.Substring(0, valor.Length - 1);
                                    }

                                    // Intentar convertir a double
                                    /*
                                    📌 NumberStyles.Any

                                    Esto le dice a TryParse:

                                        "Acepta casi cualquier estilo numérico válido".

                                    Incluye:

                                        Números con o sin decimales

                                        Con signo (-123, +45.67)

                                        Con espacio antes/después

                                        Con notación científica (1.2e3)

                                        Con separador de miles (ej. 1,000 o 1.000, depende del culture)

                                    📌 CultureInfo.InvariantCulture

                                    Esto define la cultura que se usa para interpretar el número.

                                    🔍 En concreto:

                                        Separador decimal: siempre punto (.)

                                        Separador de miles: coma (,), pero se ignora si no lo usas

                                    ✔️ Ejemplos válidos con InvariantCulture: (.)

                                    */
                                    if (double.TryParse(valor, NumberStyles.Any, CultureInfo.InvariantCulture, out double numero))
                                    {
                                        if (numero >= buscarTamanyo)
                                        {
                                            Console.WriteLine(linea);
                                        }
                                    }
                                }

                            }

                        } while (linea != null);
                    }

                    break;

                case 5:
                    int contadorFicha = 0;
                    System.Console.WriteLine("5- Ver todos los datos de una cierta ficha");


                    using (StreamReader fichero = new StreamReader("fichero.txt"))
                    {
                        System.Console.WriteLine("Que ficha quieres ver");
                        int numeroFicha = Convert.ToInt32(Console.ReadLine());

                        do
                        {
                            contadorFicha++;
                            linea = fichero.ReadLine();
                            if (linea != null && numeroFicha == contadorFicha)
                            {
                                System.Console.WriteLine(linea);

                            }

                        } while (linea != null && numeroFicha != contadorFicha);
                    }

                    break;

                case 0:
                    salir = true;
                    break;

                default:
                    System.Console.WriteLine("Opcion incorrecta");
                    break;
            }


        } while (!salir);

    }

}









