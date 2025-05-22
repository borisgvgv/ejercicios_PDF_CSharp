/*
(7.5.3) Crea una clase Casa, con una superficie (por ejemplo, 90 m2) y un método
"MostrarEstado" que escriba su superficie. Cada casa debe contener 3 puertas. Las
puertas tendrán un ancho, un alto y un método "MostrarEstado" que muestre su
ancho y su alto y la superficie de la casa en la que se encuentran. Crea un
programa de prueba que cree una casa y muestre sus datos y los de sus tres
puertas.
*/
// Me ha costado tres putos dias...

using System;

public class Program
{
    public static void Main()
    {

        Puertas casa1 = new Puertas();
        casa1.MostrarEstado();

    }
}

// ---------------------------------------------

public class Casa
{
    protected int superficie;
    public Casa() : this(90)
    {

    }
    public Casa(int superficie)
    {
        this.superficie = superficie;
    }

    public void MostrarEstado()
    {
        System.Console.WriteLine($"{superficie} m\u00B2");
    }

}
// ---------------------------------------------
public class Puertas
{
    protected int cantidad;
    protected int[,] ancho = new int[3, 3];
    protected int[,] alto = new int[3, 3];
    protected Casa[] casas = new Casa[9];
    public Puertas() : this(500, 200)
    {
    }
    public Puertas(int ancho, int alto)
    {
        System.Console.WriteLine("Cuantas casa quiere añadir");
        cantidad = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("La superficie de la casa 1 y las dimenciones de la puerta 1 de cada casa son valores fijos predeterminados");
        System.Console.WriteLine();

        for (int i = 0; i < cantidad; i++)
        {
            if (i == 0)
            {
                casas[i] = new Casa();
            }
            else
            {
                System.Console.Write($"Indica Superficie casa {i + 1}: ");
                int superficie = Convert.ToInt32(Console.ReadLine());
                casas[i] = new Casa(superficie);
            }

            for (int j = 0; j < 3; j++)
            {
                if (j == 0)
                {
                    this.ancho[i, j] = ancho;
                    this.alto[i, j] = alto;
                }
                else
                {
                    System.Console.Write($"Puerta {j + 1} casa {i + 1} Ancho : ");
                    this.ancho[i, j] = Convert.ToInt32(Console.ReadLine());
                    System.Console.Write($"Puerta {j + 1} casa {i + 1} Alto: ");
                    this.alto[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                System.Console.WriteLine();
            }
        }
    }

    public void MostrarEstado()
    {

        for (int i = 0; i < cantidad; i++)
        {
            System.Console.Write($" Superficie Casa {i + 1}: ");
            casas[i].MostrarEstado();
            for (int j = 0; j < 3; j++)
            {
                System.Console.WriteLine($"Ancho: {ancho[i, j]} cm, Alto: {alto[i, j]} cm");
            }
            System.Console.WriteLine();
        }
    }
}
