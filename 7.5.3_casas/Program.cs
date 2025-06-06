/* Archivo de casas basado en ejercicio 7.5.3 

(7.5.3) Crea una clase Casa, con una superficie (por ejemplo, 90 m2) y un método
"MostrarEstado" que escriba su superficie. Cada casa debe contener 3 puertas. Las
puertas tendrán un ancho, un alto y un método "MostrarEstado" que muestre su
ancho y su alto y la superficie de la casa en la que se encuentran. Crea un
programa de prueba que cree una casa y muestre sus datos y los de sus tres
puertas.
*/

using System;
public class Program
{
    public static void Main()
    {
        Archivo casa1 = new Archivo();

        casa1.MostrarEstado();

    }
}

public class Casas
{
    protected int superficie;
    public Casas() : this(1000)
    {
    }
    public Casas(int superficie)
    {
        this.superficie = superficie;
    }

    public void MostrarEstado()
    {
        System.Console.WriteLine($"{superficie} m\u00B2");
    }
}

public class Puertas
{
    protected int alto;
    protected int ancho;
    public Puertas() : this(10, 5)
    {
    }
    public Puertas(int alto, int ancho)
    {
        this.alto = alto;
        this.ancho = ancho;
    }

    public void MostrarEstado()
    {
        System.Console.WriteLine($"Alto: {alto} cm");
        System.Console.WriteLine($"Ancho: {ancho} cm");
    }
}

public class Archivo
{
    protected const int capacidadCasas = 1000;
    protected int cantidadCasas = 0;
    protected Casas[] casa = new Casas[capacidadCasas];
    protected const int capacidadPuertas = 10000;
    protected Puertas[,] puerta = new Puertas[capacidadCasas, capacidadPuertas];
    protected bool salir = false;
    protected byte opcion;

    public Archivo()
    {
        do
        {
            System.Console.WriteLine("Menú");
            System.Console.WriteLine("1: Add datos de casa");
            System.Console.WriteLine("2: Mostrar datos");
            System.Console.WriteLine("0: Salir");

            opcion = Convert.ToByte(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    System.Console.WriteLine("Add datos de casa {0}", cantidadCasas + 1 );
               

                    break;
                case 2:
                    System.Console.WriteLine("Mostrar datos de casa");

                    break;
                case 0:
                    salir = true;
                    break;
                default:
                    System.Console.WriteLine("Opción incorrecta");
                    break;
            }

        } while (!salir);

    }

    public void MostrarEstado()
    {

    }



}

